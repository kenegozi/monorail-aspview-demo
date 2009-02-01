<%@ Page Language="C#" Inherits="Castle.MonoRail.Views.AspView.ViewAtDesignTime" %>
<%@ Import Namespace="StaticSiteMap"%>
<script runat="server" type="aspview/properties">
	string InjectedToLayout = string.Empty;
</script>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
	<title>Monorail Demo - Library</title>
	<link rel="Stylesheet" href="<%=Static.Site.Assets.Styles.default_css %>" />
	<script type="text/javascript" src="<%=Static.Site.Assets.Scripts.jquery_1_3_1_min_js %>"></script>
	<script type="text/javascript">
		$(document).ready(function() {
			$('.book-brief, .dvd-brief').click(function() {
				var id = this.id.replace('item-', '');
				location.href = "edit.demo?id=" + id;
			});
		});
	</script>
</head>
<body>
	<div><h1>Monorail Demo - Library</h1></div>
    <div>
	<%=ViewContents%>
	</div>
	<div><%=InjectedToLayout%></div>
</body>
</html>