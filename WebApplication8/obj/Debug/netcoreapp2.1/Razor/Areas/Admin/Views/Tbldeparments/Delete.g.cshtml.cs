#pragma checksum "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dbaaf4ad9fe561e7389b051af4ef45406b17474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Tbldeparments_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Tbldeparments/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Tbldeparments/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Tbldeparments_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbaaf4ad9fe561e7389b051af4ef45406b17474", @"/Areas/Admin/Views/Tbldeparments/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a195f33263845ab48ac39bf7972ff81be67288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Tbldeparments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.QLNHangData.Tbldeparment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 164, true);
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Tbldeparment</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(299, 41, false);
#line 16 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepNm));

#line default
#line hidden
            EndContext();
            BeginContext(340, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(381, 37, false);
#line 19 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DepNm));

#line default
#line hidden
            EndContext();
            BeginContext(418, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(459, 41, false);
#line 22 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepN1));

#line default
#line hidden
            EndContext();
            BeginContext(500, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(541, 37, false);
#line 25 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DepN1));

#line default
#line hidden
            EndContext();
            BeginContext(578, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(619, 41, false);
#line 28 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepHg));

#line default
#line hidden
            EndContext();
            BeginContext(660, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(701, 37, false);
#line 31 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DepHg));

#line default
#line hidden
            EndContext();
            BeginContext(738, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(779, 41, false);
#line 34 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ColNo));

#line default
#line hidden
            EndContext();
            BeginContext(820, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(861, 37, false);
#line 37 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ColNo));

#line default
#line hidden
            EndContext();
            BeginContext(898, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(939, 41, false);
#line 40 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PeoTt));

#line default
#line hidden
            EndContext();
            BeginContext(980, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1021, 37, false);
#line 43 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PeoTt));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1099, 41, false);
#line 46 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SegHr));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1181, 37, false);
#line 49 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SegHr));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1259, 41, false);
#line 52 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RouMn));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1341, 37, false);
#line 55 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RouMn));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1419, 41, false);
#line 58 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RemDr));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1501, 37, false);
#line 61 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RemDr));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1579, 41, false);
#line 64 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SeqNo));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1661, 37, false);
#line 67 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SeqNo));

#line default
#line hidden
            EndContext();
            BeginContext(1698, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1739, 41, false);
#line 70 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DirDp));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1821, 37, false);
#line 73 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DirDp));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(1892, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "795e25cc491b4b4cb388684d86b47305", async() => {
                BeginContext(1918, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1927, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "463d2a3c5d004784907013f6ea383b48", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 78 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tbldeparments\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DepId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1966, 82, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n        ");
                EndContext();
                BeginContext(2048, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfa0dd2d9dab4a3eb8aa97e5ad954506", async() => {
                    BeginContext(2070, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2086, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2098, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL.QLNHangData.Tbldeparment> Html { get; private set; }
    }
}
#pragma warning restore 1591
