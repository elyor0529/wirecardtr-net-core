#pragma checksum "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf5db369f62129b7142de82f9165aea193f2df50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples;

#line default
#line hidden
#line 2 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf5db369f62129b7142de82f9165aea193f2df50", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/css/jquery.mCustomScrollbar.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/favicon.ico"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("130"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("26"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/js/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/js/jquery.mCustomScrollbar.concat.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 505, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2e174f456594b0885b801aa876b2cfe", async() => {
                BeginContext(31, 119, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
                EndContext();
                BeginContext(151, 13, false);
#line 6 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(164, 42, true);
                WriteLiteral(" - WireCard Developer Portal</title>\r\n    ");
                EndContext();
                BeginContext(206, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2cd818d1c2f0442d9f80fd572462728e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(269, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(275, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52e0cd6c454d4d3086a5a9c3b06c3dc7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(352, 35, true);
                WriteLiteral("\r\n    <!-- Our Custom CSS -->\r\n    ");
                EndContext();
                BeginContext(387, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08eadea26abc415e868791add2fc6dd9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(442, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(448, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e67343ba5b2a4011a39c5983f73132a9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(486, 37, true);
                WriteLiteral("\r\n    <!-- Scrollbar Custom CSS -->\r\n");
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
            BeginContext(530, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(532, 5828, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39aa3bb4549b4653b6bfe507bc6d0636", async() => {
                BeginContext(538, 127, true);
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n        <nav id=\"sidebar\">\r\n            <div class=\"sidebar-header\">\r\n                <a href=\"/\">");
                EndContext();
                BeginContext(665, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f003f92e60a9407c888d144c34545d53", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(724, 335, true);
                WriteLiteral(@"</a>
                
            </div>
            <ul class=""list-unstyled components"">
                <li>
                    <a href=""#homeSubmenu"" data-toggle=""collapse"" aria-expanded=""false"">Sms Ödeme Servisleri</a>
                    <ul class=""collapse list-unstyled"" id=""homeSubmenu"">
                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1059, "\"", 1096, 1);
#line 25 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1066, Url.Action("BasicApi","Home"), 1066, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1097, 52, true);
                WriteLiteral(">Basic Api </a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1149, "\"", 1184, 1);
#line 26 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1156, Url.Action("ProApi","Home"), 1156, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1185, 49, true);
                WriteLiteral(">Pro Api</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1234, "\"", 1270, 1);
#line 27 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1241, Url.Action("ApiPlus","Home"), 1241, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1271, 50, true);
                WriteLiteral(">Api Plus</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1321, "\"", 1375, 1);
#line 28 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1328, Url.Action("SendInformationSmsService","Home"), 1328, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1376, 327, true);
                WriteLiteral(@">Bilgi Sms Gönderim Servisi</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#pageSubmenu"" data-toggle=""collapse"" aria-expanded=""false"">Abonelik Servisleri</a>
                    <ul class=""collapse list-unstyled"" id=""pageSubmenu"">
                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1703, "\"", 1748, 1);
#line 34 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1710, Url.Action("SelectSubscriber","Home"), 1710, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1749, 60, true);
                WriteLiteral(">Abonelik Listeleme</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1809, "\"", 1860, 1);
#line 35 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1816, Url.Action("SelectSubscriberDetail","Home"), 1816, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1861, 56, true);
                WriteLiteral(">Abonelik Detay</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1917, "\"", 1966, 1);
#line 36 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1924, Url.Action("DeactivateSubscriber","Home"), 1924, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1967, 51, true);
                WriteLiteral(">Abone Sil</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2018, "\"", 2070, 1);
#line 37 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2025, Url.Action("ChangePriceBySubScriber","Home"), 2025, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2071, 319, true);
                WriteLiteral(@">Abonelik ücret değişimi </a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#pageSubmenu2"" data-toggle=""collapse"" aria-expanded=""false"">Ödeme Formu</a>
                    <ul class=""collapse list-unstyled"" id=""pageSubmenu2"">
                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2390, "\"", 2432, 1);
#line 43 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2397, Url.Action("CCProxySale3D","Home"), 2397, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2433, 61, true);
                WriteLiteral(">3D Secure İle Ödeme</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2494, "\"", 2534, 1);
#line 44 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2501, Url.Action("CCProxySale","Home"), 2501, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2535, 324, true);
                WriteLiteral(@">3D Secure Olmadan Ödeme</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#pageSubmenu3"" data-toggle=""collapse"" aria-expanded=""false"">Ortak Ödeme Formu</a>
                    <ul class=""collapse list-unstyled"" id=""pageSubmenu3"">
                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2859, "\"", 2910, 1);
#line 50 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2866, Url.Action("WDTicketSale3DURLProxy","Home"), 2866, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2911, 61, true);
                WriteLiteral(">3D Secure İle ödeme</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2972, "\"", 3021, 1);
#line 51 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2979, Url.Action("WDTicketSaleURLProxy","Home"), 2979, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3022, 324, true);
                WriteLiteral(@">3D Secure Olmadan Ödeme</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#pageSubmenu4"" data-toggle=""collapse"" aria-expanded=""false"">Mağaza Servisleri</a>
                    <ul class=""collapse list-unstyled"" id=""pageSubmenu4"">
                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3346, "\"", 3399, 1);
#line 57 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3353, Url.Action("MarketPlaceAddSubPartner","Home"), 3353, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3400, 56, true);
                WriteLiteral(">Mağaza Oluştur</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3456, "\"", 3512, 1);
#line 58 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3463, Url.Action("MarketPlaceUpdateSubPartner","Home"), 3463, 49, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3513, 57, true);
                WriteLiteral(">Mağaza Güncelle</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3570, "\"", 3628, 1);
#line 59 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3577, Url.Action("MarketPlaceDeactiveSubPartner","Home"), 3577, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3629, 52, true);
                WriteLiteral(">Mağaza Sil</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3681, "\"", 3730, 1);
#line 60 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3688, Url.Action("MarketPlaceSale3DSec","Home"), 3688, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3731, 62, true);
                WriteLiteral(">3D Secure ile Ödeme </a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3793, "\"", 3839, 1);
#line 61 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3800, Url.Action("MarketPlaceMPSale","Home"), 3800, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3840, 66, true);
                WriteLiteral(">3D Secure olmadan Ödeme </a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3906, "\"", 3972, 1);
#line 62 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3913, Url.Action("MarketPlaceWDTicketMpSale3dSecWithUrl","Home"), 3913, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3973, 71, true);
                WriteLiteral(">Wirecard Ortak Ödeme Sayfası </a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4044, "\"", 4098, 1);
#line 63 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4051, Url.Action("MarketPlaceReleasePayment","Home"), 4051, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4099, 315, true);
                WriteLiteral(@">Ödeme Onay Servisi </a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#pageSubmenu6"" data-toggle=""collapse"" aria-expanded=""false"">Kart Saklama</a>
                    <ul class=""collapse list-unstyled"" id=""pageSubmenu6"">
                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4414, "\"", 4456, 1);
#line 69 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4421, Url.Action("TokenizeCCURL","Home"), 4421, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4457, 70, true);
                WriteLiteral(">Url Yöntemi ile kart saklama</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4527, "\"", 4566, 1);
#line 70 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4534, Url.Action("TokenizeCC","Home"), 4534, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4567, 340, true);
                WriteLiteral(@">Direk Kart Sakla</a></li>
                       
                    </ul>
                </li>
                <li>
                    <a href=""#pageSubmenu5"" data-toggle=""collapse"" aria-expanded=""false"">İşlem Sorgulama</a>
                    <ul class=""collapse list-unstyled"" id=""pageSubmenu5"">
                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4907, "\"", 4961, 1);
#line 77 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4914, Url.Action("TransactionQueryByOrderId","Home"), 4914, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4962, 78, true);
                WriteLiteral(">Sipariş Numarası ile İşlem Sorgulama</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5040, "\"", 5091, 1);
#line 78 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5047, Url.Action("TransactionQueryByMPAY","Home"), 5047, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5092, 594, true);
                WriteLiteral(@">MPAY ile İşlem Sorgulama</a></li>
                    </ul>
                </li>
            </ul>  
        </nav>
        <div id=""content"">
            <nav class=""navbar navbar-default"">
                <div class=""container-fluid"">

                    <div class=""navbar-header"">
                        <button type=""button"" id=""sidebarCollapse"" class=""btn btn-info navbar-btn"">
                            <i class=""glyphicon glyphicon-align-left""></i>
                        </button>
                    </div>
                </div>
            </nav>
            ");
                EndContext();
                BeginContext(5687, 12, false);
#line 94 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5699, 54, true);
                WriteLiteral("\r\n          \r\n        </div>        \r\n    </div>\r\n    ");
                EndContext();
                BeginContext(5753, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d55d8d7801a4e67a97cca77a0d39cc2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5809, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5815, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0137bf7899c4f75a1ba7de4b7c6f555", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5867, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5873, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6722284f6cb74c86930338564e332c66", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5946, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5953, 43, false);
#line 101 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
Write(RenderSection("Plugins", false/*required*/));

#line default
#line hidden
                EndContext();
                BeginContext(5996, 46, true);
                WriteLiteral("\r\n    <!--End Begin Page Level Plugin-->\r\n    ");
                EndContext();
                BeginContext(6043, 43, false);
#line 103 "D:\wirecardgithub\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", false/*required*/));

#line default
#line hidden
                EndContext();
                BeginContext(6086, 267, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
             $(document).ready(function () {
                 $('#sidebarCollapse').on('click', function () {
                     $('#sidebar').toggleClass('active');
                 });
             });
    </script>

");
                EndContext();
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
            EndContext();
            BeginContext(6360, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
