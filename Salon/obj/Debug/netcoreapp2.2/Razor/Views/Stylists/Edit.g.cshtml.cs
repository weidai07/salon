#pragma checksum "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed3b82cd7c48ec949ac536c1d635da6774af14ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Edit), @"mvc.1.0.view", @"/Views/Stylists/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Edit.cshtml", typeof(AspNetCore.Views_Stylists_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3b82cd7c48ec949ac536c1d635da6774af14ef", @"/Views/Stylists/Edit.cshtml")]
    public class Views_Stylists_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Salon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 39, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this stylist: ");
            EndContext();
            BeginContext(96, 36, false);
#line 9 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Edit.cshtml"
                  Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(132, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(172, 40, false);
#line 13 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Edit.cshtml"
Write(Html.HiddenFor(model => model.StylistId));

#line default
#line hidden
            EndContext();
            BeginContext(219, 34, false);
#line 15 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(259, 35, false);
#line 16 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(296, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(339, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(343, 46, false);
#line 20 "/Users/Guest/Desktop/HairSalon.Solution/Salon/Views/Stylists/Edit.cshtml"
Write(Html.ActionLink("Back to categories", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(389, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Salon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
