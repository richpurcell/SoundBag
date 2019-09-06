using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoundBag.Models
{
    public class Wrapper
    {
        public List<Festival> AllFestivals { get; set; }

        public List<Association> AllEvents {get;set;}
        public List<User> AllUsers {get;set;}
        public Festival OneFestival {get;set;}
        public Post OnePost {get;set;}
        public List<Post> AllPosts {get;set;}
        public int UserId {get;set;}
        public Task<Weather> Weather {get;set;}
        public Festival AllParticipants {get;set;}
    }
}