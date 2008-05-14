<%@ Page Language="C#" Inherits="Castle.MonoRail.Views.AspView.ViewAtDesignTime" %>
<%@ Import Namespace="StaticSiteMap"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
	<title>Monorail Demo - Library</title>
	<link rel="Stylesheet" href="<%=Static.Site.Assets.Styles.default_css %>" />
</head>
<body>
    <div>
	<%=ViewContents%>
	</div>
</body>
</html>