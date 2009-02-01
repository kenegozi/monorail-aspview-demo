<%@ Page Language="C#" Inherits="View<ICatsView>" %>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Views.Pets"%>

<table cellpadding="0" cellspacing="0" border="0" id="list">
	<thead>
		<tr>
			<th>Name</th>
			<th>Gender</th>
			<th>Age</th>
		</tr>
	</thead>
	<tbody>
		<%foreach (var cat in view.Cats) {%>
		<tr>		
			<td class="name"><%=cat.Name %></td>
			<td class="gender"><%=cat.Gender %></td>
			<td class="age"><%=cat.Age %></td>
		</tr>
		<%}%>
	</tbody>
	<tfoot>
		<tr>
			<td colspan="3">
				<component:DiggStylePagination page="<%=view.Cats %>"></component:DiggStylePagination>
			</td>
		</tr>
	</tfoot>
</table>
<%if (view.IsAjax == false) {%>
<script type="text/javascript">
	$(document).ready(function() {
		bindPageClicks();
	});

	function bindPageClicks() {
		$('tr a').click(onClick);
	}
	function unbindPageClicks() {
		$('tr a').unbind();
	}

	function onClick() {
		unbindPageClicks();
		$.get(this.href, function(data) {
			$('#list').html(data);
			bindPageClicks();
		});
		return false;
	}
</script>
<%}%>
