#pragma checksum "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adf24bfa6687116c926c25dfe3afb769ed7f67de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employer_DeletedJobList), @"mvc.1.0.view", @"/Views/Employer/DeletedJobList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adf24bfa6687116c926c25dfe3afb769ed7f67de", @"/Views/Employer/DeletedJobList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d8be59ac70f473ae4690afee60c7338b38433f", @"/Views/_ViewImports.cshtml")]
    public class Views_Employer_DeletedJobList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-display", new global::Microsoft.AspNetCore.Html.HtmlString("Select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mx-auto d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("apply-btn-sm btn-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActivateJob", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Job", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
  
    ViewData["Title"] = "DeleteList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""page-header"">
    <div class=""bg-overlay""></div>
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-6"">
                <div class=""page-header-title text-center text-white"">
                    <h4 class=""text-uppercase"">Job List view</h4>
                    <div>
                        <ol class=""breadcrumb justify-content-center"">
                            <li class=""breadcrumb-item""><a href=""#"">Joobsy</a></li>
                            <li class=""breadcrumb-item""><a href=""#"">Jobs</a></li>
                            <li class=""breadcrumb-item active"">Job List</li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- end home -->

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adf24bfa6687116c926c25dfe3afb769ed7f67de9816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- JOB LIST START -->
<section class=""section pt-0"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-6"">
                <div class=""title text-center mb-5"">
                    <h4>Available job for you</h4>
                    <p class=""text-muted mb-1"">minima veniam quis nostrum exercitationem Quis autem vel eum iure</p>
                    <div class=""title-icon position-relative"">
                        <i class=""mdi mdi-chevron-down position-relative h3 text-custom bg-white""></i>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">

            <div class=""col-lg-12"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-12"">
                        <div class=""show-results mt-4"">
                            <div class=""float-left"">
                                <h5 class=""text-dark mb-0 pt-2 f-18"">Showing results 0-20<");
            WriteLiteral("/h5>\r\n                            </div>\r\n                            <div class=\"sort-button float-right\">\r\n                                <select class=\"nice-select\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf24bfa6687116c926c25dfe3afb769ed7f67de12233", async() => {
                WriteLiteral("Nothing");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf24bfa6687116c926c25dfe3afb769ed7f67de13312", async() => {
                WriteLiteral("Web Developer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf24bfa6687116c926c25dfe3afb769ed7f67de14515", async() => {
                WriteLiteral("PHP Developer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf24bfa6687116c926c25dfe3afb769ed7f67de15718", async() => {
                WriteLiteral("Web Designer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </select>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf24bfa6687116c926c25dfe3afb769ed7f67de17073", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 66 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                     foreach (var item in Model)
                    {
                        var minutesPassed = (int)(DateTime.Now - item.CreateTime).TotalMinutes;
                        var hoursPassed = (int)(DateTime.Now - item.CreateTime).TotalHours;
                        var daysPassed = (int)(DateTime.Now - item.CreateTime).TotalDays;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""job-list-box mt-4"">
                                    <div class=""p-3"">
                                        <div class=""row align-items-center"">
                                            <div class=""col-lg-2"">
                                                <div class=""company-logo-img"">
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "adf24bfa6687116c926c25dfe3afb769ed7f67de18433", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3516, "~/images/", 3516, 9, true);
#nullable restore
#line 78 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
AddHtmlAttributeValue("", 3525, item.Image, 3525, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-lg-7 col-md-9"">
                                                <div class=""job-list-desc"">
                                                    <h5 class=""mb-2""><a href=""#"" class=""text-dark"">Title: ");
#nullable restore
#line 83 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h5>\r\n                                                    <p class=\"text-muted mb-0\">Category: <b>");
#nullable restore
#line 84 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                       Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> </p>\r\n                                                    <p class=\"text-muted mb-0\"><i class=\"mdi mdi-bank mr-2\"></i>");
#nullable restore
#line 85 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                                           Write(item.City.CityName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                                    <ul class=""list-inline mb-0"">
                                                        <li class=""list-inline-item mr-3"">
                                                            <p class=""text-muted mb-0""><i class=""mdi mdi-map-marker mr-2""></i>");
#nullable restore
#line 88 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                                                         Write(item.Country.CountryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                            <p class=\"text-muted mb-0\">Email: ");
#nullable restore
#line 89 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                         Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                            <p class=\"text-muted mb-0\">Description: ");
#nullable restore
#line 90 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                               Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                            <p class=\"text-muted mb-0\">Experience: ");
#nullable restore
#line 91 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                              Write(item.Experience);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                            <p class=\"text-muted mb-0\">Minx Salary: ");
#nullable restore
#line 92 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                               Write(item.MinSalary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                            <p class=\"text-muted mb-0\">Max Salary: ");
#nullable restore
#line 93 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                              Write(item.MaxSalary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                            <p class=\"text-muted mb-0\">User Name: ");
#nullable restore
#line 94 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                             Write(item.AppUser.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
                WriteLiteral("\r\n                                                        </li>\r\n\r\n");
#nullable restore
#line 99 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                         if (minutesPassed < 60)
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <li class=\"list-inline-item\">\r\n                                                                <p class=\"text-muted mb-0\"><i class=\"mdi mdi-clock-outline mr-2\"></i>");
#nullable restore
#line 102 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                                                                Write(minutesPassed);

#line default
#line hidden
#nullable disable
                WriteLiteral(" minutes ago </p>\r\n                                                            </li>\r\n");
#nullable restore
#line 104 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                        }
                                                        else if (hoursPassed < 24)
                                                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <li class=\"list-inline-item\">\r\n                                                                <p class=\"text-muted mb-0\"><i class=\"mdi mdi-clock-outline mr-2\"></i>");
#nullable restore
#line 109 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                                                                Write(hoursPassed);

#line default
#line hidden
#nullable disable
                WriteLiteral(" hours ago </p>\r\n                                                            </li>\r\n");
#nullable restore
#line 111 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <li class=\"list-inline-item\">\r\n                                                                <p class=\"text-muted mb-0\"><i class=\"mdi mdi-clock-outline mr-2\"></i>");
#nullable restore
#line 115 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                                                                Write(daysPassed);

#line default
#line hidden
#nullable disable
                WriteLiteral(" days ago </p>\r\n                                                            </li>\r\n");
#nullable restore
#line 117 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                    </ul>
                                                </div>
                                            </div>
                                            <div class=""col-lg-3 col-md-3"">
                                                <div class=""job-list-button-sm text-right"">
                                                    <span class=""badge badge-success"">");
#nullable restore
#line 123 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                 Write(item.JobType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n                                                    <div class=\"mt-3\">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf24bfa6687116c926c25dfe3afb769ed7f67de30021", async() => {
                    WriteLiteral("Activate");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 135 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12\">\r\n                        <nav aria-label=\"Page navigation example\">\r\n                            <ul class=\"pagination job-pagination mt-5 justify-content-center\">\r\n");
#nullable restore
#line 142 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                 for (int i = 1; i <= ViewBag.PageCount; i++)
                                {
                                    if (ViewBag.Page == i)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item disabled active\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 146 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 147 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf24bfa6687116c926c25dfe3afb769ed7f67de35965", async() => {
#nullable restore
#line 150 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 150 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                                                                                                               WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 151 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Views\Employer\DeletedJobList.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </nav>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591