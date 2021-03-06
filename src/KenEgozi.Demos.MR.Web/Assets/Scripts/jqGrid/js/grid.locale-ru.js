;(function($){
/**
 * jqGrid Russian Translation
 * Alexey Kanaev softcore@rambler.ru
 * http://softcore.com.ru 
 * Dual licensed under the MIT and GPL licenses:
 * http://www.opensource.org/licenses/mit-license.php
 * http://www.gnu.org/licenses/gpl.html
**/
$.jgrid = {};

$.jgrid.defaults = {
	recordtext: "Записей",
	loadtext: "Загрузка...",
	pgtext : "/"
};
$.jgrid.search = {
    caption: "Поиск...",
    Find: "Найти",
    Reset: "Сброс",
    odata : ['равно', 'не равно', 'меньше', 'меньше или равно','больше','больше или равно', 'начинается с','заканчивается на','содержит' ]
};
$.jgrid.edit = {
    addCaption: "Добавить запись",
    editCaption: "Редактировать запись",
    bSubmit: "Сохранить",
    bCancel: "Отмена",
	bClose: "Закрыть",
    processData: "Обработка...",
    msg: {
        required:"Поле является обязательным",
        number:"Пожалуйста, введите правильное число",
        minValue:"значение должно быть больше либо равно",
        maxValue:"значение должно быть больше либо равно",
        email: "некорректное значение e-mail",
        integer: "Пожалуйста введите целое число",
		date: "Please, enter valid date value"
    }
};
$.jgrid.del = {
    caption: "Удалить",
    msg: "Удалить выделенную запись(и)?",
    bSubmit: "Удвлить",
    bCancel: "Отмена",
    processData: "Обработка..."
};
$.jgrid.nav = {
	edittext: " ",
    edittitle: "Редактировать выделенную запись",
	addtext:" ",
    addtitle: "Добавить новую запись",
    deltext: " ",
    deltitle: "Удалить выделенную запись",
    searchtext: " ",
    searchtitle: "Найти записи",
    refreshtext: "",
    refreshtitle: "Обновить таблицу",
    alertcap: "Внимание",
    alerttext: "Пожалуйста, выделите запись"
};
// setcolumns module
$.jgrid.col ={
    caption: "Показать/скрыть столбцы",
    bSubmit: "Сохранить",
    bCancel: "Отмена"	
};
$.jgrid.errors = {
	errcap : "Ошибка",
	nourl : "URL не установлен",
	norecords: "Нет записей для обработки",
    model : "Length of colNames <> colModel!"
};
$.jgrid.formatter = {
	integer : {thousandsSeparator: " ", defaulValue: 0},
	number : {decimalSeparator:".", thousandsSeparator: " ", decimalPlaces: 2, defaulValue: 0},
	currency : {decimalSeparator:".", thousandsSeparator: " ", decimalPlaces: 2, prefix: "", suffix:"", defaulValue: 0},
	date : {
		dayNames:   [
			"Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat",
			"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
		],
		monthNames: [
			"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec",
			"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
		],
		AmPm : ["am","pm","AM","PM"],
		S: function (j) {return j < 11 || j > 13 ? ['st', 'nd', 'rd', 'th'][Math.min((j - 1) % 10, 3)] : 'th'},
		srcformat: 'Y-m-d',
		newformat: 'd/m/Y',
		masks : {
            ISO8601Long:"Y-m-d H:i:s",
            ISO8601Short:"Y-m-d",
            ShortDate: "n/j/Y",
            LongDate: "l, F d, Y",
            FullDateTime: "l, F d, Y g:i:s A",
            MonthDay: "F d",
            ShortTime: "g:i A",
            LongTime: "g:i:s A",
            SortableDateTime: "Y-m-d\\TH:i:s",
            UniversalSortableDateTime: "Y-m-d H:i:sO",
            YearMonth: "F, Y"
        },
        reformatAfterEdit : false
	},
	baseLinkUrl: '',
	showAction: 'show'
};
})(jQuery);
