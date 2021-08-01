var pageCount = 0;
var distRuns;
var rowCount;
window.field = '';
window.order = '';

function FormatUrl(url, data, item) {
    if (data !== undefined) {
        const keys = Object.keys(data);

        if (keys.length !== 0) url = url + '?';

        for (let i = 0; i < keys.length; i++) {
            const value = item[data[keys[i]]];
            if (value !== undefined) {
                if (i === 0) url = url + keys[i] + '=' + value;
                else url = url + '&' + keys[i] + '=' + value;
            } else {
                if (i === 0) url = url + keys[i] + '=' + data[keys[i]];
                else url = url + '&' + keys[i] + '=' + data[keys[i]];
            }

        };
    }

    return url;
}

function ResizeColumns() {
    $('.jsGrid .jsgrid-grid-body > .jsgrid-table > tbody > tr').each(function () {
        const cols = $(this).find('.jsgrid-cell');
        cols.each(function (i, col) { $(col).css('width', GetHeaderWidth(i)); });

        const lastColWidth = $('.jsgrid-grid-header >.jsgrid-table > tr').find('td:last-of-type').width();
        $(this).find('td:last-of-type').css('width', (lastColWidth + (7.5 * 2) + 1));
    });
}

window.onresize = function () { ResizeColumns(); };

function GetHeaderWidth(index) { return ($('.jsGrid .jsgrid-grid-header >.jsgrid-table > tr').find('td').eq(index).outerWidth()); }

var ButtonGroup = function (config) {
    this.buttons = undefined;
    InitializeButtons();
    jsGrid.Field.call(this, config);
};

var Text = function (config) {
    this.condition = undefined;
    this.url = '';
    this.field = '';
    jsGrid.Field.call(this, config);
};

ButtonGroup.prototype = new jsGrid.Field({
    buttons: new Array(),
    sorting: false,
    headerTemplate: function () {
        if (this._grid.headerButton !== undefined) {
            this.headerButton = this._grid.headerButton;
            if (this.headerButton.onClick) {
                const button = RenderHeaderButton(this.headerButton);
                if (this._grid.canEdit() === false && this._grid.rowButtonDisabledTooltip) button.prop('disabled', 'true');

                return button;
            }
            const result = ` <span data-target="#${this.headerButton.modalTarget}" data-toggle="modal"> <button type="button" class="${this.headerButton.css}" data-url="${this.headerButton.url}" data-tool="tooltip" data-placement="bottom" title="${this.headerButton.tooltipText}"> <span class="fal ${this.headerButton.icon}"></span> </button> </span>`;
        } else return '';
    },
    itemTemplate: function (value, item) {
        const div = $('<div>').addClass('ui icon buttons');

        if (this._grid.rowButtons !== undefined) this.buttons = this._grid.rowButtons;

        for (i = 0; i < this.buttons.length; i++) {
            const button = Render(this.buttons[i], item, this._grid, div);

            if (this.buttons[i].modalTarget !== undefined) {
                button.attr('data-target', `#${this.buttons[i].modalTarget}`);
                button.attr('data-toggle', 'modal');
            }

            if (this._grid.canEdit() === false && this._grid.rowButtonDisabledTooltip) button.prop('disabled', 'true');

            if (button !== undefined) div.append(button);
        }
        if (this._grid.canEdit() !== undefined && this._grid.canEdit() === false && this._grid.rowButtonDisabledTooltip) {
            div.css('opacity', '.5');

            if (this._grid.rowButtonDisabledTooltip) {

            }
        }

        return div;
    }
});

