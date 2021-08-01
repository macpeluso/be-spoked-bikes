
function Render(b, item, grid, parentDiv) {
    var button;

    var btnGroup;

    if ((b.condition && b.condition(item)) || b.condition === undefined) {

        button = $("<button>").addClass("ui " + b.css).attr("type", "button");

        if (b.url) {
            var url = FormatUrl(b.url, b.data, item);
        }
        if (b.data) {
            var keys = Object.keys(b.data);

            for (var i = 0; i < keys.length; i++) {
                var value = item[b.data[keys[i]]];
                if (value !== undefined) {
                    button.attr('data-' + keys[i], value);
                }
            }
        }
        if (b.icon) {
            button.append($('<div>').addClass('mdc-icon-button__ripple'))
            var icon = $("<i>").addClass(b.icon + ' fa-fw icon');

            if (b.color) {
                icon.css('color', b.color);
            }
            button.append(icon);
        }
        if (b.text) {
            button.text(b.text);
        }
        if (b.url) {
            button.attr('data-url', url);
        }


        button.attr("data-content", b.tooltipText);

        if (b.id !== undefined) button.attr('data-id', item[b.id]);

 

        if (b.menu) {
            var menu = b.menu;
            var menuWrapper = $('<div/>').addClass('mdc-menu-surface--anchor ' + (menu.class ? menu.class : ""));
            var menuSurface = $('<div/>').addClass('mdc-menu mdc-menu-surface');
            var menuListWrapper = $('<ul/>').addClass('mdc-list').attr('role', 'menu');
            if (menu.items) {
                for (i = 0; i < menu.items.length; i++) {
                    var item = menu.items[i];
                    var li = $('<li/>').addClass('mdc-list-item ' + (item.class ? item.class : "")).attr('role', 'menuitem').text(item.text);

                    if (item.onClick) li.on("click", item.onClick);

                    menuListWrapper.append(li);
                }
            }

            let mdcList = new mdc.list.MDCList(menuListWrapper[0]);

            menuSurface.append(menuListWrapper);

            let mdcMenu = new mdc.menu.MDCMenu(menuSurface[0]);

            mdcMenu.handleAfterOpened_ = function () {
                var t = this.items;
                t.length;
            };
            //             menuWrapper.append(button);
            menuWrapper.append(menuSurface);

            parentDiv.append(menuWrapper);

            button.on("click", function () { mdcMenu.open = true; }.bind(mdcMenu));

            return button;
        }

        if (b.onClick) {
            button.on("click", b.onClick);
        }



    }



    return button;
}

function RenderHeaderButton(b) {
    var button;

    button = $("<button>").addClass("ui " + b.css).attr("type", "button");
    button.css('margin-right', '-6px');
    if (b.icon) {
        var icon = $("<i>").addClass(b.icon + ' fa-fw icon');

        if (b.color) {
            icon.css('color', b.color);
        }
        button.append(icon);
    }

    if (b.text) {
        button.text(b.text);
    }
    if (b.url) {
        button.attr('data-url', b.url);
    }

    button.attr("data-content", b.tooltipText);

    if (b.onClick && b.action === undefined) {
        button.on("click", b.onClick);
    }

    return button;
}

function InitializeButtons() {
    window.EditProductButton = {
        css: "mdc-icon-button primary",
        data: {
            Id: "productId",
            name: "name",
            manufacturer: "manufacturer",
            style: "style",
            salePrice: "salePrice",
            purchasePrice: "purchasePrice",
            commission: "commissionPercentage",
            quantity: "quantity",
            phone:"phone"

        },
        //action: "edit",
        dataToUrl: true,
        icon: "fa fa-pen",
        onClick: function (e) {
            $('#ProductId').val($(this).data('id'));
            $('#Name').val($(this).data('name'));
            $('#Manufacturer').val($(this).data('manufacturer'));
            $('#Style').val($(this).data('style'));
            $('#SalePrice').val($(this).data('saleprice'));
            $('#PurchasePrice').val($(this).data('purchaseprice'));
            $('#CommissionPercentage').val($(this).data('commission'));
            $('#Quantity').val($(this).data('quantity'));
            ProductDialog.open();
        }
    },
        window.EditAssociateButton = {
            css: "mdc-icon-button primary",
            data: {
                Id: "salesPersonId",
                firstName: "firstName",
                lastName: "lastName",
                streetAddress: "streetAddress",
                subAddress: "subAddress",
                manager: "manager",
                city: "city",
                state: "state",
                termination: "termination",
                postalCode: "postalCode",
                phone:"phone"

            },
            //action: "edit",
            dataToUrl: true,
            icon: "fa fa-pen",
            onClick: function (e) {
                $('#SalesPersonId').val($(this).data('id'));
                $('#FirstName').val($(this).data('firstname'));
                $('#LastName').val($(this).data('lastname'));
                $('#Phone').val($(this).data('phone'));
                $('#StreetAddress').val($(this).data('streetaddress'));
                $('#SubAddress').val($(this).data('subaddress'));
                $('#Manager').val($(this).data('manager'));
                $('#City').val($(this).data('city'));
                $('#State').val($(this).data('state'));
                $('#PostalCode').val($(this).data('postalcode'));
                $('#TerminationDate').val($(this).data('termination'));
                AssociateDialog.open();
            }
        }
}