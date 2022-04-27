#pragma checksum "D:\Projects\github\PCGuide\PCGuide\Views\News\GetNewsById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b581ef25b1ae3fcd0d03bfcc792a09c35cbc6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_GetNewsById), @"mvc.1.0.view", @"/Views/News/GetNewsById.cshtml")]
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
#nullable restore
#line 2 "D:\Projects\github\PCGuide\PCGuide\Views\_ViewImports.cshtml"
using PCGuide.Domain.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\github\PCGuide\PCGuide\Views\_ViewImports.cshtml"
using PCGuide.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\github\PCGuide\PCGuide\Views\_ViewImports.cshtml"
using PCGuide.Domain.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\github\PCGuide\PCGuide\Views\_ViewImports.cshtml"
using PCGuide.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b581ef25b1ae3fcd0d03bfcc792a09c35cbc6e", @"/Views/News/GetNewsById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd64682ca5f31abcb0f5246c795e824c227bcd14", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_News_GetNewsById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetNewsById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetNewsByTag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"blog-container\">\r\n    <div class=\"blog-header\">\r\n        <div class=\"blog-cover\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 135, "\"", 228, 2);
            WriteAttributeValue("", 141, "data:image/jpeg;base64,", 141, 23, true);
#nullable restore
#line 6 "D:\Projects\github\PCGuide\PCGuide\Views\News\GetNewsById.cshtml"
WriteAttributeValue("", 164, Convert.ToBase64String(Model?.ImageData ?? Array.Empty<byte>()), 164, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n        </div>\r\n    </div>\r\n    <div class=\"blog-body\">\r\n        <div class=\"blog-title\">\r\n            <h1>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53b581ef25b1ae3fcd0d03bfcc792a09c35cbc6e5396", async() => {
#nullable restore
#line 12 "D:\Projects\github\PCGuide\PCGuide\Views\News\GetNewsById.cshtml"
                                                                                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "D:\Projects\github\PCGuide\PCGuide\Views\News\GetNewsById.cshtml"
                                                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n        <div class=\"blog-text\">\r\n            <p>");
#nullable restore
#line 16 "D:\Projects\github\PCGuide\PCGuide\Views\News\GetNewsById.cshtml"
          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"blog-tags\">\r\n            <ul>\r\n");
#nullable restore
#line 20 "D:\Projects\github\PCGuide\PCGuide\Views\News\GetNewsById.cshtml"
                 foreach (string tag in Model.Tags)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53b581ef25b1ae3fcd0d03bfcc792a09c35cbc6e8891", async() => {
#nullable restore
#line 23 "D:\Projects\github\PCGuide\PCGuide\Views\News\GetNewsById.cshtml"
                                                                                                       Write(tag);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "D:\Projects\github\PCGuide\PCGuide\Views\News\GetNewsById.cshtml"
                                                                                          WriteLiteral(tag);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 25 "D:\Projects\github\PCGuide\PCGuide\Views\News\GetNewsById.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n    <div class=\"blog-footer\">\r\n        <ul>\r\n            <li class=\"published-date\">");
#nullable restore
#line 31 "D:\Projects\github\PCGuide\PCGuide\Views\News\GetNewsById.cshtml"
                                  Write(Model.DateCreate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