Text.prototype = new jsGrid.Field({
    conditions: undefined,
    url: '',
    field: '',
    headerTemplate: function () { return `<span data-name="${this.name}">${this.title}</span>`; },
    itemTemplate: function (value, item) {
        var result = $('<div/>');
        var alreadyAppliedValue = false;
        var valueWrapper;
        if (this.conditions !== undefined) {

            var isTrue = false;
            var hasTrueCondition = false;
            var iconConditions = Array.from(this.conditions.filter(x => x.type === 'icon' && x.func(value, item) === true));
            var cssConditions = Array.from(this.conditions.filter(x => x.type === 'css' && x.func(value, item) === true));
            var otherConditions = Array.from(this.conditions.filter(x => x.type !== 'css' && x.type !== 'icon' && x.func(value, item) === true));
            iconConditions.forEach(x => {
                var displayName = x.tooltipDisplay;
                var fieldName = x.field;
                var neutral = x.neutral;
                var cssPropertyToggle = x.cssPropertyToggle;
                if (displayName !== undefined) {
                    var cont;

                    if (!neutral) {
                        cont = $('<div/>').addClass('pull-right alert-tt').attr({
                            'data-tool': 'tooltip',
                            'data-placement': 'bottom',
                            'title': displayName + item[fieldName]
                        });
                    } else {
                        cont = $('<div/>').addClass('pull-right neutral-tt').attr({
                            'data-tool': 'tooltip',
                            'data-placement': 'bottom',
                            'title': displayName + item[fieldName]
                        });
                    }

                    result = result.append(cont);

                    valueWrapper = $('<span/>').text(value);

                    cont = this.CreateIcon(item, x, cont);

                    result.append(cont);

                    if (this.url !== undefined && this.data !== undefined) {

                        url = FormatUrl(this.url, this.data, item);

                        valueWrapper = $('<a/>').attr('href', url).text(value);
                    }

                    if (valueWrapper !== undefined && !alreadyAppliedValue) {
                        result.prepend(valueWrapper);
                        alreadyAppliedValue = true;
                    }
                } else if (cssPropertyToggle !== undefined) {
                    var cssValue = x.cssPropertyTrue;
                    result = $('<span/>');

                    result.append(value);

                    result.style(cssPropertyToggle, cssValue, 'important');

                }
            });
            cssConditions.forEach(x => {
                var cssPropertyToggle = x.cssPropertyToggle;

                var cssValue = x.cssPropertyTrue;

                result = $('<span/>');

                result.append(value);

                result.style(cssPropertyToggle, cssValue, 'important');
            });
            otherConditions.forEach(x => {
                    var displayName = x.tooltipDisplay;
                    var fieldName = x.field;
                    var neutral = x.neutral;
                    var cssPropertyToggle = x.cssPropertyToggle;

                    if (isTrue) {
                        hasTrueCondition = true;
                        if (displayName !== undefined) {

                        } else if (cssPropertyToggle !== undefined) {
                            var cssValue = x.cssPropertyTrue;
                            result = $('<span/>');

                            result.append(value);

                            result.style(cssPropertyToggle, cssValue, 'important');

                        }
                    } else {
                        let noLink = (x.NoLink === true || x.NoLink === undefined);
                        if (noLink && !hasTrueCondition && !alreadyAppliedValue) result = $('</span>').append(value);
                        else if (cssPropertyToggle !== undefined) {
                            var cssValue = x.cssPropertyFalse;

                            var result = $('<span/>');

                            result.append(value);

                            result.style(cssPropertyToggle, cssValue, 'important');

                        }
                    }
                }
            );

            if (result === undefined && valueWrapper !== undefined) return $('</div>').prepend(valueWrapper);
            else if (this.url !== undefined && this.data !== undefined && (!valueWrapper || valueWrapper.prop("nodeName") !== "A")) {
                url = FormatUrl(this.url, this.data, item);

                return `<a href="${url}">${value}</a>`;

            } else if (valueWrapper === undefined) return result.html(value);
            else return result;
        } else if (this.url !== undefined && this.data !== undefined) {
            url = FormatUrl(this.url, this.data, item);

            var valueWrapper = $(`<a href="${url}">${value}</a>`);

            Object.keys(this.data).forEach((x, i) => $(valueWrapper).data(x, item[this.data[x]]));

            if (this.onClick !== undefined) valueWrapper.off('click').on('click', this.onClick.bind(valueWrapper));

            return valueWrapper;
        } else return value;
    },
    editTemplate: function (value) { return this._grid._editText = $("<input type='text'>").val(value); },
    editValue: function () { return this._grid._editText.val(); }

});

function ToggleOrder(item, currentClass, newClass) {
    $(item).removeClass(currentClass);
    $(item).addClass(newClass);
}

function HandleSort(e, item) {
    var tempOrder;
    const tempField = $(item).find('span').data('name');

    if (field === tempField) {
        if (order === 'asc') {
            if (e.type === 'mouseover') ToggleOrder(item, 'kms-header-sort-asc', 'kms-header-sort-desc');
            else if (e.type === 'mouseleave') ToggleOrder(item, 'kms-header-sort-desc', 'kms-header-sort-asc');
            else if (e.type === 'click') {
                ToggleOrder(item, 'kms-header-sort-asc', 'kms-header-sort-desc');
                field = $(item).find('span').data('name');
                order = 'desc';
            }
        } else if (order === 'desc') {
            if (e.type === 'mouseover') ToggleOrder(item, 'kms-header-sort-desc', 'kms-header-sort-asc');
            else if (e.type === 'mouseleave') ToggleOrder(item, 'kms-header-sort-asc', 'kms-header-sort-desc');
            if (e.type === 'click') {
                ToggleOrder(item, 'kms-header-sort-desc', 'kms-header-sort-asc');
                field = $(item).find('span').data('name');
                order = 'asc';
            }
        }
    } else {
        if (e.type === 'mouseover') $(item).addClass('kms-header-sort-asc');
        else if (e.type === 'mouseleave') $(item).removeClass('kms-header-sort-asc');
        else if (e.type === 'click') {
            $('.kms-header-sort-asc').removeClass('kms-header-sort-asc ');
            $('.kms-header-sort-desc').removeClass('kms-header-sort-desc ');
            $('.kms-header-sort').removeClass('kms-header-sort');

            $(item).addClass('kms-header-sort');
            $(item).addClass('kms-header-sort-asc');

            field = $(item).find('span').data('name');
            order = 'asc';
        }

    }
    //if (e.type === 'click' && $(item).hasClass('kms-header-sort') === false) $(item).addClass('kms-header-sort')
}

