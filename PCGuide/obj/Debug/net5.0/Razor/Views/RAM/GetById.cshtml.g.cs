#pragma checksum "D:\Projects\github\PCGuide\PCGuide\Views\RAM\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e5e9743f8c6c0d700393e0370d5a293a226b89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RAM_GetById), @"mvc.1.0.view", @"/Views/RAM/GetById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51e5e9743f8c6c0d700393e0370d5a293a226b89", @"/Views/RAM/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0f3585db3c6fbb6003430b82a1d4b20dce857e3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RAM_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RAMViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\github\PCGuide\PCGuide\Views\RAM\GetById.cshtml"
  
    ViewBag.Title = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2>");
#nullable restore
#line 8 "D:\Projects\github\PCGuide\PCGuide\Views\RAM\GetById.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 121, "\"", 214, 2);
            WriteAttributeValue("", 127, "data:image/jpeg;base64,", 127, 23, true);
#nullable restore
#line 10 "D:\Projects\github\PCGuide\PCGuide\Views\RAM\GetById.cshtml"
WriteAttributeValue("", 150, Convert.ToBase64String(Model?.ImageData ?? Array.Empty<byte>()), 150, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n        <p>Название: ");
#nullable restore
#line 11 "D:\Projects\github\PCGuide\PCGuide\Views\RAM\GetById.cshtml"
                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Производитель: ");
#nullable restore
#line 12 "D:\Projects\github\PCGuide\PCGuide\Views\RAM\GetById.cshtml"
                     Write(Model.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Частота: ");
#nullable restore
#line 13 "D:\Projects\github\PCGuide\PCGuide\Views\RAM\GetById.cshtml"
               Write(Model.ClockSpeed);

#line default
#line hidden
#nullable disable
            WriteLiteral(" МГц</p>\r\n        <p>Задержки: ");
#nullable restore
#line 14 "D:\Projects\github\PCGuide\PCGuide\Views\RAM\GetById.cshtml"
                Write(Model.Delay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Объём: ");
#nullable restore
#line 15 "D:\Projects\github\PCGuide\PCGuide\Views\RAM\GetById.cshtml"
             Write(Model.MemoryCapacity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Гб</p>\r\n        <p>Тип: ");
#nullable restore
#line 16 "D:\Projects\github\PCGuide\PCGuide\Views\RAM\GetById.cshtml"
           Write(Model.MemoryType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RAMViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
