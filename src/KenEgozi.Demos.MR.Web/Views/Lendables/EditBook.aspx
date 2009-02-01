<%@ Page Language="C#" Inherits="View<IBookView>" %>
<%@ Import Namespace="StaticSiteMap"%>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Views.Lendables"%>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Domain.Entities"%>

<script type="text/javascript" src="<%=Static.Site.Assets.Scripts.jquery_validate_min_js %>"></script>

<%RegisterValidation<Book>(); %>

<%=Helpers.Form.FormTag("Save.demo", Helpers.Dict.N("method", "post").N("useTitles", "false")) %>
	<div>
		<%=Helpers.Form.LabelFor("Book.Id", "Id:") %>
		<%=Helpers.Form.TextField("Book.Id")%>
		<br />
		<%=Helpers.Form.LabelFor("Book.Title", "Title:")%>
		<%=Helpers.Form.TextField("Book.Title")%>
		<br />
		<%=Helpers.Form.LabelFor("Book.Author", "Author:")%>
		<%=Helpers.Form.TextField("Book.Author")%>
		<br />
		<%=Helpers.Form.LabelFor("Book.Year", "Year")%>
		<%=Helpers.Form.TextField("Book.Year")%>
		<br />
		<input type="submit" value="Save" />
	</div>
<%=Helpers.Form.EndFormTag() %>

<%if (Properties["message"] != null) {%>
There was an error: <%=Properties["message"]%>
<%}%>