jsGrid.fields.Text = Text;
jsGrid.fields.ButtonGroup = ButtonGroup;
window.searching = false;

(function (window, $) {
    $.fn.grid = function (config) {
        var grid = this;
        $('#search-btn').off('click');

        function Search() { if (config.search === true) grid.jsGrid('search'); }

        $('#search-btn').click(function () {
            if (config.search === true && window.searching === false) {
                Search();
                window.searching = true;
            }
        });

        $('#search-text, #search-text-2').keypress(function (e) { if (e.which === 13) Search(); });

        $('#Date').keydown(function (e) {
            if (e.which === 13) {
                let str = $('#Date').val().trim();

                while (str.includes('-')) str = str.replace('-', '/');

                const dat = Date.parse(str);
                if (!isNaN(dat) || str === '') Search();
            }
        });

        if (config.rowButtons !== undefined || config.headerButton) config.fields.push({ type: 'ButtonGroup', align: 'right', css: 'row-options', headercss: 'header-row-options' });

        if (config.editing) {
            config.editFields = [];
            for (var i = 0; i < config.fields.length; i++) if (config.fields[i].edit) config.editFields.push(config.fields[i].name);
        }
        this.jsGrid({
            height: 'auto',
            width: '100%',
            autoload: config.autoload != undefined ? config.autoload : true,
            filtering: config.filtering,
            editing: config.editing,
            inserting: config.inserting,
            sorting: config.sorting,
            paging: true,
            pageLoading: true,
            pageSize: (config.pageSize === undefined) ? 50 : config.pageSize,
            pageButtonCount: 5,
            updateOnResize: true,
            fields: config.fields,
            rowButtons: config.rowButtons,
            headerButton: config.headerButton,
            initialSortField: config.initialSortField,
            loadIndication: false,
            loadIndicationDelay: 100,
            loadShading: true,
            rowClick:config.rowClick,
            heading: config.heading,
            loadMessage: '',
            condensed: config.condensed,
            customClick: config.customClick,
            find: config.find,
            editFields: config.editFields,
            rowButtonDisabledTooltip: config.rowButtonDisabledTooltip,
            rowButtonDisabledTarget: config.rowButtonDisabledTarget,
            onItemUpdating: config.onItemUpdating ? config.onItemUpdating : $.noop,
            onDataLoaded: config.onDataLoaded ? config.onDataLoaded : $.noop,
            canEdit: config.canEdit ? config.canEdit : $.noop,
            data: config.data,

            controller: {
                loadData: function (filter) {
                    return axios({
                        method: 'get',
                        url: config.loadUrl
                    })
                        .then(function (response) {
                            config.data = response.data;
                           
                            return response.data;
                        })
                        .catch(function (error) {
                            console.log(error);
                            config.search = true;
                            window.searching = false;
                        });
                }
            },
            //onRendered: function(){
            //    var iconButtons = window.document.querySelectorAll('.mdc-icon-button');

            //    for (i = 0; i < iconButtons.length; i++) {
            //        mdc.ripple.MDCRipple.attachTo(iconButtons[i]).unbounded = true;
            //    }
            //},
            onDataLoaded: function (grid, data) {
                const iconButtons = window.document.querySelectorAll('.mdc-icon-button');

                for (i = 0; i < iconButtons.length; i++) mdc.ripple.MDCRipple.attachTo(iconButtons[i]).unbounded = true;

            },
            onDataLoading: function (args) {

            },
            pagerRenderer: function (item) {
                const index = item.pageIndex;
                pageCount = item.pageCount;
                var colWidth = 'col-sm-offset-3 col-sm-6';

                if (grid.jsGrid('option', 'condensed') === true) colWidth = 'col-sm-12';

                const format = `<div class="jsgrid-pager row">   <div id="pager-col" class="${colWidth
                    }">   <div class="ui four inline fields">       <div class="pager-buttons field">           <button type="button" class="mdc-button primary page-first"><i class="fa fa-lg fa-fast-backward" ></i ></button >           <button type="button" class="mdc-button primary page-prev"><i class="fa fa-lg fa-backward" ></i ></button></div>       <input type="number" id="current-page" class="form-control form-material field current-page" name="currentPage" min="1" max="${pageCount
                    }" value="${index
                    }" style="margin-bottom:0px" />		of       <input style="margin-bottom:0px" type="text" id="page-count" class="form-control form-material field right page-count" name="pageCount" readonly value="${pageCount
                    }" />       <div class="pager-buttons field">           <button type="button" class="mdc-button primary page-next"><i class="fa fa-lg fa-forward" ></i ></button>           <button type="button" class="mdc-button primary page-last"><i class="fa fa-lg fa-fast-forward" ></i ></button>       </div>   </div ></div></div>`;

                return format;
            },
            onRefreshed: function (item) {
                //var test = grid.attr('id');
                ResizeColumns();


                //                 mdc.ripple.MDCRipple.attachTo($('.mdc-icon-button')[0]).unbounded = true;

            }
        });
    };
}(window, jQuery));