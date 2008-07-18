<%@ Page Language="C#" Inherits="Castle.MonoRail.Views.AspView.ViewAtDesignTime" %>
<%@ Import Namespace="System.Collections.Generic"%>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Domain.Entities"%>

<script runat="server" type="aspview/properties">
	IEnumerable Lendables;
</script>

<%foreach (Lendable item in Lendables) {%>
<%OutputSubView("/lendables/" + item.GetType().Name, N("Item", item)); %>
<%}%>

