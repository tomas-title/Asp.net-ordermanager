#pragma checksum "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2107702a0ccc8806309b61b326c8018be91f9dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_DisplayBase), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/DisplayBase.cshtml")]
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
#line 1 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\_ViewImports.cshtml"
using AtomicSeller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\_ViewImports.cshtml"
using AtomicSeller.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
using AtomicSeller.Helpers.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
using AtomicSeller.Helpers.Razor.HtmlExtensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2107702a0ccc8806309b61b326c8018be91f9dd7", @"/Views/Shared/DisplayTemplates/DisplayBase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a0039f6a8aa9b448d53da5bc34a03f444a947e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_DisplayBase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
  
    // Kind: either "raw" or "form-group"
    ViewBag.kind = ViewBag.kind ?? "raw";

    if (ViewBag.kind != "raw" && ViewBag.kind != "form-group")
    {
        throw new Exception("Unknown kind " + ViewBag.kind);
    }
    
    // Value
    var value = ViewBag.value ?? Model;
    
    // HTML attributes
    var htmlAttributes = (RouteValueDictionary)ViewBag.htmlAttributes ?? new RouteValueDictionary();

    // Model type
    htmlAttributes["data-type"] = ViewData.ModelMetadata.DataTypeName ?? ViewData.ModelMetadata.ModelType.Name;

    htmlAttributes["class"] =
        (ViewBag.kind == "form-group" ? "controls " + HtmlClasses.ControlRaw + " " : "") + // Class depending on kind
        ViewBag.valueClass + " " + // text-date, text-number...
        ViewBag.@class; // Custom classes

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
 if (ViewBag.kind == "raw")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div ");
#nullable restore
#line 32 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
    Write(HtmlHelpers.DictionaryToHTMLString(htmlAttributes));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n        ");
#nullable restore
#line 33 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
   Write(value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 35 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
         if (ViewBag.suffix != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
       Write(ViewBag.suffix);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
                           
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 40 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
}
else if (ViewBag.kind == "form-group")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 1231, "\"", 1297, 2);
            WriteAttributeValue("", 1239, "form-group", 1239, 10, true);
#nullable restore
#line 43 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
WriteAttributeValue("", 1249, Html.ValidationErrorFor(m => m, " has-error"), 1249, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 44 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
         if (ViewBag.labelText == null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
       Write(Html.LabelFor(m => m, new { @class = HtmlClasses.Label }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
                                                                      ;
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
       Write(Html.LabelFor(m => m, (string)ViewBag.labelText, new { @class = HtmlClasses.Label }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
                                                                                                 ;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div ");
#nullable restore
#line 53 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
        Write(HtmlHelpers.DictionaryToHTMLString(htmlAttributes));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n            ");
#nullable restore
#line 54 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
       Write(value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 56 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
             if (ViewBag.suffix != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
           Write(ViewBag.suffix);

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
                               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 62 "D:\Projects\AtomicSeller\Tech\Apps\_OrderManager\Dev\AtomicSeller\Views\Shared\DisplayTemplates\DisplayBase.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
