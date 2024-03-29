#pragma checksum "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83dd80b2ce69a7a27c5f05c2488c19661c1b221e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83dd80b2ce69a7a27c5f05c2488c19661c1b221e", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
    public class Areas_Admin_Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83dd80b2ce69a7a27c5f05c2488c19661c1b221e2856", async() => {
                WriteLiteral(@"
    <!-- Basic Page Info -->
    <meta charset=""utf-8"">
    <title>Fibaro Akıllı Ev Sistemleri | Meka Software</title>

    <!-- Site favicon -->
    <link rel=""apple-touch-icon"" sizes=""180x180"" href=""/Context/mekasoftware/NewLogo.png"">
    <link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""/Context/mekasoftware/32x32-M.png"">
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""/Context/mekasoftware/16x16-M.PNG"">

    <!-- Mobile Specific Metas -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">

    <!-- Google Font -->
    <link href=""https://fonts.googleapis.com/css2?family=Inter:wght@300;400;500;600;700;800&display=swap"" rel=""stylesheet"">
    <!-- CSS -->
    <link rel=""stylesheet"" type=""text/css"" href=""/Context/Admin/vendors/styles/core.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/Context/Admin/vendors/styles/icon-font.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/Context/Admin/src/plugins/jvectormap/jquery-jvec");
                WriteLiteral(@"tormap-2.0.3.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/Context/Admin/vendors/styles/style.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/Context/Admin/src/plugins/dropzone/src/dropzone.css"">


    <!-- Global site tag (gtag.js) - Google Analytics -->
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'UA-119386393-1');
    </script>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83dd80b2ce69a7a27c5f05c2488c19661c1b221e5436", async() => {
                WriteLiteral("\r\n    <div class=\"pre-loader\">\r\n        <div class=\"pre-loader-box\">\r\n            <div class=\"loader-logo\"><img src=\"/Context/mekasoftware/MiniLogo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1717, "\"", 1723, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
            <div class='loader-progress' id=""progress_div"">
                <div class='bar' id='bar1'></div>
            </div>
            <div class='percent' id='percent1'>0%</div>
            <div class=""loading-text"">
                Yükleniyor...
            </div>
        </div>
    </div>

    <div class=""header"">
        <div class=""header-left"">
            <div class=""menu-icon dw dw-menu""></div>

        </div>
        <div class=""header-right"">

            <div class=""user-info-dropdown"">
                <div class=""dropdown"">
                    <a class=""dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
                        <span class=""user-icon"">
                            <img src=""/Context/mekasoftware/180x180-M.png""");
                BeginWriteAttribute("alt", " alt=\"", 2519, "\"", 2525, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </span>
                        <span class=""user-name"">Meka Software</span>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">
                        <a class=""dropdown-item"" href=""login.html""><i class=""dw dw-logout""></i> Çıkış Yap</a>
                    </div>
                </div>
            </div>

        </div>
    </div>


    <div class=""left-side-bar"">
        <div class=""brand-logo"">
            <a href=""Index"">
");
                WriteLiteral("                <img src=\"/Context/mekasoftware/NewLogo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3230, "\"", 3236, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""light-logo"">
            </a>
            <div class=""close-sidebar"" data-toggle=""left-sidebar-close"">
                <i class=""ion-close-round""></i>
            </div>
        </div>
        <div class=""menu-block customscroll"">
            <div class=""sidebar-menu"">
                <ul id=""accordion-menu"">
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-house-1""></span><span class=""mtext"">Anasayfa</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/Index"">Admin Sayfasına Git</a></li>
                            <li><a href=""/Home/Index"">Kullanıcı Sayfasına Git</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""");
                WriteLiteral(@"micon dw dw-edit2""></span><span class=""mtext"">Slider</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/Slider"">Slider Listele</a></li>
                            <li><a href=""/Admin/Slider/AddSlider"">Slider Ekle</a></li>
                            <li><a href=""/Admin/Slider/UpdateSlider"">Slider Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Hakkında</span>
                        </a>
                        <ul class=""submenu"">
                            <li> <a href=""/Admin/Dashboard/AboutIndex"">Hakkında Listele</a></li>
                            <li> <a href=""/Admin/About/AddAbout"">Hakkında Ekle</a></li>
                            <li> <a href=""/Admin/About/UpdateAbout"">Hakk");
                WriteLiteral(@"ında Güncelle</a></li>

                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Menü</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/Menu"">Menü Listele</a></li>
                            <li><a href=""/Admin/Menu/AddMenu"">Menü Ekle</a></li>
                            <li><a href=""/Admin/Menu/UpdateMenu"">Menü Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Kategori</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a h");
                WriteLiteral(@"ref=""/Admin/Dashboard/Category"">Kategori Listele</a></li>
                            <li><a href=""/Admin/Category/AddCategory"">Kategori Ekle</a></li>
                            <li><a href=""/Admin/Category/UpdateCategory"">Kategori Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Ürün</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/MainProduct"">Ürün Listele</a></li>
                            <li><a href=""/Admin/MainProduct/AddMainProduct"">Ürün Ekle</a></li>
                            <li><a href=""/Admin/MainProduct/UpdateMainProduct"">Ürün Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a");
                WriteLiteral(@" href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Alt Ürün</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/AltProduct"">Alt Ürün Listele</a></li>
                            <li><a href=""/Admin/AltProduct/AddAltProduct"">Alt Ürün Ekle</a></li>
                            <li><a href=""/Admin/AltProduct/UpdateAltProduct"">Alt Ürün Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Alt Ürün Resmi</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/AltProductImage"">Alt Ürün Listele</a></li>
                            <li><a ");
                WriteLiteral(@"href=""/Admin/AltProductImage/AddAltProductImage"">Alt Ürün Ekle</a></li>
                            <li><a href=""/Admin/AltProductImage/UpdateAltProductImage"">Alt Ürün Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Alt Ürün Dosya</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/AltProductFile"">Alt Ürün Dosya Listele</a></li>
                            <li><a href=""/Admin/AltProductFile/AddAltProductFile"">Alt Ürün Dosya Ekle</a></li>
                            <li><a href=""/Admin/AltProductFile/UpdateAltProductFile"">Alt Ürün Dosya Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""java");
                WriteLiteral(@"script:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Endüstri</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/MainIndustry"">Endüstri Listele</a></li>
                            <li><a href=""/Admin/MainIndustry/AddMainIndustry"">Endüstri Ekle</a></li>
                            <li><a href=""/Admin/MainIndustry/UpdateMainIndustry"">Endüstri Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Alt Endüstri</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/AltIndustry"">Alt Endüstri Listele</a></li>
                            <li><a hre");
                WriteLiteral(@"f=""/Admin/AltIndustry/AddAltIndustry"">Alt Endüstri Ekle</a></li>
                            <li><a href=""/Admin/AltIndustry/UpdateAltIndustry"">Alt Endüstri Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Alt Endüstri Resmi</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/AltIndustryImage"">Alt Endüstri Listele</a></li>
                            <li><a href=""/Admin/AltIndustryImage/AddAltIndustryImage"">Alt Endüstri Ekle</a></li>
                            <li><a href=""/Admin/AltIndustryImage/UpdateAltIndustryImage"">Alt Endüstri Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascr");
                WriteLiteral(@"ipt:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Alt Endüstri Dosya</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/AltIndustryFile"">Alt Endüstri Dosya Listele</a></li>
                            <li><a href=""/Admin/AltIndustryFile/AddAltIndustryFile"">Alt Endüstri Dosya Ekle</a></li>
                            <li><a href=""/Admin/AltIndustryFile/UpdateAltIndustryFile"">Alt Endüstri Dosya Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">İletişim Detay</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/Contact"">İletişim Bilgileri ");
                WriteLiteral(@"Listele</a></li>
                            <li><a href=""/Admin/Contact/AddContact"">İletişim Bilgisi Ekle</a></li>
                            <li><a href=""/Admin/Contact/UpdateContact"">İletişim Bilgisi Güncelle</a></li>


                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Mail Detay</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/ContactMailDetails"">Mail Detay Listele</a></li>
                            <li><a href=""/Admin/ContactMailDetails/AddContactMailDetails"">Mail Detay Ekle</a></li>
                            <li><a href=""/Admin/ContactMailDetails/UpdateContactMailDetails"">Mail Detay Güncelle</a></li>

                        </ul>
                    </li>
                    <li class=""dr");
                WriteLiteral(@"opdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Sosyal Medya</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/SocialMediaDetails"">Sosyal Medya Listele</a></li>
                            <li><a href=""/Admin/SocialMediaDetails/AddSocialMediaDetails"">Sosyal Medya Ekle</a></li>
                            <li><a href=""/Admin/SocialMediaDetails/UpdateSocialMediaDetails"">Sosyal Medya Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Güvenlik Sözleşmesi</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=");
                WriteLiteral(@"""/Admin/Dashboard/SecurityPoliticy"">Güvenlik Sözleşmesi Listele</a></li>
                            <li><a href=""/Admin/SecurityPoliticy/AddSecurityPoliticy"">Güvenlik Sözleşmesi Ekle</a></li>
                            <li><a href=""/Admin/SecurityPoliticy/UpdateSecurityPoliticy"">Güvenlik Sözleşmesi Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Şirket Sözleşmesi</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""//Admin/Dashboard/CompanyPoliticy"">Şirket Sözleşmesi Listele</a></li>
                            <li><a href=""/Admin/CompanyPoliticy/AddCompanyPoliticy"">Şirket Sözleşmesi Ekle</a></li>
                            <li><a href=""/Admin/CompanyPoliticy/UpdateCompanyPoliticy"">Şirket Sözleşmesi Günc");
                WriteLiteral(@"elle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Çerez Sözleşmesi</span>
                        </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/CookiesPoliticy"">Çerez Sözleşmesi Listele</a></li>
                            <li><a href=""/Admin/CookiesPoliticy/AddCookiesPoliticy"">Çerez Sözleşmesi Ekle</a></li>
                            <li><a href=""/Admin/CookiesPoliticy/UpdateCookiesPoliticy"">Çerez Sözleşmesi Güncelle</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:;"" class=""dropdown-toggle"">
                            <span class=""micon dw dw-edit2""></span><span class=""mtext"">Sabit Değer</span>
                 ");
                WriteLiteral(@"       </a>
                        <ul class=""submenu"">
                            <li><a href=""/Admin/Dashboard/ConstantValue"">Sabit Değerler Listele</a></li>
                            <li><a href=""/Admin/ConstantValue/AddConstantValue"">Sabit Değer Ekle</a></li>
                            <li><a href=""/Admin/ConstantValue/UpdateConstantValue"">Sabit Değer Güncelle</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <div class=""mobile-menu-overlay""></div>

    <div class=""main-container"">
        ");
#nullable restore
#line 297 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
    <!-- js -->
    <script src=""/Context/Admin/src/plugins/dropzone/src/dropzone.js""></script>
    <script src=""/Context/Admin/src/plugins/dropzone/src/dropzone.js""></script>
    <script src=""/Context/Admin/vendors/scripts/core.js""></script>
    <script src=""/Context/Admin/vendors/scripts/script.min.js""></script>
    <script src=""/Context/Admin/vendors/scripts/process.js""></script>
    <script src=""/Context/Admin/vendors/scripts/layout-settings.js""></script>
    <script src=""/Context/Admin/src/plugins/jQuery-Knob-master/jquery.knob.min.js""></script>
    <script src=""/Context/Admin/src/plugins/jvectormap/jquery-jvectormap-2.0.3.min.js""></script>
    <script src=""/Context/Admin/src/plugins/jvectormap/jquery-jvectormap-world-mill-en.js""></script>
    <script src=""/Context/Admin/vendors/scripts/dashboard2.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
