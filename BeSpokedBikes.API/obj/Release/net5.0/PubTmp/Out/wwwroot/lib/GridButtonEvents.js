
function OnKMSClick(e, args, successCallback) {
    if (e !== undefined) {
        var url = $(e).data('url');

        if (url !== undefined) {
            if (args.openInNewTab) {
                if (args.errorModal !== undefined) {
					$.sendData(url, null, function (response) {
						console.log(response);
						if (!(args.OpenOnSuccess === false && response.success === true))
							window.open(response, '_blank');

                        if (args.list !== undefined && args.list === true) {
                            var list = $(e).closest('.jsgrid');
                            $(list).jsGrid("loadData");
                        }
                    }, function (response) {
                        $(args.errorModal).modal('show');
                        $(args.errorModal).find('.modal-body').empty().html(response.message);
                    }, function (response) {
                        $(args.errorModal).modal('show');
                        $(args.errorModal).find('.modal-body').empty().text(response.message);
                    });

                }
                else {
                    window.open(url, '_blank');
                    if (args.list !== undefined && args.list === true) {
                        var list = $(e).closest('.jsgrid');
                        $(list).jsGrid("loadData");
                    }
                }

            }
            else if (args.openInNewWindow) {
                window.open(url, args.windowTitle, args.windowStyle);
            }
            else {
                if (args.errorModal !== undefined) {
                    $.sendData(url, function (response) {
                        $(args.errorModal).modal('show');
                        $(args.errorModal).find('.modal-body').empty().html(response);
                    }, function (response) {
                        $(args.errorModal).modal('show');
                        $(args.errorModal).find('.modal-body').empty().html(response.message);
                    }, function (response) {
                        $(args.errorModal).modal('show');
                        $(args.errorModal).find('.modal-body').empty().text(response.message);

                    });
                }
                if (args.list !== undefined && args.list === true) {
                    var list = $(e).closest('.jsgrid');
                    $(list).jsGrid("loadData");
                }
                if (args.modal !== undefined) {
                    $.sendData(url, {}, function (response) {
                        console.log(response);
                        $(args.modal).find('.modal-body').empty().html(response);
                        $(args.modal).modal('show');
                    });
                }
                if (args.alertText !== undefined) {
                    if (!confirm(args.alertText)) {
                        return false;
                    }

                    $.sendData(url, {},
                        function (response) {
                            if (args.list !== undefined && args.list === true) {
                                var list = $(e).closest('.jsgrid');
                                $(list).jsGrid("loadData");
                            }

                            if (typeof successCallback === 'function') {
                                successCallback(response)
                            }
                        }
                        , function (response) {
                            console.log(response)
                        }, function (response) {
                            if (args.list !== undefined && args.list === true) {
                                var list = $(e).closest('.jsgrid');
                                $(list).jsGrid("loadData");
                            }
                        });
                }
            }

        }
    }

}

function invoiceClick(e) {
    e.preventDefault();

    var url = $(e.target).data('url');

    window.location = url;
}
function productInvoiceClick(e) {
    e.preventDefault();

    var url = $(e.target).data('url');

    $.sendData(url);
}

