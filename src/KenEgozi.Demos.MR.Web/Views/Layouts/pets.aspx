<%@ Page Language="C#" Inherits="View<IPetsLayout>" %>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Views.Layouts"%>
<%@ Import Namespace="StaticSiteMap"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
	<title>Monorail Demo - Pets</title>
	<link rel="Stylesheet" href="<%=Static.Site.Assets.Styles.pets_css %>" />
	
	<link rel="Stylesheet" href="<%=Static.Site.Assets.Scripts.ingrid.ingrid_css %>" />

	<script type="text/javascript" src="<%=Static.Site.Assets.Scripts.jquery_1_3_1_min_js %>"></script>
	<script type="text/javascript" src="<%=Static.Site.Assets.Scripts.ingrid.jquery_ingrid_0_9_2_js%>"></script>
	
	<%=view.Scripts %>
	<%=view.Styles %>
</head>
<body>
    <div>
	<%=ViewContents%>
	</div>
</body>
</html>