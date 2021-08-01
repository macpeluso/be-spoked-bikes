#pragma checksum "C:\Users\macke\Sync\Documents\Development\be-spoked-bikes\BeSpokedBikes.API\Views\CustomElements\MProgressBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f27e10bbcf5c57e72c9993ade3ed0a9fac950c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomElements_MProgressBar), @"mvc.1.0.view", @"/Views/CustomElements/MProgressBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f27e10bbcf5c57e72c9993ade3ed0a9fac950c1", @"/Views/CustomElements/MProgressBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241f249e163f13c802dd845a6afd666783e5e862", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomElements_MProgressBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<template id=\"mProgressBarTemplate\">\r\n    <style>\r\n        .header.processing-text[hidden] {\r\n            display: none;\r\n            visibility: hidden;\r\n        }\r\n\r\n        ");
            WriteLiteral(@"@keyframes primary-indeterminate-translate {
            0% {
                transform: translateX(0);
            }

            20% {
                animation-timing-function: cubic-bezier(0.5, 0, 0.70173, 0.49582);
                transform: translateX(0);
            }

            59.15% {
                animation-timing-function: cubic-bezier(0.30244, 0.38135, 0.55, 0.95635);
                transform: translateX(83.67142%);
            }

            100% {
                transform: translateX(200.61106%);
            }
        }

        ");
            WriteLiteral(@"@keyframes primary-indeterminate-scale {
            0% {
                transform: scaleX(0.08);
            }

            36.65% {
                animation-timing-function: cubic-bezier(0.33473, 0.12482, 0.78584, 1);
                transform: scaleX(0.08);
            }

            69.15% {
                animation-timing-function: cubic-bezier(0.06, 0.11, 0.6, 1);
                transform: scaleX(0.66148);
            }

            100% {
                transform: scaleX(0.08);
            }
        }

        ");
            WriteLiteral(@"@keyframes secondary-indeterminate-translate {
            0% {
                animation-timing-function: cubic-bezier(0.15, 0, 0.51506, 0.40969);
                transform: translateX(0);
            }

            25% {
                animation-timing-function: cubic-bezier(0.31033, 0.28406, 0.8, 0.73371);
                transform: translateX(37.65191%);
            }

            48.35% {
                animation-timing-function: cubic-bezier(0.4, 0.62704, 0.6, 0.90203);
                transform: translateX(84.38617%);
            }

            100% {
                transform: translateX(160.27778%);
            }
        }

        ");
            WriteLiteral(@"@keyframes secondary-indeterminate-scale {
            0% {
                animation-timing-function: cubic-bezier(0.20503, 0.05705, 0.57661, 0.45397);
                transform: scaleX(0.08);
            }

            19.15% {
                animation-timing-function: cubic-bezier(0.15231, 0.19643, 0.64837, 1.00432);
                transform: scaleX(0.4571);
            }

            44.15% {
                animation-timing-function: cubic-bezier(0.25776, -0.00316, 0.21176, 1.38179);
                transform: scaleX(0.72796);
            }

            100% {
                transform: scaleX(0.08);
            }
        }

        ");
            WriteLiteral("@keyframes buffering {\r\n            to {\r\n                transform: translateX(-10px);\r\n            }\r\n        }\r\n\r\n        ");
            WriteLiteral(@"@keyframes primary-indeterminate-translate-reverse {
            0% {
                transform: translateX(0);
            }

            20% {
                animation-timing-function: cubic-bezier(0.5, 0, 0.70173, 0.49582);
                transform: translateX(0);
            }

            59.15% {
                animation-timing-function: cubic-bezier(0.30244, 0.38135, 0.55, 0.95635);
                transform: translateX(-83.67142%);
            }

            100% {
                transform: translateX(-200.61106%);
            }
        }

        ");
            WriteLiteral(@"@keyframes secondary-indeterminate-translate-reverse {
            0% {
                animation-timing-function: cubic-bezier(0.15, 0, 0.51506, 0.40969);
                transform: translateX(0);
            }

            25% {
                animation-timing-function: cubic-bezier(0.31033, 0.28406, 0.8, 0.73371);
                transform: translateX(-37.65191%);
            }

            48.35% {
                animation-timing-function: cubic-bezier(0.4, 0.62704, 0.6, 0.90203);
                transform: translateX(-84.38617%);
            }

            100% {
                transform: translateX(-160.27778%);
            }
        }

        ");
            WriteLiteral(@"@keyframes buffering-reverse {
            to {
                transform: translateX(10px);
            }
        }

        .mdc-linear-progress {
            position: relative;
            width: 100%;
            height: 4px;
            transform: translateZ(0);
            transition: opacity 250ms 0ms cubic-bezier(0.4, 0, 0.6, 1);
            overflow: hidden;
        }

        .mdc-linear-progress__bar {
            position: absolute;
            width: 100%;
            height: 100%;
            animation: none;
            transform-origin: top left;
            transition: transform 250ms 0ms cubic-bezier(0.4, 0, 0.6, 1);
        }

        .mdc-linear-progress__bar-inner {
            display: inline-block;
            position: absolute;
            width: 100%;
            height: 100%;
            animation: none;
        }

        .mdc-linear-progress__buffering-dots {
            position: absolute;
            width: 100%;
            height: 100%;
   ");
            WriteLiteral(@"         animation: buffering 250ms infinite linear;
            background-repeat: repeat-x;
            background-size: 10px 4px;
        }

        .mdc-linear-progress__buffer {
            position: absolute;
            width: 100%;
            height: 100%;
            transform-origin: top left;
            transition: transform 250ms 0ms cubic-bezier(0.4, 0, 0.6, 1);
        }

        .mdc-linear-progress__primary-bar {
            transform: scaleX(0);
        }

        .mdc-linear-progress__secondary-bar {
            visibility: hidden;
        }

        .mdc-linear-progress--indeterminate .mdc-linear-progress__bar {
            transition: none;
        }

        .mdc-linear-progress--indeterminate .mdc-linear-progress__primary-bar {
            left: -145.166611%;
            animation: primary-indeterminate-translate 2s infinite linear;
        }

            .mdc-linear-progress--indeterminate .mdc-linear-progress__primary-bar > .mdc-linear-progress__bar-inne");
            WriteLiteral(@"r {
                animation: primary-indeterminate-scale 2s infinite linear;
            }

        .mdc-linear-progress--indeterminate .mdc-linear-progress__secondary-bar {
            left: -54.888891%;
            animation: secondary-indeterminate-translate 2s infinite linear;
            visibility: visible;
        }

            .mdc-linear-progress--indeterminate .mdc-linear-progress__secondary-bar > .mdc-linear-progress__bar-inner {
                animation: secondary-indeterminate-scale 2s infinite linear;
            }

        .mdc-linear-progress--reversed .mdc-linear-progress__bar,
        .mdc-linear-progress--reversed .mdc-linear-progress__buffer {
            right: 0;
            transform-origin: center right;
        }

        .mdc-linear-progress--reversed .mdc-linear-progress__primary-bar {
            animation-name: primary-indeterminate-translate-reverse;
        }

        .mdc-linear-progress--reversed .mdc-linear-progress__secondary-bar {
            an");
            WriteLiteral(@"imation-name: secondary-indeterminate-translate-reverse;
        }

        .mdc-linear-progress--reversed .mdc-linear-progress__buffering-dots {
            animation: buffering-reverse 250ms infinite linear;
        }

        .mdc-linear-progress--closed {
            opacity: 0;
        }

        .mdc-linear-progress__bar-inner {
            background-color: #4184F3;
            /* ");
            WriteLiteral(@"@alternate */
            background-color: var(--mdc-theme-primary, #4184F3);
        }

        .mdc-linear-progress__buffering-dots {
            background-image: url(""data:image/svg+xml,%3Csvg version='1.1' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' x='0px' y='0px' enable-background='new 0 0 5 2' xml:space='preserve' viewBox='0 0 5 2' preserveAspectRatio='none slice'%3E%3Ccircle cx='1' cy='1' r='1' fill='%23e6e6e6'/%3E%3C/svg%3E"");
        }

        .mdc-linear-progress__buffer {
            background-color: #e6e6e6;
        }

        .mdc-linear-progress--indeterminate.mdc-linear-progress--reversed .mdc-linear-progress__primary-bar {
            right: -145.166611%;
            left: auto;
        }

        .mdc-linear-progress--indeterminate.mdc-linear-progress--reversed .mdc-linear-progress__secondary-bar {
            right: -54.888891%;
            left: auto;
        }
    </style>
    <div class=""cpb"">
        <div class=""header process");
            WriteLiteral(@"ing-text"" style=""font-size:1em;color:black;font-weight:500"">Loading</div>
        <div role=""progressbar"" class=""mdc-linear-progress"">
            <div class=""mdc-linear-progress__buffering-dots""></div>
            <div class=""mdc-linear-progress__buffer""></div>
            <div class=""mdc-linear-progress__bar mdc-linear-progress__primary-bar"">
                <span class=""mdc-linear-progress__bar-inner""></span>
            </div>
            <div class=""mdc-linear-progress__bar mdc-linear-progress__secondary-bar"">
                <span class=""mdc-linear-progress__bar-inner""></span>
            </div>
        </div>
    </div>
</template>
<script>
    window.ShadyCSS && ShadyCSS.prepareTemplate(mProgressBarTemplate, 'm-progress-bar');

    class mProgressBar extends HTMLElement {
        _loading = false;
        _finished=false;
        static get observedAttributes() { return ['text', 'hidden', 'determinate']; }

        get text() { return this.getAttribute(""text"") }

        set tex");
            WriteLiteral(@"t(val) { this.setAttribute(""text"", val); }

        get determinate() { return this.getAttribute(""determinate"") !== null; }

        set determinate(val) {
            this.parseBoolean(val) === false ? this.removeAttribute('determinate') : this.setAttribute(""determinate"", """");
        }

        get progress() { return this.ProgressBar.foundation_.progress_ * 100; }

        set progress(val) { 
            let prog = val / 100;

            this.ProgressBar.foundation_.setProgress(prog);

            if (prog === 1 && !this.finished) this.finished = true;
            else if (prog > 0 && prog < 1) this.determinate=true;        
        }

        get finished() { return this._finished }

        set finished(val) {
            val = this.parseBoolean(val) === true;
            if (val) {
                this._loading = false;
                this.determinate = true;
                if (this.progress !== 100) this.progress=100;
                this._inner.style.backgroundColor = '#");
            WriteLiteral(@"4caf50';
                this._text.innerText = ""Success""
            }
            else this.startLoading()
        }
        get loading() { return this._loading; }
        set loading(val) {
            this._loading = this.parseBoolean(val);
            this._loading && this.startLoading();           
        }
        toggle = () => this.hidden = !this.hidden;
        parseBoolean = (val) => (typeof (val) === ""string"" ? val.toLocaleLowerCase() === ""true"" : new Boolean(val)).valueOf()

        constructor() {
            super();
            this.attachShadow({ mode: 'open' });
            this.shadowRoot.appendChild(document.importNode(mProgressBarTemplate.content, true));

            this._text = this.shadowRoot.querySelector('.header');
            this._bar = this.shadowRoot.querySelector('.mdc-linear-progress');
            this._inner = this.shadowRoot.querySelector('.mdc-linear-progress__bar-inner');
            this._wrapper = this.shadowRoot.querySelector('.cpb');
        }");
            WriteLiteral(@"
        connectedCallback() {
            this.ProgressBar = new mdc.linearProgress.MDCLinearProgress(this._bar);

            this.setAttribute('slot', 'progress-bar');
            this.hidden = true;
            this.ProgressBar.foundation_.setDeterminate(false);
            this.determinate = this.determinate;
            //this._wrapper.setAttribute(""style"", this.getAttribute(""style""));
            //this.removeAttribute(""style"");

            if (this.style.width === """") this.style.width = ""100%"";
            if (this.style.height === """") this.style.height = ""36px"";
        }

        attributeChangedCallback(name, oldValue, newValue) {
            if (name === ""text"") this._text.innerText = newValue;
            else if (name === ""determinate"") this.ProgressBar && this.ProgressBar.foundation_.setDeterminate(newValue === """" || this.parseBoolean(newValue));
        }
        startLoading() {
            this.determinate = false;
            this.progress = 0;
            this._inner");
            WriteLiteral(@".style.backgroundColor = '';
            this.text = this.text;
            this.hidden=false;
        }
        toggleFinished(val) {
            if (val === true) {
                this._loading=false;
                this.determinate = true;
 
                this._inner.style.backgroundColor = '#4caf50';
                this._text.innerText = ""Success""
            } else this.startLoading();
        }
    }

    customElements.define('m-progress-bar', mProgressBar);
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
