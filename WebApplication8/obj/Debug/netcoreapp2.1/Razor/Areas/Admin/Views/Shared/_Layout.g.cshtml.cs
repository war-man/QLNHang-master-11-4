#pragma checksum "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cae8d49736f3455d1c064cfee8d1d9b291666d94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__Layout))]
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
#line 1 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
using WebApplication8.Models.UtilEntities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae8d49736f3455d1c064cfee8d1d9b291666d94", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a195f33263845ab48ac39bf7972ff81be67288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("skin-blue sidebar-mini sidebar-collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(67, 2236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "829cfb8393794e39b635e3a657f370ec", async() => {
                BeginContext(73, 116, true);
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>");
                EndContext();
                BeginContext(190, 13, false);
#line 7 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(203, 39, true);
                WriteLiteral(" - My ASP.NET MVC6 Application</title>\n");
                EndContext();
                BeginContext(407, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(412, 142, false);
#line 11 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.BoostrapValidatorCSS, Url.RouteUrl(new { controller = "/", area = "" }),Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(554, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(593, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(598, 132, false);
#line 13 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.LTE211CSS, Url.RouteUrl(new { controller = "/", area = "" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(730, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(777, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(782, 125, false);
#line 15 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.Modernizr,Url.RouteUrl(new {controller="/",area="" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(907, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(946, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(951, 132, false);
#line 17 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.JTableCSS, Url.RouteUrl(new { controller = "/", area = "" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(1083, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(1339, 957, true);
                WriteLiteral(@"    <style>
        .table-hover tbody tr:hover {
            background: #0094ff !important;
            color: white !important;

        }
        .bg-blue-selected {
            background: #0094ff !important;
            color: white !important;
        }

            .table-hover tbody tr:hover a, .table-hover tbody tr:hover a:hover, .table-hover tbody tr:hover a:active, .table-hover tbody tr:hover a:focus {
                color: white !important;
            }
        .daterangepicker .calendar-table th, .daterangepicker .calendar-table td {
            white-space: nowrap;
            text-align: center;
            vertical-align: middle;
            min-width: 22px;
            width: 22px;
            height: 24px;
            line-height: 24px;
            font-size: 11px;
            border-radius: 4px;
            border: 1px solid transparent;
            white-space: nowrap;
            cursor: pointer;
        }
    </style>
");
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
            BeginContext(2303, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2304, 2507, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f7dd3916c25480db11c1b6eebb24859", async() => {
                BeginContext(2358, 27, true);
                WriteLiteral("\n    <div class=\"wrapper\">\n");
                EndContext();
                BeginContext(2396, 43, false);
#line 52 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
     Write(await Html.PartialAsync("Partials/_Header"));

#line default
#line hidden
                EndContext();
#line 52 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                      ;

#line default
#line hidden
                BeginContext(2442, 66, true);
                WriteLiteral("\n        <!-- Left side column. contains the logo and sidebar -->\n");
                EndContext();
                BeginContext(2519, 42, false);
#line 55 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
     Write(await Html.PartialAsync("Partials/_Aside"));

#line default
#line hidden
                EndContext();
#line 55 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                     ; 

#line default
#line hidden
                BeginContext(2565, 1000, true);
                WriteLiteral(@"
        <!-- Content Wrapper. Contains page content -->

        <div class=""content-wrapper"">
            <section class=""content"">
                <div id=""loadingModal"" class=""modal fade"" role=""dialog"">
                    <div class=""modal-dialog"">
                        <!-- Modal content-->
                        <div class=""modal-content"">
                            <div class=""modal-body"">
                                Loading...
                            </div>
                        </div>
                    </div>
                </div>
                <div id=""processingModal"" class=""modal fade"" role=""dialog"">
                    <div class=""modal-dialog"">
                        <!-- Modal content-->
                        <div class=""modal-content"">
                            <div class=""modal-body"">
                                Đang xử lý...
                            </div>
                        </div>
                    </div>
                </div>
");
                EndContext();
#line 82 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
                  await Html.RenderPartialAsync("_Alerts"); 

#line default
#line hidden
                BeginContext(3681, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(3698, 12, false);
#line 83 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3710, 75, true);
                WriteLiteral("\n            </section>\n        </div><!-- /.content-wrapper -->\n\n        \n");
                EndContext();
                BeginContext(3796, 43, false);
#line 88 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
     Write(await Html.PartialAsync("Partials/_Footer"));

#line default
#line hidden
                EndContext();
#line 88 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                      ;

#line default
#line hidden
                BeginContext(3842, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(3854, 51, false);
#line 90 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
     Write(await Html.PartialAsync("Partials/_ControlSideBar"));

#line default
#line hidden
                EndContext();
#line 90 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                              ;

#line default
#line hidden
                BeginContext(3908, 29, true);
                WriteLiteral("    </div><!-- ./wrapper -->\n");
                EndContext();
                BeginContext(3979, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(3984, 131, false);
#line 93 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.LTE211JS, Url.RouteUrl(new { controller = "/", area = "" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(4115, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(4158, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(4163, 131, false);
#line 95 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.JTableJS, Url.RouteUrl(new { controller = "/", area = "" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(4294, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(4349, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(4354, 143, false);
#line 97 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.BootstrapValidatorJS, Url.RouteUrl(new { controller = "/", area = "" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(4497, 81, true);
                WriteLiteral("\n\n    <script>\n    $.widget.bridge(\'uibutton\', $.ui.button);\n    </script>\n\n\n    ");
                EndContext();
                BeginContext(4579, 41, false);
#line 104 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(4620, 184, true);
                WriteLiteral("\n\n    <script>\n    $(document).ready(function () {\n       // $(\"#id-alert\").fadeOut(6000);\n        // setTimeout(function () { $(\"#id-alert\").hide() }, 3000)\n    });\n\n    </script>\n\n\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4811, 10, true);
            WriteLiteral("\n\n\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
