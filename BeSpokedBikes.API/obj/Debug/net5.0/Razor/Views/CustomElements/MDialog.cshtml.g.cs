#pragma checksum "C:\Users\macke\Sync\Documents\Development\be-spoked-bikes\BeSpokedBikes.API\Views\CustomElements\MDialog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85aaf9de112e08e7d2533e96157c06f21caf3a64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomElements_MDialog), @"mvc.1.0.view", @"/Views/CustomElements/MDialog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85aaf9de112e08e7d2533e96157c06f21caf3a64", @"/Views/CustomElements/MDialog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241f249e163f13c802dd845a6afd666783e5e862", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomElements_MDialog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<template id=""MDialogTemplate"">
	<style>
		.m-dialog ::slotted([slot=""title""]), ::slotted([slot=""title""]) {
			color: rgba(0, 0, 0, 0.87);
			line-height: 2rem;
			text-decoration: inherit;
			display: block;
			position: relative;
			flex-shrink: 0;
			box-sizing: border-box;
			margin: 0;
			border-bottom: 1px solid transparent;
			font-size: 1.3rem;
			font-weight: 500;
			letter-spacing: .01rem;
			margin-top: 0px;
			padding-bottom: 10px;
			padding-right: 0;
			/* text-transform: uppercase; */
			padding: 0;
			padding-bottom: 15px;
		}

			.m-dialog ::slotted([slot=""title""])::before, ::slotted([slot=""title""])::before {
				display: inline-block;
				width: 0;
				height: 40px;
				content: """";
				vertical-align: 0;
			}

		 footer {
			display: flex;
			position: relative;
			flex-shrink: 0;
			flex-wrap: wrap;
			align-items: center;
			justify-content: flex-end;
			box-sizing: border-box;
			min-height: 48px;
			margin: 0;
			padding: 20px 12px 12px 0;
			ma");
            WriteLiteral(@"rgin-right: -1rem;
			border-top: 1px solid transparent;
		}

		.mdc-dialog,
		.mdc-dialog__scrim {
			align-items: center;
			box-sizing: border-box;
			height: 100%;
			justify-content: center;
			left: 0;
			position: fixed;
			top: 0;
			width: 100%;
		}

		.mdc-dialog {
			display: none;
			z-index: 7;
		}

			.mdc-dialog .mdc-dialog__surface {
				font-family: Roboto, sans-serif;
				background-color: #fff;
				background-color: var(--mdc-theme-surface, #fff);
				-webkit-font-smoothing: antialiased;
				font-size: 1rem;
				line-height: 1.5rem;
				font-weight: 400;
				letter-spacing: 0.03125em;
				text-decoration: inherit;
				text-transform: inherit;
				flex-grow: 1;
				box-sizing: border-box;
				margin: 0;
				padding: 0 24px;
				overflow: auto;
				padding-left: 24px;
				padding-top: 0px;
				max-width: none !important;
			}

			.mdc-dialog .mdc-dialog__scrim {
				background-color: rgba(0, 0, 0, 0.32);
			}

			.mdc-dialog .mdc-dialog__content {");
            WriteLiteral(@"
				color: rgba(0, 0, 0, 0.6);
			}

			.mdc-dialog.mdc-dialog--scrollable .mdc-dialog__title,
			.mdc-dialog.mdc-dialog--scrollable .mdc-dialog__actions {
				border-color: rgba(0, 0, 0, 0.12);
			}

			.mdc-dialog .mdc-dialog__surface {
				min-width: 280px;
			}

		");
            WriteLiteral("@media (max-width: 592px) {\r\n\t\t\t.mdc-dialog .mdc-dialog__surface {\r\n\t\t\t\tmax-width: calc(100vw - 32px);\r\n\t\t\t}\r\n\t\t}\r\n\r\n\t\t");
            WriteLiteral(@"@media (min-width: 592px) {
			.mdc-dialog .mdc-dialog__surface {
				max-width: 560px;
			}
		}

		.mdc-dialog .mdc-dialog__surface {
			max-height: calc(100% - 32px);
		}

		.mdc-dialog .mdc-dialog__surface {
			border-radius: 4px;
		}

		.mdc-dialog__scrim {
			opacity: 0;
			z-index: -1;
		}

		.mdc-dialog__container {
			align-items: center;
			box-sizing: border-box;
			display: flex;
			flex-direction: row;
			height: 100%;
			justify-content: space-around;
			opacity: 0;
			pointer-events: none;
			transform: scale(0.8);
		}

		.mdc-dialog--open,
		.mdc-dialog--opening,
		.mdc-dialog--closing {
			display: flex;
		}

			.mdc-dialog--opening .mdc-dialog__scrim {
				transition: opacity 150ms linear;
			}

			.mdc-dialog--opening .mdc-dialog__container {
				transition: opacity 75ms linear, transform 150ms 0ms cubic-bezier(0, 0, 0.2, 1);
			}

			.mdc-dialog--closing .mdc-dialog__scrim,
			.mdc-dialog--closing .mdc-dialog__container {
				transition: opacit");
            WriteLiteral(@"y 75ms linear;
			}

			.mdc-dialog--closing .mdc-dialog__container {
				transform: scale(1);
			}

			.mdc-dialog--open .mdc-dialog__scrim {
				opacity: 1;
			}

			.mdc-dialog--open .mdc-dialog__container {
				opacity: 1;
				transform: scale(1);
			}

		.mdc-dialog-scroll-lock {
			overflow: hidden;
		}

		.mdc-dialog__surface {
			box-shadow: 0px 11px 15px -7px rgba(0, 0, 0, 0.2), 0px 24px 38px 3px rgba(0, 0, 0, 0.14), 0px 9px 46px 8px rgba(0, 0, 0, 0.12);
			box-sizing: border-box;
			display: flex;
			flex-direction: column;
			flex-grow: 0;
			flex-shrink: 0;
			max-height: 100%;
			max-width: 100%;
			overflow-y: auto;
			pointer-events: auto;
		}
	</style>
	<div class=""mdc-dialog"">
		<div class=""mdc-dialog__container"">
			<div class=""mdc-dialog__surface"" slot=""inner"">
				<slot name=""title""></slot>
				<slot class=""content""></slot>
				<footer>
					<slot name=""actions""></slot>
					<slot name=""progress-bar""></slot>
				</footer>
			</div>
		</div>
		<di");
            WriteLiteral(@"v class=""mdc-dialog__scrim""></div>
	</div>
</template>
<script>
    window.Dialogs = new Map;
    window.ShadyCSS && ShadyCSS.prepareTemplate(MDialogTemplate, 'm-dialog');

    class MDialog extends HTMLElement {
        static get observedAttributes() { return ['title','hide-footer']; }

        get acceptActionButton() { return this.querySelector('[action=accept]') }

        get closeActionButton() { return this.querySelector('[action=close]') }

        get title() { return this.getAttribute(""title"") }

        set title(val) { this.setAttribute(""title"", val); }

        get type() { return this.getAttribute('type') }

        get hideFooter() { return this.getAttribute('hide-footer') }
        set hideFooter(val) { return this.setAttribute('hide-footer', val) }

        set type(val) { this.setAttribute('type', val); }
        get onOpened() { return this.getAttribute('on-opened') }
        set onOpened(val) { return this.setAttribute('on-opened', val) }
        set onConfirm(va");
            WriteLiteral(@"l) {
            if (this.acceptActionButton) {
                this.acceptActionButton.removeEventListener(""click"", this.onConfirmClicked);
                this.acceptActionButton.addEventListener(""click"", val);
            }
            this.onConfirmClicked = val;
        }
        get loading() { return this.ProgressBar.loading }
        set loading(val) {
            this.ProgressBar.loading = val;
            if (!val) this.ProgressBar.hidden = true;
        }
        get loadingProgress() { return this.ProgressBar.progress }
        set loadingProgress(val) {
            this.ProgressBar.progress = val;
        }
        set onClosed(val) {
            if (this.closeActionButton) {
                this.closeActionButton.removeEventListener(""click"", this.onCloseCallback);
                this.closeActionButton.addEventListener(""click"", val);
            }
            this.onCloseCallback = val;
        }

        open() {
            //DisableScroll();

            this.mdcCom");
            WriteLiteral(@"ponent.open();
        }

        close() {
            this.mdcComponent.close();
        }

        set onClosed(val) { this.onCloseCallback = val; }

        constructor() {
            super();

            this.attachShadow({ mode: 'open' });

            this.shadowRoot.appendChild(document.importNode(MDialogTemplate.content, true));

            this._dialog = this.shadowRoot.querySelector('.mdc-dialog');
            this._titleSlot = this.shadowRoot.querySelector('slot[name=title]');

            this._actionsSlot = this.shadowRoot.querySelector('slot[name=actions]');
            this._barSlot = this.shadowRoot.querySelector('slot[name=progress-bar]');
            this._root = this.shadowRoot.querySelector('.mdc-dialog');
            this._container = this.shadowRoot.querySelector('.mdc-dialog__container');
            this._surface = this.shadowRoot.querySelector('.mdc-dialog__surface');
            this._content = this.shadowRoot.querySelector('slot[name=content]');
        ");
            WriteLiteral(@"    this._titleSlot.addEventListener('slotchange', function (slot) { this.onSlotChange(slot); }.bind(this));

            this._actionsSlot.addEventListener('slotchange', function (slot) { this.onSlotChange(slot); }.bind(this));
        }

        onConfirmClicked() {
        }

        onCloseCallback() {
        }

        attributeChangedCallback(name, oldValue, newValue) {
            if (name === ""title"") this.handleTitle(newValue);
            else if (name === ""on-opened"") this._dialog.listen(""MDCDialog:opened"", () => newValue);
            else if (name === ""hide-footer"") {
                if (newValue.toLowerCase() === ""true"") this._surface.querySelector('footer').style.display = ""none"";
                else this._surface.querySelector('footer').style.display = ""flex"";
            }
        }

        createActionButton(type) {
            const button = document.createElement('m-button');

            if (type === ""close"") {
                button.setAttribute(""color"", ""negat");
            WriteLiteral(@"ive"");
                button.setAttribute(""action"", ""close"");
                button.addEventListener(""close"", () => this.mdcComponent.close());
            } else if (type === ""accept"") {
                button.setAttribute(""color"", ""primary"");
                button.setAttribute(""action"", ""accept"");
                button.classList.add(""mdc-button--raised"");
            }

            return button;
        }

        handleTitle(title) {
            const existingTitle = this.querySelector('m-dialog-title');
            const titleIsNotNull = (title !== null && title !== """");
            if (!existingTitle) {
                if (titleIsNotNull) {
                    const titleEle = document.createElement(""m-dialog-title"");
                    titleEle.innerText = title;
                    this.appendChild(titleEle);
                }

            } else {
                if (titleIsNotNull) existingTitle.innerText = title;
                else existingTitle.remove();
           ");
            WriteLiteral(@" }
        }

        onSlotChange(event) {
            const slot = event.currentTarget;
            const slotName = slot.getAttribute(""name"");

            if (slotName === ""title"") if (slot.assignedNodes().length > 1) slot.assignedNodes()[0].remove();
            else if (slotName === ""actions"") if (slot.assignedNodes().length > 1) slot.assignedNodes()[0].remove();

        }

        connectedCallback() {
            Promise.all([
                customElements.whenDefined('m-dialog-title'),
                customElements.whenDefined('m-dialog-content'),
                customElements.whenDefined('m-dialog-actions'),
                customElements.whenDefined('m-progress-bar'),
                customElements.whenDefined('m-button')
            ])
                .then(() => { this.buildTemplate() });
            setTimeout(() => { this.setUpActions(); this.setUpProgressBar(); });

        }
        setUpProgressBar() {
            this.ProgressBar = this.querySelector('m-progress");
            WriteLiteral(@"-bar') || document.createElement('m-progress-bar');

            if (!this._barSlot.hasChildNodes) this.appendChild(this.ProgressBar)
        }
        toggleProgressBarVisibility(val) {
            val !== undefined ? this.ProgressBar.hidden = !val : this.ProgressBar.toggle();
        }
        setUpActions(type) {
            const existingButtons = this.querySelector('m-dialog-actions');

            let action = type || this.type;

            if (!existingButtons) {

                const actions = document.createElement('m-dialog-actions');

                const closeActionButton = this.createActionButton(""close"");
                const acceptActionButton = this.createActionButton(""accept"");

                if (action === ""edit"" || action === null) {
                    closeActionButton.innerText = ""Cancel"";
                    acceptActionButton.innerText = ""Save"";
                }

                actions.appendChild(closeActionButton);
                actions.appendChild(");
            WriteLiteral(@"acceptActionButton);

                this.appendChild(actions);

                this.closeActionButton.addEventListener(""click"", () => this.mdcComponent.close());

                this.onConfirm = this.onConfirmClicked;
                this.onClosed = this.onCloseCallback;

            }
            else if (this.id === ""new-refund-dialog"")		// handler for the refund dialog button, which is unique on its cshtml
                this.closeActionButton.addEventListener(""click"", () => this.mdcComponent.close());
        }
        buildTemplate() {
            this.classList.add('m-dialog');
            this._surface.setAttribute(""style"", this.getAttribute(""style""));

            this.removeAttribute(""style"");

            this.mdcComponent = new MDCDialog(this._dialog);
            this.mdcComponent.foundation_.adapter_.trapFocus = function () { };
            this.mdcComponent.autoStackButtons = false;
            this.mdcComponent.escapeKeyAction = """";
            this.mdcComponent.scri");
            WriteLiteral(@"mClickAction = """";

            //            this._dialog.addEventListener('MDCDialog:opened', () => DisableScroll());
            this._dialog.addEventListener(""MDCDialog:closed"",
                function () {
                    let openDialogs = Array.from(Dialogs.values()).filter((x) => x.isOpen).map((x) => x).length;
                    //if (!openDialogs) EnableScroll();
                    this.onCloseCallback();
                }.bind(this));

            if (this.onOpened) this._dialog.addEventListener(""MDCDialog:opened"", function () { eval(this.onOpened) }.bind(this));

            const id = this.id || CSS.escape(GenerateGuid());

            this.id = id;

            this.classList.add(""ui"", ""form"");

            Dialogs.set(id, this.mdcComponent);
        }
    }

    customElements.define('m-dialog', MDialog);

    class MDialogTitle extends HTMLElement {
        constructor() {
            super();
        }

        connectedCallback() {
            this.setAttr");
            WriteLiteral(@"ibute('slot', 'title');
            this.classList.add('m-dialog_title');

        }
    }

    customElements.define('m-dialog-title', MDialogTitle);

    class MDialogContent extends HTMLElement {
        constructor() {
            super();
        }

        connectedCallback() {
            this.setAttribute('slot', 'content');
            this.classList.add('mdc-dialog__content');
        }
    }

    customElements.define('m-dialog-content', MDialogContent);

    class MDialogActions extends HTMLElement {
        constructor() {
            super();
        }

        connectedCallback() {
            this.setAttribute('slot', 'actions');
        }
    }

    customElements.define('m-dialog-actions', MDialogActions);
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