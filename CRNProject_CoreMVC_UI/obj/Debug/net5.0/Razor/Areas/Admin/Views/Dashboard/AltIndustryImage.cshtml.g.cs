#pragma checksum "C:\Users\kadirari\Desktop\Freelance\CRNProject\CRNProject_CoreMVC_UI\Areas\Admin\Views\Dashboard\AltIndustryImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "123a6b7823cbcb4d1e7684ae5235223e6ed46916"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_AltIndustryImage), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/AltIndustryImage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"123a6b7823cbcb4d1e7684ae5235223e6ed46916", @"/Areas/Admin/Views/Dashboard/AltIndustryImage.cshtml")]
    public class Areas_Admin_Views_Dashboard_AltIndustryImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kadirari\Desktop\Freelance\CRNProject\CRNProject_CoreMVC_UI\Areas\Admin\Views\Dashboard\AltIndustryImage.cshtml"
  
    ViewData["Title"] = "AltIndustryImage";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-box mb-30"">
    <h2 class=""h4 pd-20"">Alt Endüstri Resim Detayları</h2>
    <table class=""data-table table nowrap"">
        <thead>
            <tr>
                <th>Alt Endüstri Adı</th>
                <th>Resim Video Alt</th>
                <th>Resim Video URL</th>
                <th>Aktif Durumu</th>
                <th class=""datatable-nosort"">İşlemler</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>AltEndüstriBilgisi</td>
                <td>ResimVideoALT</td>
                <td class=""table-plus"">
                    <img src=""/Context/Admin/vendors/images/product-1.jpg"" width=""70"" height=""70""");
            BeginWriteAttribute("alt", " alt=\"", 811, "\"", 817, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </td>
                <td><span class=""badge badge-danger"">Pasif</span></td>
                <td>
                    <div class=""dropdown"">
                        <a class=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
                            <i class=""dw dw-more""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-edit2""></i> Düzenle</a>
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-delete-3""></i> Sil</a>
                        </div>
                    </div>
                </td>
            </tr>
            <tr>
                <td>AltEndüstriBilgisi</td>
                <td>ResimVideoALT</td>
                <td class=""table-plus"">
                    <img src=""/Context/Admin/vendors/images/product-1.jpg"" widt");
            WriteLiteral("h=\"70\" height=\"70\"");
            BeginWriteAttribute("alt", " alt=\"", 1860, "\"", 1866, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </td>
                <td><span class=""badge badge-primary"">Aktif</span></td>
                <td>
                    <div class=""dropdown"">
                        <a class=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
                            <i class=""dw dw-more""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-edit2""></i> Düzenle</a>
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-delete-3""></i> Sil</a>
                        </div>
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
</div>

");
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