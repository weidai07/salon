#pragma checksum "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6918397b3b0ff48ae1321110b9247ef7c778c49e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Index), @"mvc.1.0.view", @"/Views/Stylists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Index.cshtml", typeof(AspNetCore.Views_Stylists_Index))]
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
#line 5 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Index.cshtml"
using Salon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6918397b3b0ff48ae1321110b9247ef7c778c49e", @"/Views/Stylists/Index.cshtml")]
    public class Views_Stylists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Salon.Models.Stylist>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(84, 20, true);
            WriteLiteral("\n<h1>Stylists</h1>\n\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(130, 46, true);
            WriteLiteral("  <h3>No categories have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(179, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Index.cshtml"
 foreach (Stylist stylist in Model)
{

#line default
#line hidden
            BeginContext(218, 21, true);
            WriteLiteral("  <li id=\"stylistli\">");
            EndContext();
            BeginContext(240, 77, false);
#line 17 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Index.cshtml"
                Write(Html.ActionLink($"{stylist.Name}", "Details", new { id = stylist.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(317, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Index.cshtml"
}

#line default
#line hidden
            BeginContext(325, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(330, 44, false);
#line 20 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Index.cshtml"
Write(Html.ActionLink("Add new stylist", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(374, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(384, 40, false);
#line 22 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(424, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Salon.Models.Stylist>> Html { get; private set; }
    }
}
#pragma warning restore 1591
