#pragma checksum "/Users/Guest/Desktop/salon/Salon/Views/Clients/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32201e73fb5267b7a00033e6ea5985c32bdeab0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Delete), @"mvc.1.0.view", @"/Views/Clients/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Delete.cshtml", typeof(AspNetCore.Views_Clients_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32201e73fb5267b7a00033e6ea5985c32bdeab0a", @"/Views/Clients/Delete.cshtml")]
    public class Views_Clients_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Salon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/salon/Salon/Views/Clients/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(105, 47, false);
#line 9 "/Users/Guest/Desktop/salon/Salon/Views/Clients/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(152, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(155, 43, false);
#line 9 "/Users/Guest/Desktop/salon/Salon/Views/Clients/Delete.cshtml"
                                             Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(198, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/salon/Salon/Views/Clients/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(227, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/salon/Salon/Views/Clients/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(273, 40, false);
#line 14 "/Users/Guest/Desktop/salon/Salon/Views/Clients/Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Salon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
