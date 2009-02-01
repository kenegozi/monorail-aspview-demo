<%@ Page Language="C#" %>
<script runat="server" type="aspview/properties">
	bool HideButtons = false;
</script>
<%if (HideButtons == false) { %>
<a href="NewBook.demo">Add a new book</a><br />
<a href="NewDvd.demo">Add a new DVD</a><br />
<%} %>

<form method="get">
	<input type="text" name="q[0]" />
	<input type="text" name="q[1]" />
	<input type="text" name="q[2]" />
	<input type="submit" value="Search" />
</form>

<subview:List></subview:List>
<component:CaptureFor id="InjectedToLayout">
<span style="color:Red">some stuff injected into the layout from the view</span>
</component:CaptureFor>
