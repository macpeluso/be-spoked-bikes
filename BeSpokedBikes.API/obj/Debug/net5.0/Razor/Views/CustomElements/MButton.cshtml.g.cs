#pragma checksum "C:\Users\macke\Sync\Documents\Development\be-spoked-bikes\BeSpokedBikes.API\Views\CustomElements\MButton.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b55956163425bcab36b9d66e4337a9530bd9290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomElements_MButton), @"mvc.1.0.view", @"/Views/CustomElements/MButton.cshtml")]
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
#line 1 "C:\Users\macke\Sync\Documents\Development\be-spoked-bikes\BeSpokedBikes.API\Views\_ViewImports.cshtml"
using BeSpokedBikes.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\macke\Sync\Documents\Development\be-spoked-bikes\BeSpokedBikes.API\Views\_ViewImports.cshtml"
using BeSpokedBikes.API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b55956163425bcab36b9d66e4337a9530bd9290", @"/Views/CustomElements/MButton.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241f249e163f13c802dd845a6afd666783e5e862", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomElements_MButton : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    class mButton extends HTMLElement {
        constructor() {
            super();
        }

        connectedCallback() {
            let type = this.getAttribute(""type"");
            if (type === ""icon"") {
                this.classList.add('mdc-icon-button');               
            }
            else this.classList.add('mdc-button');
        
            this.Color = this.getAttribute(""color"");

            if (this.Color !== null) this.classList.add(this.Color); 
        }
    }

    customElements.define('m-button', mButton);
</script>");
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