<%@ Page Language="C#" Inherits="View<ICatView>" %>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Views.Pets"%>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Domain.Entities"%>

<script type="text/javascript" src="~/static/js/jquery/jquery.validate.min.js"></script>

<%RegisterValidation<Cat>(); %>

<form action="/pets/cat.demo" method="post">
		<%=Helpers.Form.HiddenField("Cat.Id") %>
	<label for="name">Name: </label>
		<%=Helpers.Form.TextField("Cat.Name") %><br />
	<label for="gender">Gender: </label>
		<%=Helpers.Form.TextField("Cat.Gender") %><br />
	<label for="age">Age: </label>
		<%=Helpers.Form.TextField("Cat.Age") %><br />
		
	<%=Helpers.Form.Submit("Save") %>
<%=Helpers.Form.EndFormTag() %>
