export function imageSelectSetup(dotNetHelper, id, jsonConfig) {
    MsDropdown.make('#' + id, {
        byJson: {
            data: null, selectedIndex: 0, name: null,
            size: 0, multiple: false, width: 250
        },
        mainCss: jsonConfig.mainCss,
        rowHeight: null,
        visibleRows: null,
        showIcon: true,
        zIndex: jsonConfig.zIndex,
        event: jsonConfig.event,
        style: '',
        childWidth: null,
        childHeight: null,
        enableCheckbox: false,
        checkboxNameSuffix: jsonConfig.checkboxNameSuffix,
        showPlusItemCounter: true,
        enableAutoFilter: true,
        showListCounter: false,
        errorMessage: 'Please select an item from this list',
        on: {
            create: null,
            open: null,
            close: null,
            add: null,
            remove: null,
            change: onChange,
            blur: null,
            click: null,
            dblclick: null,
            mousemove: null,
            mouseover: null,
            mouseout: null,
            focus: null,
            mousedown: null,
            mouseup: null
        }
    });

    function onChange() {
        let ddSelect = document.getElementById(id).msDropdown;
        let selected = ddSelect.selectedIndex;
        let selectedValue = ddSelect.value;

        dotNetHelper.invokeMethodAsync('OnSelectedIndexChange', selected);
        dotNetHelper.invokeMethodAsync('OnSelectedValueChange', selectedValue);
    }
}