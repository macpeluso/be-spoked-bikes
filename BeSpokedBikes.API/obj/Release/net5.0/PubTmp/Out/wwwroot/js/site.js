const util = mdc.dialog.util;
const MDCDialog = mdc.dialog.MDCDialog;
const MDCDialogFoundation = mdc.dialog.MDCDialogFoundation;
const MDCTab = mdc.tab.MDCTab;
const MDCTabFoundation = mdc.tab.MDCTabFoundation;
const MDCDialogAdapter = mdc.dialog.MDCDialogAdapter;
const MDCList = mdc.list.MDCList;
const MDCTabBar = mdc.tabBar.MDCTabBar;
const MDCTabBarFoundation = mdc.tabBar.MDCTabBarFoundation;
const MDCMenu = mdc.menu.MDCMenu;
const MDCLineRipple = mdc.lineRipple.MDCLineRipple;
const MDCTopAppBar = mdc.topAppBar.MDCTopAppBar;
const Corner = mdc.menu.Corner;
const MDCFormField = mdc.formField.MDCFormField;
const MDCCheckbox = mdc.checkbox.MDCCheckbox;
const MDCDrawer = mdc.drawer.MDCDrawer;
const MDCRipple = mdc.ripple.MDCRipple;
const MDCTextField = mdc.textField.MDCTextField;
(function ($) {
    $.fn.serializeObject = function () {
        var o = {};
        var a = this.serializeArray();
        $.each(a, function () {
            if (o[this.name] !== undefined) {
                if (!o[this.name].push) {
                    //if (Array.isArray(o[this.name])) {
                    o[this.name] = [o[this.name]];
                }
                o[this.name].push(this.value || '');
            } else {
                o[this.name] = this.value || '';
            }
        });
        return o;
    };
})(jQuery);

$(document).ready(function () {
    axios.get("/getSalesPeople").then((res) => console.log(res.data))

    InitializeButtons();

});


function InitDialog(element) {
    if (element) {
        const id = element.id || CSS.escape("567");

        element.id = id;

        if (Dialogs.get(id) !== undefined) return Dialogs.get(id);
        else {
            var dialog = new MDCDialog(element);

            dialog.scrimClickAction = '';

            Dialogs.set(id, dialog);
            dialog.foundation_.adapter_.trapFocus = function () { };
            dialog.foundation_.escapeKeyAction_ = "";
            //const dropdowns = Array.from(element.querySelectorAll('select'));

            //if (dropdowns.length) dialog.Dropdowns = [];

            //Array.from(element.querySelectorAll('select')).forEach((x) => {
            //    dialog.Dropdowns.push($(x).KMSDropdown());
            //});

            return dialog;
        }
    }
    return null;
}
