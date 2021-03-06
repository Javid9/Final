#pragma checksum "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f6562e7b2f6d75f270e1c109b836af6da8f68a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\_ViewImports.cshtml"
using JobSearchEndProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\_ViewImports.cshtml"
using JobSearchEndProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\_ViewImports.cshtml"
using JobSearchEndProject.ViewModels.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\_ViewImports.cshtml"
using JobSearchEndProject.ViewModels.Home;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f6562e7b2f6d75f270e1c109b836af6da8f68a", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8a8b7d4b25bbb971e35642b73528f302d1b7d6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mx-auto d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialSubscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""blog-details-bg"">
    <div class=""bg-overlay""></div>
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-6"">
                <div class=""page-header-title text-center text-white"">
                    <h1 class=""font-weight-light"">Blog Details</h1>
                    <div>
                        <ol class=""breadcrumb justify-content-center"">
                            <li class=""breadcrumb-item""><a href=""#"">Joobsy</a></li>
                            <li class=""breadcrumb-item""><a href=""#"">Blog</a></li>
                            <li class=""breadcrumb-item active"">Blog Details</li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- end home -->
<!-- BLOG LIST START -->
<section class=""section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f6562e7b2f6d75f270e1c109b836af6da8f68a6693", async() => {
                WriteLiteral(@"
                    <input class=""form-control search-form"" type=""search"" placeholder=""Search..."">
                    <button class=""search-button"" type=""submit""><a href=""#"" class=""text-dark""><span class=""mdi mdi-magnify""></span></a></button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                <div class=""job-detail mt-4"">
                    <h5 class=""text-dark text-center p-2 mb-0"">Categories</h5>
                    <hr class=""m-0"">
                    <div class=""blog-datails-item p-3"">
                        <ul class=""list-inline mb-0"">
");
#nullable restore
#line 40 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                             foreach (var item in ViewBag.Category)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"mb-2\"><a href=\"#\" class=\"text-muted\"><i class=\"mdi mdi-chevron-right mr-2\"></i>");
#nullable restore
#line 42 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                                                                                     Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 43 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
                
                <div class=""job-detail mt-4"">
                    <h5 class=""text-dark text-center p-2 mb-0"">Archives</h5>
                    <hr class=""m-0"">
                    <div class=""blog-datails-item p-3"">
                        <ul class=""list-inline mb-0"">
                            <li class=""mb-2""><a href=""#"" class=""text-muted""><i class=""mdi mdi-chevron-right mr-2""></i>08 January 2018</a></li>
                            <li class=""mb-2""><a href=""#"" class=""text-muted""><i class=""mdi mdi-chevron-right mr-2""></i>13 February 2018</a></li>
                            <li class=""mb-2""><a href=""#"" class=""text-muted""><i class=""mdi mdi-chevron-right mr-2""></i>10 March 2018</a></li>
                            <li class=""mb-2""><a href=""#"" class=""text-muted""><i class=""mdi mdi-chevron-right mr-2""></i>06 April 2018</a></li>
                            <li class=""mb-2""><a href=""#"" class=""text-muted""");
            WriteLiteral(@"><i class=""mdi mdi-chevron-right mr-2""></i>12 May 2018</a></li>
                            <li class=""mb-2""><a href=""#"" class=""text-muted""><i class=""mdi mdi-chevron-right mr-2""></i>27 June 2018</a></li>
                        </ul>
                    </div>
                </div>

                <div class=""job-detail mt-4"">
                    <h5 class=""text-dark text-center p-2 mb-0"">Archives</h5>
                    <hr class=""m-0"">
                    <div class="" p-3"">
                        <div class=""media"">
                            <div class=""blog-list-img mr-2"">
                                <img src=""images/employers/img-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3611, "\"", 3617, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid mx-auto d-block rounded"">
                            </div>
                            <div class=""media-body ml-2"">
                                <p class=""mb-0 text-muted mb-0 f-13""><a href=""#"" class=""text-dark"">In enime justo rhoncuse ut imperdiete as vitae justo niti nullam.</a></p>
                                <ul class=""list-inline mb-0"">
                                    <li class=""list-inline-item"">
                                        <a href=""#"" class=""text-dark"">
                                            <p class=""mb-0"">View all</p>
                                        </a>
                                    </li>
                                    <li class=""list-inline-item float-right"">
                                        <p class=""text-dark mb-0"">15-Dec-2018</p>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <hr>

 ");
            WriteLiteral("                       <div class=\"media\">\r\n                            <div class=\"blog-list-img mr-2\">\r\n                                <img src=\"images/employers/img-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4817, "\"", 4823, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid mx-auto d-block rounded"">
                            </div>
                            <div class=""media-body ml-2"">
                                <p class=""mb-0 text-muted mb-0 f-13""><a href=""#"" class=""text-dark"">Integer tincidunte dapibus that Vivamus semper as vulputate.</a></p>
                                <ul class=""list-inline mb-0"">
                                    <li class=""list-inline-item"">
                                        <a href=""#"" class=""text-dark"">
                                            <p class=""mb-0"">View all</p>
                                        </a>
                                    </li>
                                    <li class=""list-inline-item float-right"">
                                        <p class=""text-dark mb-0"">22-Jan-2018</p>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <hr>

      ");
            WriteLiteral("                  <div class=\"media\">\r\n                            <div class=\"blog-list-img mr-2\">\r\n                                <img src=\"images/employers/img-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6018, "\"", 6024, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid mx-auto d-block rounded"">
                            </div>
                            <div class=""media-body ml-2"">
                                <p class=""mb-0 text-muted mb-0 f-13""><a href=""#"" class=""text-dark"">Aliquam lorem dapibus a in viverra quis feugiat metus.</a></p>
                                <ul class=""list-inline mb-0"">
                                    <li class=""list-inline-item"">
                                        <a href=""#"" class=""text-dark"">
                                            <p class=""mb-0"">View all</p>
                                        </a>
                                    </li>
                                    <li class=""list-inline-item float-right"">
                                        <p class=""text-dark mb-0"">05-Sep-2018</p>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                ");
            WriteLiteral(@"</div>

                <div class=""job-detail mt-4 mb-5"">
                    <h5 class=""text-dark text-center p-2 mb-0"">Tags</h5>
                    <hr class=""m-0"">
                    <div class="" p-3"">
                        <div class=""blog-tages text-center"">

                            <a href=""#"">Creative</a>
                            <a href=""#"">Developer</a>
                            <a href=""#"">Wordpress</a>
                            <a href=""#"">Design</a>
                            <a href=""#"">Google</a>
                            <a href=""#"">Traffic</a>
                            <a href=""#"">ISO</a>
                            <a href=""#"">Blog</a>
                            <a href=""#"">Resume</a>
                            <a href=""#"">Themes</a>
                            <a href=""#"">Job</a>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-lg-8"">
                <div class=""job");
            WriteLiteral("-detail mt-4 p-2\">\r\n                    <div class=\"blog-details-img\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47f6562e7b2f6d75f270e1c109b836af6da8f68a16658", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8179, "~/images/blog/", 8179, 14, true);
#nullable restore
#line 154 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 8193, Model.Blog.Image, 8193, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""blog-details meta mt-2"">
                        <ul class=""list-inline mb-1"">
                            <li class=""list-inline-item mr-4"">
                                <p class=""text-muted mb-0""><i class=""mdi mdi-calendar-range mr-1""></i>");
#nullable restore
#line 159 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                                                                 Write(Model.Blog.CreateTime.ToString("MM/MMMM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </li>\r\n\r\n                            <li class=\"list-inline-item mr-4\">\r\n                                <p class=\"text-muted mb-0\"><i class=\"mdi mdi-message-reply-text mr-1\"></i>");
#nullable restore
#line 163 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                                                                     Write(Model.Comments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </li>\r\n\r\n                            <li class=\"list-inline-item\">\r\n                                <p class=\"text-muted mb-0\"><i class=\"mdi mdi-layers mr-1\"></i>");
#nullable restore
#line 167 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                                                         Write(Model.Blog.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"blog-details-desc p-2\">\r\n                        <h6 class=\"mb-3 f-18\"><a href=\"#\" class=\"text-dark\">");
#nullable restore
#line 172 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                                       Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n\r\n                        <p class=\"text-muted mb-3 f-13\">");
#nullable restore
#line 174 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                   Write(Model.Blog.AllDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>



                        <div class=""blog-blockquote-desc mb-5 mt-4"">
                            <blockquote class=""blockquote position-relative"">
                                <i class=""fas fa-quote-left text-custom""></i>
                                <p class=""mb-2 font-italic f-14 text-dark"">");
#nullable restore
#line 181 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                                      Write(Model.Blog.AuthorDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <h6 class=\"mb-0\"><a href=\"#\" class=\"text-dark\">By : ");
#nullable restore
#line 182 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                                               Write(Model.Blog.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h6>
                            </blockquote>
                        </div>

                        <hr class=""mb-2"">
                        <ul class=""list-inline mb-0"">
                            <li class=""list-inline-item mt-1"">
                                <a href=""#"" class=""text-dark"">
                                    <p class=""mb-0 f-17""><i class=""mdi mdi-heart-outline mr-1 text-custom""></i>Like</p>
                                </a>
                            </li>
                            <li class=""list-inline-item float-right"">
                                <ul class=""blog-details-icons list-inline"">
                                    <li class=""list-inline-item f-16"">Share :</li>
                                    <li class=""list-inline-item""><a");
            BeginWriteAttribute("href", " href=\"", 10675, "\"", 10702, 1);
#nullable restore
#line 196 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 10682, Model.Blog.Facebook, 10682, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 10703, "\"", 10711, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-facebook\"></i></a></li>\r\n                                    <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 10823, "\"", 10849, 1);
#nullable restore
#line 197 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 10830, Model.Blog.Twitter, 10830, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 10850, "\"", 10858, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-twitter\"></i></a></li>\r\n                                    <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 10969, "\"", 10996, 1);
#nullable restore
#line 198 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 10976, Model.Blog.Whatsapp, 10976, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 10997, "\"", 11005, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-whatsapp\"></i></a></li>\r\n                                    <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 11117, "\"", 11145, 1);
#nullable restore
#line 199 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 11124, Model.Blog.Instagram, 11124, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 11146, "\"", 11154, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""mdi mdi-instagram""></i></a></li>
                                </ul>
                            </li>
                        </ul>
                        <hr class=""mt-2 mb-2"">
                    </div>
                </div>

                <h5 class=""text-dark mt-4""><i class=""mdi mdi-comment-multiple mr-2""></i>");
#nullable restore
#line 207 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                                                   Write(Model.Comments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                <div class=\"job-detail p-4\" id=\"mainDiv\">\r\n");
#nullable restore
#line 210 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                     foreach (var item in Model.Comments)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"media\" id=\"mediaa\">\r\n                        <div class=\"blog-comment-img\">\r\n                            <img class=\"img-fluid d-block mx-auto rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 11858, "\"", 11864, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"images/employers/img-6.jpg\">\r\n                        </div>\r\n                        <div class=\"media-body ml-3\">\r\n                            <h6 class=\"mb-0\"><a href=\"#\" class=\"text-dark\">");
#nullable restore
#line 217 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                                      Write(item.AppUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                            <p class=\"text-muted mb-0\">");
#nullable restore
#line 218 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                  Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"text-muted f-14 mb-2\">");
#nullable restore
#line 219 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                       Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"mb-0\"><a href=\"#\" class=\"text-muted\"><i class=\"mdi mdi-reply-all mr-2\"></i>Reply</a></p>\r\n                            <hr>\r\n                        </div>\r\n");
#nullable restore
#line 223 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                         if (item.AppUser.UserName == User.Identity.Name)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-warning\" id=\"deleteBtn\" data-id=\"");
#nullable restore
#line 225 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</a>\r\n");
#nullable restore
#line 226 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 228 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
                                 
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <hr>

                    <hr>
                </div>
                <h5 class=""text-dark mt-4""><i class=""mdi mdi-pencil mr-2""></i>Leave Your Comments</h5>
                <div class=""job-detail p-4"">
                    <div class=""custom-form"">
                       
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""form-group blog-details-form"">
                                        <i class=""mdi mdi-comment-processing text-muted f-17""></i>
                                        <textarea name=""message"" id=""messageInput"" rows=""4"" class=""form-control blog-details"" placeholder=""Comment""></textarea>
                                        <input type=""text"" name=""blogId"" id=""blogIdHidden""");
            BeginWriteAttribute("value", " value=\"", 13597, "\"", 13619, 1);
#nullable restore
#line 243 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 13605, Model.Blog.Id, 13605, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden />
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <button  id=""submitComment"" class=""submitBnt btn btn-custom"">Post Comment</button>
                                </div>
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- BLOG LIST END -->
<!-- subscribe start -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47f6562e7b2f6d75f270e1c109b836af6da8f68a31467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- subscribe end -->\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script src=""https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js""></script>
        <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
        <script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
        <script>
            let message = document.querySelector('#messageInput');
            let blogId = document.querySelector('#blogIdHidden');
            let commentBtn = document.querySelector('#submitComment');

            commentBtn.addEventListener('click', function()  {

             let formData = new FormData();

          formData.append(""Message"", message.value);
          formData.append(""BlogId"", blogId.value);


                axios.post('/Blog/CreateComment',formData)
                .then(function (response) {
                    //console.log(response.data.time);
                    let date = new Date();
                   let childDiv=
                    ` <div class=""media"" id=""mediaa"">
                            <div class=""");
                WriteLiteral(@"blog-comment-img"">
                                <img class=""img-fluid d-block mx-auto rounded-circle"" alt="""" src=""images/employers/img-6.jpg"">
                            </div>
                            <div class=""media-body ml-3"">
                                <h6 class=""mb-0""><a href=""#"" class=""text-dark"">${response.data.user}</a></h6>
                                <p class=""text-muted mb-0"">${response.data.time}</p>
                                <p class=""text-muted f-14 mb-2"">${response.data.message}</p>
                                <p class=""mb-0""><a href=""#"" class=""text-muted""><i class=""mdi mdi-reply-all mr-2""></i>Reply</a></p>
                                <hr>
                            </div>
                          <a class=""btn btn-warning"" id=""deleteBtn"" data-id=""${response.data.Id}"">Delete</a>   
                        </div>
                            `
                    let mainDiv = document.getElementById(""mainDiv"");
                    mainDiv.innerHTML");
                WriteLiteral(@" += childDiv;
                    message.value = """";
                })


                .catch(function (error) {
                  if (error.response){
                    let errorObj =  error.response.data;
                    for(let errors in errorObj){
                        let error = errorObj[errors];
                        console.log(error);
                    }
                  }
                });

        })

            // Delete
            $(document).on(""click"", ""#deleteBtn"", function () {

                let id = $(this).attr(""data-id"");


                $.ajax({
                    url: ""/Blog/DeleteComment?Id="" + id,
                    type: ""Get"",
                    success: function (res) {

                    }
                });

                $(this).closest('#mediaa').remove()
            });
            

        </script>
    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
