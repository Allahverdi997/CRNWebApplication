#pragma checksum "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\Menu\UpdateMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edc34704fd6d093d356dcd719a886a34f069b0b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Menu_UpdateMenu), @"mvc.1.0.view", @"/Areas/Admin/Views/Menu/UpdateMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc34704fd6d093d356dcd719a886a34f069b0b8", @"/Areas/Admin/Views/Menu/UpdateMenu.cshtml")]
    public class Areas_Admin_Views_Menu_UpdateMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\Menu\UpdateMenu.cshtml"
  
    ViewData["Title"] = "UpdateMenu";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""pd-20 card-box mb-30"">
    <div class=""clearfix"">
        <div class=""pull-left"">
            <h4 class=""text-blue h4"">Hakkında Güncelle</h4>
            <p class=""mb-30"">Güncellenecek Bilgileri Giriniz.</p>
        </div>
    </div>
    <form>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Dil</label>
            <div class=""col-sm-12 col-md-10"">
                <select class=""custom-select col-12"">
                    <option");
            BeginWriteAttribute("selected", " selected=\"", 620, "\"", 631, 0);
            EndWriteAttribute();
            WriteLiteral(@">Seçiniz...</option>
                    <option value=""1"">Türkçe</option>
                    <option value=""2"">İngilizce</option>
                </select>
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Title</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text"" placeholder=""Title Giriniz..."">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Not</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text"" placeholder=""Not Giriniz..."">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">URL</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text"" placeholder=""URL Giriniz..."">
            ");
            WriteLiteral(@"</div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Aktif Durumu</label>
            <div class=""col-sm-12 col-md-10"">
                <select class=""custom-select col-12"">
                    <option");
            BeginWriteAttribute("selected", " selected=\"", 1930, "\"", 1941, 0);
            EndWriteAttribute();
            WriteLiteral(@">Seçiniz...</option>
                    <option value=""1"">Aktif</option>
                    <option value=""2"">Pasif</option>
                </select>
            </div>
        </div>
        <div>
            <button type=""button"" class=""btn btn-primary btn-lg"">Güncelle</button>
        </div>
    </form>
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
