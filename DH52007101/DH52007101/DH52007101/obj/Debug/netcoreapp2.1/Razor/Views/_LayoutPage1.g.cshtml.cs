#pragma checksum "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_LayoutPage1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7873c3fce47f01aa7e079294643218b01671492d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__LayoutPage1), @"mvc.1.0.view", @"/Views/_LayoutPage1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_LayoutPage1.cshtml", typeof(AspNetCore.Views__LayoutPage1))]
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
#line 1 "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_ViewImports.cshtml"
using DH52007101;

#line default
#line hidden
#line 2 "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_ViewImports.cshtml"
using DH52007101.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7873c3fce47f01aa7e079294643218b01671492d", @"/Views/_LayoutPage1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df08fc4c0926ff7b76832dc63b601414826506c3", @"/Views/_ViewImports.cshtml")]
    public class Views__LayoutPage1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_LayoutPage1.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 376, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "787138f416834285be7eb21c38fa0dff", async() => {
                BeginContext(64, 363, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <!-- Latest compiled and minified CSS -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Latest compiled JavaScript -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js""></script>
");
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
            BeginContext(434, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(436, 3915, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab7273b4ef6244cc8a7fd52aff03c655", async() => {
                BeginContext(442, 495, true);
                WriteLiteral(@"
    <div class=""container-fluid"">
        <div class=""card"">
            <div class=""card-header bg-secondary text-white"">
                Header
            </div>
            <div class=""card-title"">
                <div class=""row"">
                    <div class=""col-8"">
                        <div class=""nav nav-tabs"">
                            <div class=""nav-item bg-primary"">
                                <div class=""nav-link"">
                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 937, "\"", 971, 1);
#line 28 "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_LayoutPage1.cshtml"
WriteAttributeValue("", 944, Url.Action("Index","Home"), 944, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(972, 306, true);
                WriteLiteral(@"
                                       class=""text-white"">Trang chủ</a>
                                </div>
                            </div>
                            <div class=""nav-item bg-primary"">
                                <div class=""nav-link"">
                                    ");
                EndContext();
                BeginContext(1279, 118, false);
#line 34 "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_LayoutPage1.cshtml"
                               Write(Html.ActionLink("Trang chủ", "Index",
                                   "Home", null, new { @class = "text-white" }));

#line default
#line hidden
                EndContext();
                BeginContext(1397, 233, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"nav-item bg-primary\">\r\n                                <div class=\"nav-link\">\r\n                                    ");
                EndContext();
                BeginContext(1631, 118, false);
#line 40 "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_LayoutPage1.cshtml"
                               Write(Html.ActionLink("Trang chủ", "Index",
                                   "Home", null, new { @class = "text-white" }));

#line default
#line hidden
                EndContext();
                BeginContext(1749, 398, true);
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""nav nav-tabs float-right"">
                            <div class=""nav-item bg-primary"">
                                <div class=""nav-link"">
                                    ");
                EndContext();
                BeginContext(2148, 118, false);
#line 50 "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_LayoutPage1.cshtml"
                               Write(Html.ActionLink("Trang chủ", "Index",
                                   "Home", null, new { @class = "text-white" }));

#line default
#line hidden
                EndContext();
                BeginContext(2266, 233, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"nav-item bg-primary\">\r\n                                <div class=\"nav-link\">\r\n                                    ");
                EndContext();
                BeginContext(2500, 118, false);
#line 56 "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_LayoutPage1.cshtml"
                               Write(Html.ActionLink("Trang chủ", "Index",
                                   "Home", null, new { @class = "text-white" }));

#line default
#line hidden
                EndContext();
                BeginContext(2618, 233, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"nav-item bg-primary\">\r\n                                <div class=\"nav-link\">\r\n                                    ");
                EndContext();
                BeginContext(2852, 118, false);
#line 62 "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_LayoutPage1.cshtml"
                               Write(Html.ActionLink("Trang chủ", "Index",
                                   "Home", null, new { @class = "text-white" }));

#line default
#line hidden
                EndContext();
                BeginContext(2970, 1152, true);
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-3"">
                        <div class=""nav flex-column"">
                            <a class=""nav-link bg-info text-dark rounded border border-light"" href=""Nhasanxuat"">Quản lý Nhà sản xuất</a>
                            <a class=""nav-link bg-info text-dark rounded border border-light"" href=""Nhanvien"">Quản lý Nhân viên</a>
                            <a class=""nav-link bg-info text-dark rounded border border-light"" href=""Khachhang"">Quản lý Khách hàng</a>
                            <a class=""nav-link bg-info text-dark rounded border border-light"" href=""Loaihanghoa"">Quản lý Loại hàng hoá</a>
                            <a class=""nav-link bg-info text-dark rounded border border-light"" href=""Hanghoa"">Quản lí Hàng hoá</a");
                WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-9\">\r\n                        ");
                EndContext();
                BeginContext(4123, 12, false);
#line 82 "C:\Users\QuocThang\Documents\GitHub\thuc_hanh_lap_trinh_windows\DH52007101\DH52007101\DH52007101\Views\_LayoutPage1.cshtml"
                   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4135, 209, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-footer bg-secondary text-white\">\r\n                Footer\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(4351, 11, true);
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
