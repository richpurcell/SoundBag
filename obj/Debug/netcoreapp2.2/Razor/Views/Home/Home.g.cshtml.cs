#pragma checksum "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f359a0d9b47985319324554cdcfabb19c377516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/_ViewImports.cshtml"
using SoundBag;

#line default
#line hidden
#line 2 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/_ViewImports.cshtml"
using SoundBag.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f359a0d9b47985319324554cdcfabb19c377516", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb9d78764a158d9219022d44db45c834aed1993", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wrapper>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
  
    var User = Model.AllUsers.FirstOrDefault(u=>u.UserId == Model.UserId);

#line default
#line hidden
            BeginContext(95, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(128, 257, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f359a0d9b47985319324554cdcfabb19c3775163528", async() => {
                BeginContext(134, 244, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>SoundBag</title>\n    <link rel=\"stylesheet\" href=\"/css/home_style.css\">\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(385, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(386, 3161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f359a0d9b47985319324554cdcfabb19c3775164950", async() => {
                BeginContext(392, 167, true);
                WriteLiteral("\n    <div class=\"container\">\n        <div class=\"banner\">\n            <h1>SoundBag Festivals</h1>\n            <h4 class=\"name\">Welcome, <a href=\"/mylist\" class=\"name\">");
                EndContext();
                BeginContext(560, 14, false);
#line 18 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                                                                Write(User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(574, 741, true);
                WriteLiteral(@"!</a></h4>
            <h4><a href=""/logout"" class=""logout"">Logout</a></h4>
            <div class=""line""></div>
        </div>
        <div class=""table"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                    <th scope=""col""><h5>Festival</h5></th>
                    <th scope=""col""><h5>Tickets</h5></th>
                    <th scope=""col""><h5>Start Date</h5></th>
                    <th scope=""col""><h5>End Date</h5></th>
                    <th scope=""col""><h5>Lineup</h5></th>
                    <th scope=""col""><h5>Attending</h5></th>
                    <th scope=""col""><h5>Actions</h5></th>
                    </tr>
                </thead>
                <tbody>
");
                EndContext();
#line 36 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                     foreach(var festival in Model.AllFestivals){

#line default
#line hidden
                BeginContext(1381, 96, true);
                WriteLiteral("                        <tr>\n                            <td>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1477, "\"", 1514, 2);
                WriteAttributeValue("", 1484, "/festival/", 1484, 10, true);
#line 39 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
WriteAttributeValue("", 1494, festival.FestivalId, 1494, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1515, 5, true);
                WriteLiteral("><h5>");
                EndContext();
                BeginContext(1521, 14, false);
#line 39 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                                                                        Write(festival.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1535, 111, true);
                WriteLiteral("</h5></a>\n                            </td>\n                            <td>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1646, "\"", 1673, 1);
#line 42 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
WriteAttributeValue("", 1653, festival.TicketLink, 1653, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1674, 125, true);
                WriteLiteral("><h5>Tickets</h5></a>\n                            </td>\n                            <td>\n                                <h5>");
                EndContext();
                BeginContext(1800, 36, false);
#line 45 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                               Write(festival.StartDate.ToString("MMM d"));

#line default
#line hidden
                EndContext();
                BeginContext(1836, 109, true);
                WriteLiteral("</h5>\n                            </td>\n                            <td>\n                                <h5>");
                EndContext();
                BeginContext(1946, 34, false);
#line 48 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                               Write(festival.EndDate.ToString("MMM d"));

#line default
#line hidden
                EndContext();
                BeginContext(1980, 107, true);
                WriteLiteral("</h5>\n                            </td>\n                            <td>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2087, "\"", 2114, 1);
#line 51 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
WriteAttributeValue("", 2094, festival.LineupLink, 2094, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2115, 5, true);
                WriteLiteral("><h5>");
                EndContext();
                BeginContext(2121, 28, false);
#line 51 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                                                              Write(festival.Title.Split(" ")[0]);

#line default
#line hidden
                EndContext();
                BeginContext(2149, 135, true);
                WriteLiteral("</h5></a>\n                            </td>\n                            <td>\n                                <h5 class=\" text-center\" >");
                EndContext();
                BeginContext(2285, 26, false);
#line 54 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                                                     Write(festival.Attendees.Count());

#line default
#line hidden
                EndContext();
                BeginContext(2311, 73, true);
                WriteLiteral("</h5>\n                            </td>\n                            <td>\n");
                EndContext();
#line 57 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                                  
                                    if(festival.OrganizerId == Model.UserId)
                                    {

#line default
#line hidden
                BeginContext(2534, 42, true);
                WriteLiteral("                                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2576, "\"", 2611, 2);
                WriteAttributeValue("", 2583, "/delete/", 2583, 8, true);
#line 60 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
WriteAttributeValue("", 2591, festival.FestivalId, 2591, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2612, 21, true);
                WriteLiteral("><h5>Delete</h5></a>\n");
                EndContext();
#line 61 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                                    } else {
                                        IEnumerable<int> yes = festival.Attendees.Select(att=>att.AttendeeId);
                                        

#line default
#line hidden
#line 63 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                                         if(yes.Contains((int)Model.UserId)){

#line default
#line hidden
                BeginContext(2867, 46, true);
                WriteLiteral("                                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2913, "\"", 2947, 2);
                WriteAttributeValue("", 2920, "/leave/", 2920, 7, true);
#line 64 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
WriteAttributeValue("", 2927, festival.FestivalId, 2927, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2948, 20, true);
                WriteLiteral("><h5>Leave</h5></a>\n");
                EndContext();
#line 65 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                                        } else {

#line default
#line hidden
                BeginContext(3017, 46, true);
                WriteLiteral("                                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3063, "\"", 3096, 2);
                WriteAttributeValue("", 3070, "/join/", 3070, 6, true);
#line 66 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
WriteAttributeValue("", 3076, festival.FestivalId, 3076, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3097, 19, true);
                WriteLiteral("><h5>Join</h5></a>\n");
                EndContext();
#line 67 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                                        }

#line default
#line hidden
#line 67 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                                         
                                    }
                                

#line default
#line hidden
                BeginContext(3230, 64, true);
                WriteLiteral("                            </td>\n                        </tr>\n");
                EndContext();
#line 72 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
                    }

#line default
#line hidden
                BeginContext(3316, 46, true);
                WriteLiteral("                </tbody>\n            </table>\n");
                EndContext();
#line 75 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
             if(User.Admin == true){

#line default
#line hidden
                BeginContext(3399, 101, true);
                WriteLiteral("                <a href=\"/new\" class=\"btn\"><button class=\"btn btn-primary\">Add Festival</button></a>\n");
                EndContext();
#line 77 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/Home.cshtml"
            }

#line default
#line hidden
                BeginContext(3514, 26, true);
                WriteLiteral("        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3547, 9, true);
            WriteLiteral("\n</html>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
