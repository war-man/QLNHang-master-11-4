#pragma checksum "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tblsalaries\GetBasicSalaryByEmpId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd1cda8bf3881857dc2f551710efa0d1d5aef5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Tblsalaries_GetBasicSalaryByEmpId), @"mvc.1.0.view", @"/Areas/Admin/Views/Tblsalaries/GetBasicSalaryByEmpId.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Tblsalaries/GetBasicSalaryByEmpId.cshtml", typeof(AspNetCore.Areas_Admin_Views_Tblsalaries_GetBasicSalaryByEmpId))]
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
#line 1 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tblsalaries\GetBasicSalaryByEmpId.cshtml"
using DAL.QLNHangData;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd1cda8bf3881857dc2f551710efa0d1d5aef5c", @"/Areas/Admin/Views/Tblsalaries/GetBasicSalaryByEmpId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a195f33263845ab48ac39bf7972ff81be67288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Tblsalaries_GetBasicSalaryByEmpId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(141, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tblsalaries\GetBasicSalaryByEmpId.cshtml"
  
    var list_result = (List<Tblsalary>)ViewData["list_result"];

#line default
#line hidden
#line 8 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tblsalaries\GetBasicSalaryByEmpId.cshtml"
  
    foreach (var s in list_result)
    {

#line default
#line hidden
            BeginContext(255, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(302, 36, false);
#line 13 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tblsalaries\GetBasicSalaryByEmpId.cshtml"
           Write(s.ChaDt.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(338, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(391, 36, false);
#line 16 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tblsalaries\GetBasicSalaryByEmpId.cshtml"
           Write(String.Format("{0:n0}", s.Lcb.Value));

#line default
#line hidden
            EndContext();
            BeginContext(427, 110, true);
            WriteLiteral("\n            </td>\n            <td>\n                <a class=\"btn btn-flat btn-sm btn-warning\" target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 537, "\"", 651, 5);
#line 19 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tblsalaries\GetBasicSalaryByEmpId.cshtml"
WriteAttributeValue("", 544, Url.RouteUrl(new {controller="Tblsalaries",action="EditEmpId",area="admin"}), 544, 77, false);

#line default
#line hidden
            WriteAttributeValue("", 621, "?EmpId=", 621, 7, true);
#line 19 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tblsalaries\GetBasicSalaryByEmpId.cshtml"
WriteAttributeValue("", 628, s.EmpId, 628, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 636, "&SeqNo=", 636, 7, true);
#line 19 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tblsalaries\GetBasicSalaryByEmpId.cshtml"
WriteAttributeValue("", 643, s.SeqNo, 643, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(652, 136, true);
            WriteLiteral("><i class=\"fa fa-pencil\"></i></a> |\n                <button class=\"btn btn-flat btn-sm btn-danger\"><i class=\"fa fa-close\"></i></button>\n");
            EndContext();
            BeginContext(1055, 32, true);
            WriteLiteral("            </td>\n        </tr>\n");
            EndContext();
#line 26 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Tblsalaries\GetBasicSalaryByEmpId.cshtml"
    }

#line default
#line hidden
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
