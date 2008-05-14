<%@ Page Language="C#" Inherits="Castle.MonoRail.Views.AspView.ViewAtDesignTime" %>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Domain.Entities"%>
<script runat="server" type="aspview/properties">
	Book Item;
</script>

<%=Helpers.Form.FormTag("Save.demo", Helpers.Dict.N("method", "post").N("useTitles", "false")) %>
	<div>
		<%=Helpers.Form.LabelFor("book.Id", "Id:") %>
		<%=Helpers.Form.TextField("book.Id") %>
		<br />
		<%=Helpers.Form.LabelFor("book.Title", "Title:")%>
		<%=Helpers.Form.TextField("book.Title")%>
		<br />
		<%=Helpers.Form.LabelFor("book.Author", "Author:")%>
		<%=Helpers.Form.TextField("book.Author")%>
		<br />
		<%=Helpers.Form.LabelFor("book.Year", "Year")%>
		<%=Helpers.Form.TextField("book.Year")%>
		<br />
		<input type="submit" value="Save" />
	</div>
<%=Helpers.Form.EndFormTag() %>
