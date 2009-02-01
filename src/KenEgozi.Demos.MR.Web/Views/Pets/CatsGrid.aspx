<%@ Page Language="C#" Inherits="View<ICatsView>" %>

<%@ Import Namespace="StaticSiteMap" %>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Views.Pets" %>
<table id="list2" class="scroll" cellpadding="0" cellspacing="0">
</table>
<div id="pager2" class="scroll" style="text-align: center;">
</div>
<button id="save">
	Save</button>
<link rel="stylesheet" type="text/css" media="screen" href="/assets/scripts/jqgrid/themes/steel/grid.css" />

<script src="<%=Static.Site.Assets.Scripts.jqGrid.jquery_jqGrid_js %>"></script>

<script src="<%=Static.Site.Assets.Scripts.jqGrid.js.jqDnR_js%>"></script>

<script type="text/javascript">
	var lastsel;
	$(document).ready(function() {
		$('#save').click(function() {
			$('#list2').saveRow(lastsel);
			$(this).hide();
		});
		$('#save').hide();
		$("#list2").jqGrid({
			url: 'catslist.demo',
			editurl: 'cat.demo',
			datatype: "json",
			colNames: ['Id', 'Name', 'Gender', 'Age'],
			colModel: [
			{ name: 'Id', index: 'Id', key: true, hidden: true },
			{ name: 'Name', index: 'Name', width: 250, editable: true },
			{ name: 'Gender', index: 'Gender', width: 150, editable: true, edittype: 'select', editoptions: { value: "Male:Male;Female:Female"} },
			{ name: 'Age', index: 'Age', width: 80, editable: true }
		],
			rowNum: 5,
			rowList: [2, 5, 10],
			imgpath: '/assets/scripts/jqgrid/themes/steel/images',
			pager: $('#pager2'),
			sortname: 'Id',
			viewrecords: true,
			caption: "Cats",
			jsonReader: {
				root: "rows",
				page: "page",
				total: "total",
				records: "records",
				cell: "",
				id: "0",
				repeatitems: false
			},
			onSelectRow: function(id) {
				if (id && id !== lastsel) {
					$('#list2').restoreRow(lastsel);
					$('#list2').editRow(id, true);
					lastsel = id;
					$('#save').show();
				}
			}
		}).navGrid('#pager2', {
			edit: false,
			add: false,
			del: false
		});

	});
</script>

