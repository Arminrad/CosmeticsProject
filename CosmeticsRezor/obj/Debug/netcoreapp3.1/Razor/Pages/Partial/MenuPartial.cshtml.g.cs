#pragma checksum "D:\DocumentBootCamp\CosmeticsProject\Repository\CosmeticsRezor\Pages\Partial\MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fc67b933baad6df6049c2b4ad9c6d5411a98907"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CosmeticsRezor.Pages.Partial.Pages_Partial_MenuPartial), @"mvc.1.0.view", @"/Pages/Partial/MenuPartial.cshtml")]
namespace CosmeticsRezor.Pages.Partial
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DocumentBootCamp\CosmeticsProject\Repository\CosmeticsRezor\Pages\_ViewImports.cshtml"
using CosmeticsRezor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc67b933baad6df6049c2b4ad9c6d5411a98907", @"/Pages/Partial/MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4de08374ae9bfa478dd50159b94487cdebfc5ff", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Partial_MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/images/logo/RojaLogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("لوگو روژا"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/images/logo/User.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:-3px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DocumentBootCamp\CosmeticsProject\Repository\CosmeticsRezor\Pages\Partial\MenuPartial.cshtml"
  
    var CategoryOutput = new List<Cosmetics.Application.Services.Dto.Output.CategoryOutputDto>();
    CategoryOutput = icategoryService.GetAll().Result.ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header>

    <div id=""offcanvas-mobile-menu"" class=""offcanvas theme1 offcanvas-mobile-menu"">
        <div class=""inner"">
            <button class=""offcanvas-close"" dir=""rtl"">×</button>
            <nav class=""offcanvas-menu"" dir=""rtl"">
                <ul>
                    <li>
                        <a href=""#""><span class=""menu-text"">خانه</span></a>
                    </li>
                    <li>
                        <a href=""#""><span class=""menu-text"">دسته بندی محصولات</span></a>
                        <ul class=""offcanvas-submenu"">
                            <li class=""col-3"">
");
#nullable restore
#line 21 "D:\DocumentBootCamp\CosmeticsProject\Repository\CosmeticsRezor\Pages\Partial\MenuPartial.cshtml"
                                 foreach (var item in CategoryOutput)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"dropdown-item\" href=\"#\"><p class=\"tite-child-category\" style=\"font-size:18px\">");
#nullable restore
#line 23 "D:\DocumentBootCamp\CosmeticsProject\Repository\CosmeticsRezor\Pages\Partial\MenuPartial.cshtml"
                                                                                                                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></a>\r\n");
