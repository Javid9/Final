#pragma checksum "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3994562856f6e0e2ac009748e721ffb5d2401729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ContactInfo_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactInfo/Index.cshtml")]
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
#line 2 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\_ViewImports.cshtml"
using JobSearchEndProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\_ViewImports.cshtml"
using JobSearchEndProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3994562856f6e0e2ac009748e721ffb5d2401729", @"/Areas/Admin/Views/ContactInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edfc0a79c4207cebf70fc9665030ce5ac4a058e3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ContactInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContactInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-lg-10 grid-margin stretch-card"" style=""position:absolute;right:0;top:120px"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">ContactInfo Table</h4>
");
#nullable restore
#line 11 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                     if (Model.Count() != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""table-responsive pt-3"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th>
                                            Website
                                        </th>
                                        <th>

                                            Call us
                                        </th>
                                        <th>

                                            Email
                                        </th>
                                        <th>

                                            Address
                                        </th>
                                        <th>

                                            Facebook
                                        </th>
                                        <th>

                             ");
            WriteLiteral(@"               Instagram
                                        </th>
                                        <th>

                                            Wahtsapp
                                        </th>
                                        <th>

                                            Tweeter
                                        </th>
                                        <th>

                                            Linkedin
                                        </th>
                                        <th>
                                            Setting
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 58 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                     foreach (ContactInfo item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 62 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                       Write(item.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 65 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                       Write(item.Callus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 68 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 71 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 74 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                       Write(item.Facebook);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 77 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                       Write(item.Instagram);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 80 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                       Write(item.Wahtsapp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 83 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                       Write(item.Tweeter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 86 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                       Write(item.Linkedin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3994562856f6e0e2ac009748e721ffb5d240172911115", async() => {
                WriteLiteral("\r\n                                                <i class=\"far fa-edit\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 94 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 98 "C:\Users\Cavid\source\repos\P116\AspCore\JobSearchEndProject\JobSearchEndProject\Areas\Admin\Views\ContactInfo\Index.cshtml"
                    }
                    else
                    {
                        //<h4 class="card-title">Empty Table</h4>
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContactInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
