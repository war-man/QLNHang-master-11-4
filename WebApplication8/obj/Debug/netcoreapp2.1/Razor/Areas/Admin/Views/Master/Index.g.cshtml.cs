#pragma checksum "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d25dda9302b30109257ab16fe451a010f28bfa5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Master_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Master/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Master/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Master_Index))]
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
#line 1 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
using WebApplication8.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d25dda9302b30109257ab16fe451a010f28bfa5f", @"/Areas/Admin/Views/Master/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a195f33263845ab48ac39bf7972ff81be67288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Master_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/LoadDataTable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/ModelPopup.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(62, 117, true);
            WriteLiteral("<div style=\"border:1px solid grey;\">\n    <fieldset>\n        <legend style=\"padding-left:20px;\">Quản lý Role</legend>\n");
            EndContext();
#line 8 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
         using (Html.BeginForm("", "", FormMethod.Post, new { @class = "form-horizontal", id = "form-role" }))
        {
            

#line default
#line hidden
            BeginContext(456, 216, true);
            WriteLiteral("            <div class=\"col-md-4\">\n                <div class=\"form-group\">\n                    <label class=\"control-label col-md-2\">role:</label>\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(673, 90, false);
#line 16 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                   Write(Html.TextBox("NewRoleName", null, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(763, 175, true);
            WriteLiteral("\n                    </div>\n\n\n                </div>\n                <div class=\"col-md-offset-2\">\n                    <input class=\"btn btn-primary\" type=\"submit\" value=\"Add\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 938, "\"", 1028, 5);
            WriteAttributeValue("", 948, "form.action", 948, 11, true);
            WriteAttributeValue(" ", 959, "=", 960, 2, true);
            WriteAttributeValue(" ", 961, "\'", 962, 2, true);
#line 22 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
WriteAttributeValue("", 963, Url.RouteUrl(new {controller="/",area="" }), 963, 44, false);

#line default
#line hidden
            WriteAttributeValue("", 1007, "Admin/Master/AddRole\'", 1007, 21, true);
            EndWriteAttribute();
            BeginContext(1029, 46, true);
            WriteLiteral(" />\n                </div>\n            </div>\n");
            EndContext();
#line 25 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(1086, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 28 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
         using (Html.BeginForm("", "", FormMethod.Post, new { @class = "form-horizontal", id = "form-role-delete" }))
        {

#line default
#line hidden
            BeginContext(1215, 321, true);
            WriteLiteral(@"            <div class=""col-md-8"">
                <table class=""table table-responsive"">
                    <thead>
                        <tr>
                            <th>Roles</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 39 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                         foreach (var r in ViewBag.Roles)
                        {

#line default
#line hidden
            BeginContext(1620, 145, true);
            WriteLiteral("                            <tr>\n                                <td>\n                                    <input type=\"checkbox\" name=\"UserRoles\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1765, "\"", 1780, 1);
#line 43 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
WriteAttributeValue("", 1773, r.Name, 1773, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1781, 40, true);
            WriteLiteral(" />\n                                    ");
            EndContext();
            BeginContext(1822, 6, false);
#line 44 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                               Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 165, true);
            WriteLiteral("\n\n                                </td>\n                                <td>\n\n                                    <button type=\"button\" class=\"btn btn-sm btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1993, "\"", 2106, 7);
            WriteAttributeValue("", 2003, "form.action", 2003, 11, true);
            WriteAttributeValue(" ", 2014, "=", 2015, 2, true);
            WriteAttributeValue(" ", 2016, "\'", 2017, 2, true);
#line 49 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
WriteAttributeValue("", 2018, Url.RouteUrl(new {controller="/",area="" }), 2018, 44, false);

#line default
#line hidden
            WriteAttributeValue("", 2062, "Admin/Master/RemoveRole?OldRoleName=", 2062, 36, true);
#line 49 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
WriteAttributeValue("", 2098, r.Name, 2098, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2105, "\'", 2105, 1, true);
            EndWriteAttribute();
            BeginContext(2107, 74, true);
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#confirmDelete\" data-title=\"Delete item ");
            EndContext();
            BeginContext(2182, 6, false);
#line 49 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                                                                                                                                                                                                                                                              Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2188, 62, true);
            WriteLiteral("\" data-message=\"Are you sure you want to delete selected item ");
            EndContext();
            BeginContext(2251, 6, false);
#line 49 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                   Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2257, 124, true);
            WriteLiteral("?\"><i class=\"fa fa-trash\"></i> Delete role</button>\n                                </td>\n                            </tr>\n");
            EndContext();
#line 52 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"


                        }

#line default
#line hidden
            BeginContext(2409, 124, true);
            WriteLiteral("                    </tbody>\n                </table>\n                <button>Delete Selected</button>\n\n\n            </div>\n");
            EndContext();
#line 61 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(2544, 198, true);
            WriteLiteral("\n\n\n    </fieldset>\n    <hr />\n</div>\n<!--end rolemanagement-->\n\n<div style=\"border:1px solid grey; margin-top:20px;\">\n    <fieldset>\n        <legend style=\"padding-left:20px\">Quản lý User</legend>\n\n");
            EndContext();
#line 75 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
         using (Html.BeginForm("adduser", "master", FormMethod.Post, new { @class = "form-horizontal", role = "form", id = "form-user" }))
        {

#line default
#line hidden
            BeginContext(2891, 176, true);
            WriteLiteral("            <div class=\"form-group\">\n                <label for=\"Email\" class=\"control-label col-md-2\">Email</label>\n                <div class=\"col-md-6\">\n                    ");
            EndContext();
            BeginContext(3068, 60, false);
#line 80 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
               Write(Html.TextBox("Email", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3128, 226, true);
            WriteLiteral("\n                </div>\n\n            </div>\n            <div class=\"form-group\">\n                <label for=\"Password\" class=\"control-label col-md-2\">Password</label>\n                <div class=\"col-md-6\">\n                    ");
            EndContext();
            BeginContext(3355, 64, false);
#line 87 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
               Write(Html.Password("Password", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3419, 226, true);
            WriteLiteral("\n                </div>\n\n            </div>\n            <div class=\"form-group\">\n                <label for=\"Fullname\" class=\"control-label col-md-2\">Fullname</label>\n                <div class=\"col-md-6\">\n                    ");
            EndContext();
            BeginContext(3646, 63, false);
#line 94 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
               Write(Html.TextBox("Fullname", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3709, 44, true);
            WriteLiteral("\n                </div>\n\n            </div>\n");
            EndContext();
            BeginContext(3757, 75, true);
            WriteLiteral("            <div class=\"col-md-offset-2\">\n                <div>Roles</div>\n");
            EndContext();
#line 104 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                 foreach (var r in ViewBag.Roles)
                {

#line default
#line hidden
            BeginContext(3900, 91, true);
            WriteLiteral("                    <label>\n                        <input type=\"checkbox\" name=\"UserRoles\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3991, "\"", 4006, 1);
#line 107 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
WriteAttributeValue("", 3999, r.Name, 3999, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4007, 28, true);
            WriteLiteral(" />\n                        ");
            EndContext();
            BeginContext(4036, 6, false);
#line 108 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                   Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4042, 30, true);
            WriteLiteral("\n                    </label>\n");
            EndContext();
#line 110 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4090, 143, true);
            WriteLiteral("                <input class=\"btn btn-primary\" type=\"submit\" value=\"Add\" onclick=\"form.action = \'/Admin/Master/AddUser\'\" />\n            </div>\n");
            EndContext();
#line 113 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"



        }

#line default
#line hidden
            BeginContext(4246, 16, true);
            WriteLiteral("\n        <hr />\n");
            EndContext();
#line 119 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
         using (Html.BeginForm("", "", FormMethod.Post, new { @class = "form-horizontal", role = "form", id = "form-user" }))
        {

#line default
#line hidden
            BeginContext(4398, 313, true);
            WriteLiteral(@"            <table class=""table table-bordered"" id=""domainTable"">
                <thead>
                    <tr>
                        <th>User Name</th>
                        <th>Roles</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>

");
            EndContext();
#line 131 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                     foreach (ApplicationUser u in ViewBag.Users)
                    {

                        //var roleIds = u.Roles.Select(ur => ur.RoleId).ToList();
                        //var t = u.Roles;
                        var roleIds = ((List<ApplicationRole>)ViewBag.Roles).Select(ur => ur.Id).ToList();
                        var t = (List<ApplicationRole>)ViewBag.Roles;

#line default
#line hidden
            BeginContext(5102, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(5164, 10, false);
#line 139 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                           Write(u.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(5174, 39, true);
            WriteLiteral("</td>\n                            <td>\n");
            EndContext();
#line 141 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                 foreach (var r in ViewBag.Roles)
                                {
                                    var check = roleIds.Contains(r.Id) ? "checked" : "";

#line default
#line hidden
            BeginContext(5402, 91, true);
            WriteLiteral("                                    <label>\n                                        <input ");
            EndContext();
            BeginContext(5494, 5, false);
#line 145 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                          Write(check);

#line default
#line hidden
            EndContext();
            BeginContext(5499, 84, true);
            WriteLiteral(" type=\"checkbox\" name=\"Roles\"\n                                               value=\"");
            EndContext();
            BeginContext(5584, 6, false);
#line 146 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                                 Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5590, 15, true);
            WriteLiteral("\" data-userid=\"");
            EndContext();
            BeginContext(5606, 10, false);
#line 146 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                                                       Write(u.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(5616, 45, true);
            WriteLiteral("\" />\n                                        ");
            EndContext();
            BeginContext(5662, 6, false);
#line 147 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                   Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5668, 46, true);
            WriteLiteral("\n                                    </label>\n");
            EndContext();
#line 149 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5748, 67, true);
            WriteLiteral("                            </td>\n                            <td>\n");
            EndContext();
            BeginContext(5941, 83, true);
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-sm btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6024, "\"", 6138, 7);
            WriteAttributeValue("", 6034, "form.action", 6034, 11, true);
            WriteAttributeValue(" ", 6045, "=", 6046, 2, true);
            WriteAttributeValue(" ", 6047, "\'", 6048, 2, true);
#line 153 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
WriteAttributeValue("", 6049, Url.RouteUrl(new {controller="/",area="" }), 6049, 44, false);

#line default
#line hidden
            WriteAttributeValue("", 6093, "Admin/Master/RemoveUser?UserName=", 6093, 33, true);
#line 153 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
WriteAttributeValue("", 6126, u.UserName, 6126, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 6137, "\'", 6137, 1, true);
            EndWriteAttribute();
            BeginContext(6139, 74, true);
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#confirmDelete\" data-title=\"Delete item ");
            EndContext();
            BeginContext(6214, 10, false);
#line 153 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                                                                                                                                                                                                                                                           Write(u.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(6224, 57, true);
            WriteLiteral("\" data-message=\"Are you sure you want to delete selected ");
            EndContext();
            BeginContext(6282, 10, false);
#line 153 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                               Write(u.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(6292, 86, true);
            WriteLiteral(" ?\"><i class=\"fa fa-trash\"></i> Delete User</button>\n\n                                ");
            EndContext();
            BeginContext(6378, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "848ffbe4c61f45719d8c4d8deea1a4c3", async() => {
                BeginContext(6446, 14, true);
                WriteLiteral("Reset Password");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6410, "~/Admin/Master/ResetPassword/", 6410, 29, true);
#line 155 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
AddHtmlAttributeValue("", 6439, u.Id, 6439, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6464, 65, true);
            WriteLiteral("\n                            </td>\n                        </tr>\n");
            EndContext();
#line 158 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(6551, 47, true);
            WriteLiteral("                </tbody>\n\n            </table>\n");
            EndContext();
#line 162 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(6608, 24, true);
            WriteLiteral("    </fieldset>\n</div>\n\n");
            EndContext();
            BeginContext(6635, 38, false);
#line 166 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
Write(await Html.PartialAsync("_ModelPopup"));

#line default
#line hidden
            EndContext();
#line 166 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Areas\Admin\Views\Master\Index.cshtml"
                                         ; 

#line default
#line hidden
            BeginContext(6677, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6696, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(6701, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cae35b3d145b4786a930eecf0ca24f35", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6751, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(6756, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae435403b35242279ccac205b4f18e5a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6803, 4552, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $("":checkbox[name=Roles]"").click(function () {
                var roleName = $(this).val();
                var status = $(this).prop(""checked"");
                var userName = $(this).attr(""data-userid"");
                $.ajax({
                    url: ""/Admin/Master/UpdateRole"",
                    data: { Name: roleName, Status: status, UserName: userName },
                    success: function (response) {
                        //  alert(response);
                        alert(response);
                        console.log(response);
                    }
                });
            });
        });
    </script>




    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#form-user').bootstrapValidator({
                //live: 'disabled',
                message: 'This value is not valid',
                feedbackIcons: {
                    valid: 'glyphicon glyphicon-ok',
             ");
                WriteLiteral(@"       invalid: 'glyphicon glyphicon-remove',
                    validating: 'glyphicon glyphicon-refresh'
                },

                fields: {

                    Email: {

                        validators: {
                            notEmpty: {
                                message: 'The Email is required and cannot be empty'
                            },

                            emailAddress: {
                                message: 'The Email is is not valid'
                            },
                            remote: {
                                type: 'GET',
                                url: '/Validating/IsUserExists',
                                data: { type: 'Email' },
                                //data: function (validator) {
                                //    return {
                                //        'NewRoleName': validator.getFieldElements('NewRoleName').val()
                                //    };
                                //},
  ");
                WriteLiteral(@"                              message: 'The Email is already in use'
                            },
                        }
                    },
                    Password: {
                        validators: {

                            notEmpty: {
                                message: 'The Password is required and cannot be empty'
                            },
                            stringLength: {
                                min: 6,
                                max: 30,
                                message: 'The Password must be more than 6 and less than 30 characters long'
                            }
                        }

                    },

                    Fullname: {
                        validators: {

                            notEmpty: {
                                message: 'The fullname is required and cannot be empty'
                            },

                        }

                    },




                }
            });
        });");
                WriteLiteral(@"



    </script>








    <script type=""text/javascript"">
        $(document).ready(function () {



            $('#form-role').bootstrapValidator({
                //live: 'disabled',
                message: 'This value is not valid',
                feedbackIcons: {
                    valid: 'glyphicon glyphicon-ok',
                    invalid: 'glyphicon glyphicon-remove',
                    validating: 'glyphicon glyphicon-refresh'
                },

                fields: {

                    NewRoleName: {

                        validators: {
                            notEmpty: {
                                message: 'The Role Name is required and cannot be empty'
                            },

                            remote: {
                                type: 'GET',
                                url: '/Validating/IsRoleExists',
                                data: { type: 'NewRoleName' },
                                //data: function (validator) {
                   ");
                WriteLiteral(@"             //    return {
                                //        'NewRoleName': validator.getFieldElements('NewRoleName').val()
                                //    };
                                //},
                                message: 'The Role Name is already in use'
                            },
                        }
                    },


                }





            });


        });



    </script>


















");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