#nullable restore
#line 24 "D:\DocumentBootCamp\CosmeticsProject\Repository\CosmeticsRezor\Pages\Partial\MenuPartial.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                        <ul class=""offcanvas-submenu"">
                            <li>
                                <a href=""#""><span class=""menu-text""></span></a>
                                <ul class=""offcanvas-submenu"">
                                    <a href=""#""><span class=""menu-text""></span></a>
                                    <li>
                                        <a href=""shop-grid-3-column.html"" class=""text""></a>
                                    </li>
                                    <li>
                                        <a href=""shop-grid-4-column.html"" class=""text""> </a>
                                    </li>
                                    <li>
                                        <a href=""shop-grid-left-sidebar.html"" class=""text""></a>
                                    </li>
                                    <li>
                                        <a href=""shop-grid-left-sidebar.html"" class=""text""><");
            WriteLiteral(@"/a>
                                    </li>
                                    <li>
                                        <a href=""shop-grid-left-sidebar.html"" class=""text""></a>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                        <ul class=""offcanvas-submenu"">
                            <li>
                                <a href=""#""><span class=""menu-text""></span></a>
                                <ul class=""offcanvas-submenu"">
                                    <a href=""#""><span class=""menu-text""> </span></a>
                                    <li>
                                        <a href=""shop-grid-3-column.html"" class=""text""></a>
                                    </li>
                                    <li>
                                        <a href=""shop-grid-4-column.html"" class=""text""></a>
                                    </li>
            ");
            WriteLiteral(@"                        <li>
                                        <a href=""shop-grid-left-sidebar.html"" class=""text""> </a>
                                    </li>
                                    <li>
                                        <a href=""shop-grid-left-sidebar.html"" class=""text"">    </a>
                                    </li>
                                    <li>
                                        <a href=""shop-grid-left-sidebar.html"" class=""text""> </a>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                    <li><a class=""menu-text1"" href=""contact.html"">درباره فروشگاه</a></li>
                    <li><a class=""menu-text1"" href=""contact.html"">تماس با ما</a></li>
                </ul>
            </nav>
            <div class=""social-network text-center"" style=""font-size:30px;"">
                <a href=""#"">
                    <i ");
            WriteLiteral(@"class=""fab fa-twitter-square"">
                    </i>
                </a>
                <a href=""#"">
                    <i class=""fab fa-instagram"">
                    </i>
                </a>
                <a href=""#"">
                    <i class=""fab fa-facebook-square"">
                    </i>
                </a>
                <a href=""#"">
                    <i class=""fab fa-youtube-square"">
                    </i>
                </a>
            </div>
        </div>
    </div>
    <div id=""home"" class=""header-middle"">
        <div class=""container position-relative "">
            <div class=""row align-items-center"">
                <div class=""col-6 col-lg-2 col-xl-2"">
                    <div class=""logo"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fc67b933baad6df6049c2b4ad9c6d5411a9890710584", async() => {
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
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-xl-8 col-lg-7 d-none d-lg-block  "">
                    <ul class=""main-menu d-flex"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""#"" style=""text-decoration: none;font-size:18px;color: rgb(32, 156, 32);"">خانه</a>
                        </li>
                        <li class=""position-static"" dir=""rtl"">
                            <a href=""#"">دسته بندی محصولات<i class=""ion-ios-arrow-down""></i></a>
                            <ul class=""mega-menu row"" style=""width:800px"" ;>
                                <li class=""col-3"">
");
#nullable restore
#line 115 "D:\DocumentBootCamp\CosmeticsProject\Repository\CosmeticsRezor\Pages\Partial\MenuPartial.cshtml"
                                     foreach (var item in CategoryOutput)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"dropdown-item\" href=\"#\"><p class=\"tite-child-category\" style=\"font-size:18px\">");
#nullable restore
#line 117 "D:\DocumentBootCamp\CosmeticsProject\Repository\CosmeticsRezor\Pages\Partial\MenuPartial.cshtml"
                                                                                                                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></a>\r\n");
#nullable restore
#line 118 "D:\DocumentBootCamp\CosmeticsProject\Repository\CosmeticsRezor\Pages\Partial\MenuPartial.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </li>
                        
        
                            </ul>
                        </li>
                        <li>
                            <a class=""nav-link"" href=""#"" style=""text-decoration: none;"">درباره فروشگاه </a>
                        </li>
                        <li><a href=""#"">تماس  ما</a></li>
                    </ul>
                </div>
                <div class=""col-6 col-lg-3 col-xl-2"">
                    <div class=""d-flex align-items-center justify-content-end"">
                        <div class=""cart-block-links theme1 d-none d-sm-block"">
                            <ul class=""d-flex"">
                                <a class=""nav-link "" href=""#"" style=""color:rgb(175, 91, 91);text-decoration: none;font-size: 18px"">
                                    ورود و ثبت نام");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fc67b933baad6df6049c2b4ad9c6d5411a9890714381", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </ul>
                        </div>
                        <!--button for mobail-->
                        <div class=""mobile-menu-toggle theme1 d-lg-none"">
                            <a href=""#offcanvas-mobile-menu"" class=""offcanvas-toggle"">
                                <svg viewbox=""0 0 700 550"">
                                    <path d=""M300,220 C300,220 520,220 540,220 C740,220 640,540 520,420 C440,340 300,200 300,200""
                                          id=""top""></path>
                                    <path d=""M300,320 L540,320"" id=""middle""></path>
                                    <path d=""M300,210 C300,210 520,210 540,210 C740,210 640,530 520,410 C440,330 300,190 300,190""
                                          id=""bottom""
                                          transform=""translate(480, 320) scale(1, -1) translate(-480, -318)""></path>
                                </svg>
                       ");
            WriteLiteral("     </a>\r\n                        </div>\r\n                        <!--Endbutton for mobail-->\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</header>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Cosmetics.Application.Services.CosmeticsService.ICategoryService icategoryService { get; private set; }
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
