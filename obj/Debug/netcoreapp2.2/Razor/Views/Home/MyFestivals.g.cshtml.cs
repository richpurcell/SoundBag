#pragma checksum "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ff80d3d049ede4564366a794409d1321d05921"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyFestivals), @"mvc.1.0.view", @"/Views/Home/MyFestivals.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MyFestivals.cshtml", typeof(AspNetCore.Views_Home_MyFestivals))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2ff80d3d049ede4564366a794409d1321d05921", @"/Views/Home/MyFestivals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb9d78764a158d9219022d44db45c834aed1993", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MyFestivals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wrapper>
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
            BeginContext(15, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(48, 265, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2ff80d3d049ede4564366a794409d1321d059213370", async() => {
                BeginContext(54, 252, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>SoundBag</title>\n    <link rel=\"stylesheet\" href=\"/css/my_festivals_style.css\">\n");
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
            BeginContext(313, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(314, 6209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2ff80d3d049ede4564366a794409d1321d059214799", async() => {
                BeginContext(320, 924, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""banner"">
            <h1>SoundBag Festivals</h1>
            <a href=""/"" class=""home""><h4>Home</h4></a>
            <a href=""/logout"" class=""logout""><h4>Logout</h4></a>
            <div class=""line""></div>
        </div>
        <h4>Festivals I'm Attending</h4>
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
#line 34 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                     foreach(var festival in Model.AllFestivals){
                        var yes = ((IEnumerable<dynamic>)festival.Attendees).Select(att=>att.AttendeeId);
                        

#line default
#line hidden
#line 36 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                         if(yes.Contains((int)Model.UserId)){

#line default
#line hidden
                BeginContext(1478, 96, true);
                WriteLiteral("                        <tr>\n                            <td>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1574, "\"", 1611, 2);
                WriteAttributeValue("", 1581, "/festival/", 1581, 10, true);
#line 39 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 1591, festival.FestivalId, 1591, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1612, 5, true);
                WriteLiteral("><h5>");
                EndContext();
                BeginContext(1618, 14, false);
#line 39 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                                                        Write(festival.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1632, 111, true);
                WriteLiteral("</h5></a>\n                            </td>\n                            <td>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1743, "\"", 1770, 1);
#line 42 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 1750, festival.TicketLink, 1750, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1771, 125, true);
                WriteLiteral("><h5>Tickets</h5></a>\n                            </td>\n                            <td>\n                                <h5>");
                EndContext();
                BeginContext(1897, 36, false);
#line 45 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                               Write(festival.StartDate.ToString("MMM d"));

#line default
#line hidden
                EndContext();
                BeginContext(1933, 109, true);
                WriteLiteral("</h5>\n                            </td>\n                            <td>\n                                <h5>");
                EndContext();
                BeginContext(2043, 34, false);
#line 48 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                               Write(festival.EndDate.ToString("MMM d"));

#line default
#line hidden
                EndContext();
                BeginContext(2077, 107, true);
                WriteLiteral("</h5>\n                            </td>\n                            <td>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2184, "\"", 2211, 1);
#line 51 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 2191, festival.LineupLink, 2191, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2212, 5, true);
                WriteLiteral("><h5>");
                EndContext();
                BeginContext(2218, 28, false);
#line 51 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                                              Write(festival.Title.Split(" ")[0]);

#line default
#line hidden
                EndContext();
                BeginContext(2246, 135, true);
                WriteLiteral("</h5></a>\n                            </td>\n                            <td>\n                                <h5 class=\" text-center\" >");
                EndContext();
                BeginContext(2382, 26, false);
#line 54 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                                     Write(festival.Attendees.Count());

#line default
#line hidden
                EndContext();
                BeginContext(2408, 73, true);
                WriteLiteral("</h5>\n                            </td>\n                            <td>\n");
                EndContext();
#line 57 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                  
                                    if(festival.OrganizerId == Model.UserId)
                                    {

#line default
#line hidden
                BeginContext(2631, 42, true);
                WriteLiteral("                                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2673, "\"", 2708, 2);
                WriteAttributeValue("", 2680, "/delete/", 2680, 8, true);
#line 60 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 2688, festival.FestivalId, 2688, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2709, 21, true);
                WriteLiteral("><h5>Delete</h5></a>\n");
                EndContext();
#line 61 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                    } else {

#line default
#line hidden
                BeginContext(2775, 131, true);
                WriteLiteral("                                        <!-- var yes = ((IEnumerable<dynamic>)festival.Attendees).Select(att=>att.AttendeeId); -->\n");
                EndContext();
#line 63 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                         if(yes.Contains((int)Model.UserId)){

#line default
#line hidden
                BeginContext(2984, 46, true);
                WriteLiteral("                                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3030, "\"", 3071, 3);
                WriteAttributeValue("", 3037, "/leave/", 3037, 7, true);
#line 64 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 3044, festival.FestivalId, 3044, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 3064, "/mylist", 3064, 7, true);
                EndWriteAttribute();
                BeginContext(3072, 20, true);
                WriteLiteral("><h5>Leave</h5></a>\n");
                EndContext();
#line 65 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                        } else {

#line default
#line hidden
                BeginContext(3141, 46, true);
                WriteLiteral("                                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3187, "\"", 3227, 3);
                WriteAttributeValue("", 3194, "/join/", 3194, 6, true);
#line 66 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 3200, festival.FestivalId, 3200, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 3220, "/mylist", 3220, 7, true);
                EndWriteAttribute();
                BeginContext(3228, 19, true);
                WriteLiteral("><h5>Join</h5></a>\n");
                EndContext();
#line 67 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                        }

#line default
#line hidden
#line 67 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                         
                                    }
                                

#line default
#line hidden
                BeginContext(3361, 64, true);
                WriteLiteral("                            </td>\n                        </tr>\n");
                EndContext();
#line 72 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                        }

#line default
#line hidden
#line 72 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                         
                    }

#line default
#line hidden
                BeginContext(3473, 741, true);
                WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""line""></div>
        <h4>Other Festivals</h4>
        <div class=""table2"">
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
#line 93 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                     foreach(var festival in Model.AllFestivals){
                        var yes = ((IEnumerable<dynamic>)festival.Attendees).Select(att=>att.AttendeeId);
                        

#line default
#line hidden
#line 95 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                         if(!yes.Contains((int)Model.UserId)){

#line default
#line hidden
                BeginContext(4449, 96, true);
                WriteLiteral("                        <tr>\n                            <td>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4545, "\"", 4582, 2);
                WriteAttributeValue("", 4552, "/festival/", 4552, 10, true);
#line 98 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 4562, festival.FestivalId, 4562, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4583, 5, true);
                WriteLiteral("><h5>");
                EndContext();
                BeginContext(4589, 14, false);
#line 98 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                                                        Write(festival.Title);

#line default
#line hidden
                EndContext();
                BeginContext(4603, 111, true);
                WriteLiteral("</h5></a>\n                            </td>\n                            <td>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4714, "\"", 4741, 1);
#line 101 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 4721, festival.TicketLink, 4721, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4742, 125, true);
                WriteLiteral("><h5>Tickets</h5></a>\n                            </td>\n                            <td>\n                                <h5>");
                EndContext();
                BeginContext(4868, 36, false);
#line 104 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                               Write(festival.StartDate.ToString("MMM d"));

#line default
#line hidden
                EndContext();
                BeginContext(4904, 109, true);
                WriteLiteral("</h5>\n                            </td>\n                            <td>\n                                <h5>");
                EndContext();
                BeginContext(5014, 34, false);
#line 107 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                               Write(festival.EndDate.ToString("MMM d"));

#line default
#line hidden
                EndContext();
                BeginContext(5048, 107, true);
                WriteLiteral("</h5>\n                            </td>\n                            <td>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5155, "\"", 5182, 1);
#line 110 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 5162, festival.LineupLink, 5162, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5183, 5, true);
                WriteLiteral("><h5>");
                EndContext();
                BeginContext(5189, 28, false);
#line 110 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                                              Write(festival.Title.Split(" ")[0]);

#line default
#line hidden
                EndContext();
                BeginContext(5217, 135, true);
                WriteLiteral("</h5></a>\n                            </td>\n                            <td>\n                                <h5 class=\" text-center\" >");
                EndContext();
                BeginContext(5353, 26, false);
#line 113 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                                     Write(festival.Attendees.Count());

#line default
#line hidden
                EndContext();
                BeginContext(5379, 73, true);
                WriteLiteral("</h5>\n                            </td>\n                            <td>\n");
                EndContext();
#line 116 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                  
                                    if(festival.OrganizerId == Model.UserId)
                                    {

#line default
#line hidden
                BeginContext(5602, 42, true);
                WriteLiteral("                                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5644, "\"", 5679, 2);
                WriteAttributeValue("", 5651, "/delete/", 5651, 8, true);
#line 119 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 5659, festival.FestivalId, 5659, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5680, 21, true);
                WriteLiteral("><h5>Delete</h5></a>\n");
                EndContext();
#line 120 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                    } else {

#line default
#line hidden
                BeginContext(5746, 131, true);
                WriteLiteral("                                        <!-- var yes = ((IEnumerable<dynamic>)festival.Attendees).Select(att=>att.AttendeeId); -->\n");
                EndContext();
#line 122 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                         if(yes.Contains((int)Model.UserId)){

#line default
#line hidden
                BeginContext(5955, 46, true);
                WriteLiteral("                                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6001, "\"", 6042, 3);
                WriteAttributeValue("", 6008, "/leave/", 6008, 7, true);
#line 123 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 6015, festival.FestivalId, 6015, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 6035, "/mylist", 6035, 7, true);
                EndWriteAttribute();
                BeginContext(6043, 20, true);
                WriteLiteral("><h5>Leave</h5></a>\n");
                EndContext();
#line 124 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                        } else {

#line default
#line hidden
                BeginContext(6112, 46, true);
                WriteLiteral("                                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6158, "\"", 6198, 3);
                WriteAttributeValue("", 6165, "/join/", 6165, 6, true);
#line 125 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
WriteAttributeValue("", 6171, festival.FestivalId, 6171, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 6191, "/mylist", 6191, 7, true);
                EndWriteAttribute();
                BeginContext(6199, 19, true);
                WriteLiteral("><h5>Join</h5></a>\n");
                EndContext();
#line 126 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                        }

#line default
#line hidden
#line 126 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                                         
                                    }
                                

#line default
#line hidden
                BeginContext(6332, 64, true);
                WriteLiteral("                            </td>\n                        </tr>\n");
                EndContext();
#line 131 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                        }

#line default
#line hidden
#line 131 "/Users/richpurcell/Downloads/Coding-Dojo/C#_stack/ASP_MVC/SoundBag/Views/Home/MyFestivals.cshtml"
                         
                    }

#line default
#line hidden
                BeginContext(6444, 72, true);
                WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n");
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
            BeginContext(6523, 8, true);
            WriteLiteral("\n</html>");
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
