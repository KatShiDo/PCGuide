#pragma checksum "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fbcf8dc887cfbd5dfe170504bba877c495db27e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Motherboard_Index), @"mvc.1.0.view", @"/Views/Motherboard/Index.cshtml")]
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
#nullable restore
#line 6 "D:\Projects\github\PCGuide\PCGuide\Views\_ViewImports.cshtml"
using PCGuide.Domain.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fbcf8dc887cfbd5dfe170504bba877c495db27e", @"/Views/Motherboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0f3585db3c6fbb6003430b82a1d4b20dce857e3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Motherboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MotherboardViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Motherboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
  
    ViewBag.Title = "Процессоры";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"pc_parts_list\">\r\n");
#nullable restore
#line 10 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
         foreach (var entity in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pc_parts_block\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 258, "\"", 352, 2);
            WriteAttributeValue("", 264, "data:image/jpeg;base64,", 264, 23, true);
#nullable restore
#line 13 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
WriteAttributeValue("", 287, Convert.ToBase64String(entity?.ImageData ?? Array.Empty<byte>()), 287, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n                <div class=\"pc_parts_desc\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbcf8dc887cfbd5dfe170504bba877c495db27e5863", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 16 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
                   Write(entity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
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
#line 15 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
                                                                                       WriteLiteral(entity.Id);

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
            WriteLiteral("\r\n                    <div class=\"pc_parts_params\">\r\n                        <p>Производитель: ");
#nullable restore
#line 19 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
                                     Write(entity.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Сокет: ");
#nullable restore
#line 20 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
                             Write(entity.Socket);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Чипсет: ");
#nullable restore
#line 21 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
                              Write(entity.Chipset);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Форм-фактор: ");
#nullable restore
#line 22 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
                                   Write(entity.MotherboardType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 26 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 28 "D:\Projects\github\PCGuide\PCGuide\Views\Motherboard\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MotherboardViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
