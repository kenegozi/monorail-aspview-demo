<%@ Page Language="C#" %>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Domain.Entities"%>

<script runat="server" type="aspview/properties">
	Dvd Item;
</script>

<div class="dvd-brief">
	<h6>Dvd</h6>
	<h3><%=Item.Title%></h3>
	<h5>Directed by <%=Item.Director%>, at the year <%=Item.Year%></h5>
	<p>
		Famous actors are: <%=string.Join(", ", Item.Actors)%>
	</p>
</div>
