#pragma checksum "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71311211063f7aecee1638b21a14e51edbdf6192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__OrderDetail), @"mvc.1.0.view", @"/Views/Shared/Partials/_OrderDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partials/_OrderDetail.cshtml", typeof(AspNetCore.Views_Shared_Partials__OrderDetail))]
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
#line 1 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 8 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.IdentityModels;

#line default
#line hidden
#line 2 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
using WebApplication8.Models.ShoppingCart;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71311211063f7aecee1638b21a14e51edbdf6192", @"/Views/Shared/Partials/_OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0a3fafe41e76a33d850d2ac657d18b4d78f4541", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication8.Models.WebShop.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(103, 250, true);
            WriteLiteral("\n    <table class=\"table table-striped\">\n        <tr>\n            <th>Id</th>\n            <th>Name</th>\n            <th>Unit Price</th>\n            <th>Discount</th>\n            <th>Quantity</th>\n            <th>Amount</th>\n           \n        </tr>\n");
            EndContext();
#line 14 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
            BeginContext(397, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(435, 4, false);
#line 17 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
               Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(439, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(466, 6, false);
#line 18 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
               Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(472, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(499, 35, false);
#line 19 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
               Write(Html.FormatValue(p.PriceP, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(534, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(561, 37, false);
#line 20 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
               Write(Html.FormatValue(p.Discount, "{0:p}"));

#line default
#line hidden
            EndContext();
            BeginContext(598, 49, true);
            WriteLiteral("</td>\n                <td><input class=\"quantity\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 647, "\"", 666, 1);
#line 21 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
WriteAttributeValue("", 655, p.Quantity, 655, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(667, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(678, 4, false);
#line 21 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
                                                                    Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(682, 10, true);
            WriteLiteral("\" size=\"3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 692, "\"", 705, 2);
#line 21 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
WriteAttributeValue("", 697, p.Id, 697, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 702, "-ss", 702, 3, true);
            EndWriteAttribute();
            BeginContext(706, 28, true);
            WriteLiteral(" /></td>\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 734, "\"", 744, 1);
#line 22 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
WriteAttributeValue("", 739, p.Id, 739, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(745, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(747, 67, false);
#line 22 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
                          Write(Html.FormatValue(p.PriceP * p.Quantity * (1 - p.Discount), "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(814, 41, true);
            WriteLiteral("</td>\n                \n            </tr>\n");
            EndContext();
#line 25 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
        }

#line default
#line hidden
            BeginContext(865, 116, true);
            WriteLiteral("        <tr>\n            <th colspan=\"5\" style=\"text-align:right\">Total:</th>\n            <th class=\"nn-cart-total\">");
            EndContext();
            BeginContext(982, 45, false);
#line 28 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Partials\_OrderDetail.cshtml"
                                 Write(Html.FormatValue(ShoppingCart.Total, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 52, true);
            WriteLiteral("</th>\n            \n        </tr>\n    </table>\n   \n\n\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CustomerIdentity CustomerIdentity { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Global { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication8.Models.WebShop.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591