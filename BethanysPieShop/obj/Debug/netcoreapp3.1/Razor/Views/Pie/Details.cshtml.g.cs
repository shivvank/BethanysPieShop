#pragma checksum "C:\Users\shivank.yadav\OneDrive - Accenture\Desktop\Project\AspDotNetCore\BethanysPieShop\BethanysPieShop\Views\Pie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f733f7da17152b3953d6a499cb835d641b5ae8b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_Details), @"mvc.1.0.view", @"/Views/Pie/Details.cshtml")]
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
#line 1 "C:\Users\shivank.yadav\OneDrive - Accenture\Desktop\Project\AspDotNetCore\BethanysPieShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shivank.yadav\OneDrive - Accenture\Desktop\Project\AspDotNetCore\BethanysPieShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f733f7da17152b3953d6a499cb835d641b5ae8b8", @"/Views/Pie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e2adffd8fa631943a38bae85eb9953845992b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "C:\Users\shivank.yadav\OneDrive - Accenture\Desktop\Project\AspDotNetCore\BethanysPieShop\BethanysPieShop\Views\Pie\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div class=\"thumbnail\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 69, "\"", 90, 1);
#nullable restore
#line 5 "C:\Users\shivank.yadav\OneDrive - Accenture\Desktop\Project\AspDotNetCore\BethanysPieShop\BethanysPieShop\Views\Pie\Details.cshtml"
WriteAttributeValue("", 75, Model.ImageUrl, 75, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 91, "\"", 108, 1);
#nullable restore
#line 5 "C:\Users\shivank.yadav\OneDrive - Accenture\Desktop\Project\AspDotNetCore\BethanysPieShop\BethanysPieShop\Views\Pie\Details.cshtml"
WriteAttributeValue("", 97, Model.Name, 97, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
#nullable restore
#line 7 "C:\Users\shivank.yadav\OneDrive - Accenture\Desktop\Project\AspDotNetCore\BethanysPieShop\BethanysPieShop\Views\Pie\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3><a href=\"#\">");
#nullable restore
#line 8 "C:\Users\shivank.yadav\OneDrive - Accenture\Desktop\Project\AspDotNetCore\BethanysPieShop\BethanysPieShop\Views\Pie\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n        <h4>");
#nullable restore
#line 9 "C:\Users\shivank.yadav\OneDrive - Accenture\Desktop\Project\AspDotNetCore\BethanysPieShop\BethanysPieShop\Views\Pie\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 10 "C:\Users\shivank.yadav\OneDrive - Accenture\Desktop\Project\AspDotNetCore\BethanysPieShop\BethanysPieShop\Views\Pie\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591
