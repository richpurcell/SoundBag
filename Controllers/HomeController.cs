using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // This is needed to use Session
using Newtonsoft.Json; // This is used to serialize/deserialize stuff into JSON 
using Microsoft.AspNetCore.Identity;
using SoundBag.Models;
using Microsoft.EntityFrameworkCore;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;





namespace SoundBag.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult blank()
        {
            return RedirectToAction("Home");
        }
        [HttpGet("signin")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MyLogin(Login myLogin) // This is the method where the form data from the LoginPartial goes to
        {
            if(ModelState.IsValid)
            {
                // If initial ModelState is valid, query for user with provided email
                var userInDb = dbContext.users.FirstOrDefault(u => u.Email == myLogin.LoginEmail);
                if(userInDb == null || userInDb.UserId == -1) // if User object returned is not defined (i.e. The User with myLogin.Password doesn't exist)
                {
                    // Add a ModelState Error and return to the LoginRegistration page
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("index");
                }
                // Initialize the hasher object
                var hasher = new PasswordHasher<Login>();
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(myLogin, userInDb.Password, myLogin.LoginPassword);
                // result can be compared to 0 for failure
                if(result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid Email/Password");
                    return View("index");
                }
                // Add UserId to the session. Done!
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("success"); // This is the page that the results will go to if the form is valid
            } else {
                return View("index"); // This is the action (method) that will be performed is the form is invalid
            }
        }
        [HttpPost] // This is the Post where we Register a new User
        public IActionResult AddUser(User myUser) // This is the method where the form data from the UserPartial goes to
        {
            if(ModelState.IsValid)
            {
                // Check if the Email is already in use
                if(dbContext.users.Any(u => u.Email == myUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("index");
                }
                // If the ModelState is valid
                PasswordHasher<User> Hasher = new PasswordHasher<User>(); // instantiate a PasswordHasher
                myUser.Password = Hasher.HashPassword(myUser, myUser.Password); // Create Passwword Hash
                dbContext.Add(myUser); // Add the new User to the database
                dbContext.SaveChanges(); // Don't forget to save
                User userInDb = dbContext.users.FirstOrDefault(u => u.Email == myUser.Email);
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("success");
            } else {
                return View("index"); // This is the action (method) that will be performed is the form is invalid
            }
        }
        [HttpGet("login")]
        public IActionResult login()
        {
            return View("index"); // Level I: Redirect to Login page. Done!
        }
        [HttpGet("success")]
        public IActionResult success()
        {
            // Only logged-in users should be able to see this page. If no user is in session, redirect to Login page. Done!
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("signin");
            }
            return RedirectToAction("home");
        }
        [HttpGet("logout")]
        public IActionResult logout()
        {
            // On logout clear Session
            HttpContext.Session.Clear();
            return View("index");
        }
        [HttpGet("new")]
        public IActionResult NewFestival()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult AddFestival(Festival newFestival)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            newFestival.OrganizerId = (int)UserId;
            if(ModelState.IsValid)
            {
                dbContext.Add(newFestival);
                dbContext.SaveChanges();
                int x = newFestival.FestivalId;
                return RedirectToAction("ViewFestival", new {FestivalId=$"{newFestival.FestivalId}"});
            } 
            return View("NewFestival");
        }
        [HttpGet("festival/{FestivalId}")]
        public IActionResult ViewFestival(int FestivalId)
        {
            Wrapper wrapper = new Wrapper();
            ApiKeys apiKey = new ApiKeys();
            ViewBag.apiKey = apiKey.Google;
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                UserId = -1;
            }
            wrapper.OnePost = new Post();
            wrapper.AllPosts = dbContext.posts
                .Where(p=>p.FestivalId == FestivalId)
                .OrderByDescending(p=>p.created_at)
                .ToList();
            wrapper.AllUsers = dbContext.users.ToList();
            wrapper.OneFestival = dbContext.festivals
                .Include(w=>w.Attendees)
                .ThenInclude(a=>a.Attendee)
                .FirstOrDefault(w=>w.FestivalId == FestivalId);
            var weather = Helper.GetWeatherAsync(wrapper.OneFestival.City);
            wrapper.Weather = weather;
            wrapper.UserId = (int)UserId;
            return View("ViewFestival", wrapper);
        }
        [HttpGet("delete/{FestivalId}")]
        public IActionResult Delete(int FestivalId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("index");
            }
            var thisFestival = dbContext.festivals.FirstOrDefault(w=>w.FestivalId == FestivalId);
            dbContext.Remove(thisFestival);
            dbContext.SaveChanges();
            return RedirectToAction("home");
        }
        // [HttpGet("home")]
        public IActionResult Home(string sortOrder, string searchString)
        {
            Wrapper MyWrapper = new Wrapper();
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                UserId = -1;
                HttpContext.Session.SetInt32("UserId", -1);
            }
            ViewBag.TitleSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.DateSortParm = sortOrder == "StartDate" ? "date_desc" : "StartDate";
            ViewBag.eDateSortParm = sortOrder == "EndDate" ? "edate_desc" : "EndDate";
            MyWrapper.AllUsers = dbContext.users.ToList();
            var AllFestivals = from s in dbContext.festivals
                .Where(a=>a.EndDate >= DateTime.Today)
                .Include(w => w.Attendees)
                .ThenInclude(a=>a.Attendee)
                select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                AllFestivals = AllFestivals.Where(s => s.Title.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "title_desc":
                    AllFestivals = AllFestivals.OrderByDescending(s => s.Title);
                    break;
                case "StartDate":
                    AllFestivals = AllFestivals.OrderBy(s => s.StartDate);
                    break;
                case "date_desc":
                    AllFestivals = AllFestivals.OrderByDescending(s => s.StartDate);
                    break;
                case "EndtDate":
                    AllFestivals = AllFestivals.OrderBy(s => s.EndDate);
                    break;
                case "edate_desc":
                    AllFestivals = AllFestivals.OrderByDescending(s => s.EndDate);
                    break;
                default:
                    AllFestivals = AllFestivals.OrderBy(s => s.Title);
                    break;
            }
            MyWrapper.AllFestivals = AllFestivals.ToList();
            MyWrapper.AllEvents = dbContext.associations.ToList();
            MyWrapper.UserId = (int)UserId;
            return View("Home", MyWrapper);
        }
        [HttpGet("join/{FestivalId}/stay")]
        public IActionResult JoinAndStay(int FestivalId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("index");
            }
            _helper_join(FestivalId, (int)UserId);
            return RedirectToAction("ViewFestival", new {FestivalId=$"{FestivalId}"});
        }
        [HttpGet("join/{FestivalId}/mylist")]
        public IActionResult JoinAndList(int FestivalId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("index");
            }
            _helper_join(FestivalId, (int)UserId);
            return RedirectToAction("MyFestivals", new {FestivalId=$"{FestivalId}"});
        }

        [HttpGet("join/{FestivalId}")]
        public IActionResult Join(int FestivalId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("index");
            }
            _helper_join(FestivalId, (int)UserId);
            return RedirectToAction("home");
        }
        [HttpGet("leave/{FestivalId}/stay")]
        public IActionResult LeaveAndStay(int FestivalId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("index");
            }
            _helper_leave(FestivalId, (int)UserId);
            return RedirectToAction("ViewFestival", new {FestivalId=$"{FestivalId}"});
        }
        [HttpGet("leave/{FestivalId}/mylist")]
        public IActionResult LeaveAndList(int FestivalId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("index");
            }
            _helper_leave(FestivalId, (int)UserId);
            return RedirectToAction("MyFestivals", new {FestivalId=$"{FestivalId}"});
        }

        [HttpGet("leave/{FestivalId}")]
        public IActionResult Leave(int FestivalId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("index");
            }
            _helper_leave(FestivalId, (int)UserId);
            return RedirectToAction("home");
        }
        [HttpGet("youtube/{FestivalId}")]
        public IActionResult YouTube(int FestivalId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(Wrapper myPost)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("index");
            }
            var id = myPost.OnePost.FestivalId;
            if(ModelState.IsValid)
            {
                string Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                myPost.OnePost.UserId = (int)UserId;
                dbContext.Add(myPost.OnePost);
                dbContext.SaveChanges();
                int x = myPost.OnePost.id;
                // System.Console.WriteLine($"Not Sure why it's not getting FestivalId {id} -------------------++++++++++++++++++");
                return RedirectToAction("ViewFestival", new {FestivalId=$"{myPost.OnePost.FestivalId}"});
            } else {
                // System.Console.WriteLine($"Not Sure why it's not getting FestivalId {id} -------------------++++++++++++++++++");
                return RedirectToAction("ViewFestival", new {FestivalId=$"{myPost.OnePost.FestivalId}"});
            }
        }
        [HttpGet("mylist")]
        public IActionResult MyFestivals()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null || UserId == -1)
            {
                return RedirectToAction("index");
            }
            var FestivalsWithParticipants = dbContext.festivals
                .Include(w => w.Attendees)
                .ThenInclude(a=>a.Attendee)
                .OrderBy(act => act.StartDate)
                .ToList();
            Wrapper MyWrapper = new Wrapper();
            MyWrapper.AllFestivals = FestivalsWithParticipants;
            MyWrapper.UserId = (int)UserId;
            return View(MyWrapper);
        }
        public void _helper_leave(int FestivalId, int UserId)
        {
            var IsAttending = dbContext.associations
                .Where(a=>a.FestivalId == FestivalId)
                .FirstOrDefault(a=>a.AttendeeId == UserId);
            dbContext.Remove(IsAttending);
            dbContext.SaveChanges();
            return;
        }
        public void _helper_join(int FestivalId, int UserId)
        {
            var IsAttending = dbContext.associations
                .Where(a=>a.FestivalId == FestivalId && a.AttendeeId == UserId).ToList();
            User thisUser = dbContext.users.FirstOrDefault(u=>u.UserId == UserId);
            Festival thisFestival = dbContext.festivals.FirstOrDefault(a=>a.FestivalId == FestivalId);
            if(IsAttending.Count() == 0)
            {
                Association Attending = new Association();
                Attending.AttendeeId = (int)UserId;
                Attending.FestivalId = FestivalId;
                dbContext.Add(Attending);
                dbContext.SaveChanges();
                return;
            }
        }

    }
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        // generic type T is a stand-in indicating that we need to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // Upon retrieval the object is deserialized based on the type specified
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
    public static class Helper
    {
        public static async Task<Weather> GetWeatherAsync(string city)
        {
            HttpClient client = new HttpClient();
            Weather weather = null;
            string path = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={apiKey.Weather}";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                weather = await response.Content.ReadAsAsync<Weather>();
            }
            return weather;
        }
        private const string BaseUrl = "http://pixabay.com/api/";
        private static ApiKeys apiKey = new ApiKeys();
        public static async Task<Pixabay> GetPhotsAsync(string query)
        {
            HttpClient aclient = new HttpClient();
            Pixabay pixabay = null;
            query = query.Replace(" ", "+");
            string path = BaseUrl + "?key=" + apiKey.Pixabay + "&q=" + query + "&image_type=photo";
            HttpResponseMessage response = await aclient.GetAsync(path);
            // System.Console.WriteLine(path);
            if (response.IsSuccessStatusCode)
            {
                pixabay = await response.Content.ReadAsAsync<Pixabay>();
            }
            return pixabay;
        }
    }
    public class PixabayClient
    {
        private static ApiKeys apiKey = new ApiKeys();
        private const string BaseUrl = "http://pixabay.com/api/";
        private static readonly HttpClient Client = new HttpClient();
        public PixabayClient(ApiKeys apiKey)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", apiKey.Pixabay);
        }
        public async Task<PixPhoto> SearchAsync(string query)
        {
            HttpResponseMessage response = await Client.GetAsync(BaseUrl + "?key=" + apiKey + "&q=" + query + "&image_type=photo").ConfigureAwait(false);
            return await GetResultAsync(response).ConfigureAwait(false);
        }
        public async Task<PixPhoto> PopularAsync(int page = 1, int perPage = 15)
        {
            HttpResponseMessage response = await Client.GetAsync(BaseUrl + "popular?per_page=" + perPage + "&page=" + page).ConfigureAwait(false);
            return await GetResultAsync(response).ConfigureAwait(false);
        }
        private static async Task<PixPhoto> GetResultAsync(HttpResponseMessage response)
        {
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<PixPhoto>(body);
            }
            throw new PexelsNetException(response.StatusCode, body);
        }
    }
}
