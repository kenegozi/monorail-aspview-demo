<%@ Page Language="C#" Inherits="View<ICatView>" %>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Views.Pets"%>
<%@ Import Namespace="KenEgozi.Demos.MR.Web.Domain.Entities"%>

		<tr>		
			<td class="name"><%=view.Cat.Name %></td>
			<td class="gender"><%=view.Cat.Gender%></td>
			<td class="age"><%=view.Cat.Age%></td>
			<td><button class="edit" value="<%=view.Cat.Id %>">Edit</button></td>
		</tr>
