#pragma checksum "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\MainIndustry\AddMainIndustry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f240420f188b75513b7142f7b7fa9201f0efede4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MainIndustry_AddMainIndustry), @"mvc.1.0.view", @"/Areas/Admin/Views/MainIndustry/AddMainIndustry.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f240420f188b75513b7142f7b7fa9201f0efede4", @"/Areas/Admin/Views/MainIndustry/AddMainIndustry.cshtml")]
    public class Areas_Admin_Views_MainIndustry_AddMainIndustry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\MainIndustry\AddMainIndustry.cshtml"
  
    ViewData["Title"] = "AddMainIndustry";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""pd-20 card-box mb-30"">
    <div class=""clearfix"">
        <div class=""pull-left"">
            <h4 class=""text-blue h4"">Endüstri Ekle</h4>
            <p class=""mb-30"">Eklenecek Bilgileri Giriniz.</p>
        </div>
    </div>
    <form>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Dil</label>
            <div class=""col-sm-12 col-md-10"">
                <select class=""custom-select col-12"">
                    <option");
            BeginWriteAttribute("selected", " selected=\"", 617, "\"", 628, 0);
            EndWriteAttribute();
            WriteLiteral(@">Seçiniz...</option>
                    <option value=""1"">Türkçe</option>
                    <option value=""2"">İngilizce</option>
                </select>
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Kategori</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text"" placeholder=""Kategori Giriniz..."">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Title</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text"" placeholder=""Title Giriniz..."">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Content</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text"" placeholder=""Content Giriniz.");
            WriteLiteral(@".."">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Resim/Video URL</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text"" placeholder=""URL Giriniz..."">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Resim/Video Açıklama</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text"" placeholder=""Açıklama Giriniz..."">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Main Endüstri Aktif Durumu</label>
            <div class=""col-sm-12 col-md-10"">
                <select class=""custom-select col-12"">
                    <option");
            BeginWriteAttribute("selected", " selected=\"", 2557, "\"", 2568, 0);
            EndWriteAttribute();
            WriteLiteral(@">Seçiniz...</option>
                    <option value=""1"">Aktif</option>
                    <option value=""2"">Pasif</option>
                </select>
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Main Uygulama Aktif Durumu</label>
            <div class=""col-sm-12 col-md-10"">
                <select class=""custom-select col-12"">
                    <option");
            BeginWriteAttribute("selected", " selected=\"", 3026, "\"", 3037, 0);
            EndWriteAttribute();
            WriteLiteral(@">Seçiniz...</option>
                    <option value=""1"">Aktif</option>
                    <option value=""2"">Pasif</option>
                </select>
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Aktif Durumu</label>
            <div class=""col-sm-12 col-md-10"">
                <select class=""custom-select col-12"">
                    <option");
            BeginWriteAttribute("selected", " selected=\"", 3481, "\"", 3492, 0);
            EndWriteAttribute();
            WriteLiteral(@">Seçiniz...</option>
                    <option value=""1"">Aktif</option>
                    <option value=""2"">Pasif</option>
                </select>
            </div>
        </div>
        <div>
            <button type=""button"" class=""btn btn-primary btn-lg"">Ekle</button>
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
