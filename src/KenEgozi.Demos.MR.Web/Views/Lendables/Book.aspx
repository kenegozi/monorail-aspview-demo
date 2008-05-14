<%@ Page Language="C#" %>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Domain.Entities"%>

<script runat="server" type="aspview/properties">
	Book Item;
</script>

<div class="book-brief">
	<h6>Book</h6>
	<h3><%=Item.Title%></h3>
	<h5>By <%=Item.Author%>, from the year <%=Item.Year%></h5>
</div>
