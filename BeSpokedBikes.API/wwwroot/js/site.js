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
$(document).ready(function () {
    axios.get( "/getProducts" ).then((res)=>console.log(res.data))
    window.TestDialog = $('#test')[0]
    LoadProducts();
});
function LoadProducts() {
    $("#products").jsGrid({
        height: "auto",
        width: "100%",

        sorting: true,
        paging: false,
        autoload: true,
        rowClick: function(args) {
            TestDialog.open();
        },
        controller: {
            loadData: function () {
                var d = $.Deferred();

                $.ajax({
                    url:"/getProducts",
                    dataType: "json"
                }).done(function (response) {
                    d.resolve(response);
                });

                return d.promise();
            }
        },

        fields: [
            { name: "name",title:"Name", type: "text" },
            { name: "manufacturer",title:"Manufacturer", type: "text", width: 50 },
            { name: "style", title:"Style",type: "text", width: 50, align: "left"},
            { name: "salePrice", title:"Sale Price",type: "number", width:50,
                itemTemplate: function (value) {
                    return "$"+value.toFixed(2);
                }},
            { name: "purchasePrice", title:"Purchase Price",type: "number", width:50,
                itemTemplate: function (value) {
                    return "$"+value.toFixed(2);
                }},
            { name: "quantity", title:"Quantity",type: "number", width:50},
        ]
    });

}
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
