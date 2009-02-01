#region license
// MonoRail - AspView demo
// Copyright 2008 Ken Egozi http://www.kenegozi.com/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using Castle.MonoRail.Framework;
using KenEgozi.Demos.MR.Web.Domain.Entities;
using KenEgozi.Demos.MR.Web.Domain.Repository;

namespace KenEgozi.Demos.MR.Web.Controllers
{
	[Layout("LibrarySharp")]
	public partial class LendablesController : SiteAwareController
	{
		/*
		readonly ILendablesRepository lendablesRepository;
		public LendablesController(ILendablesRepository lendablesRepository)
		{
			this.lendablesRepository = lendablesRepository;
		}
		*/
		public void Index()
		{
			PropertyBag["Lendables"] = new LendablesRepository().FindAll();
		}

		public void Index(string[] q)
		{
			var query = string.Join("", q);
			PropertyBag["Lendables"] = new LendablesRepository().FindAllTitledLike(query);
			if (Request.Headers["X-Requested-With"] != null)
			{
				CancelLayout();
				PropertyBag["HideButtons"] = true;
			}
		}


		public void NewBook()
		{
			MyViews.EditBook.Render();
		}

		public void NewDvd()
		{
			MyViews.EditDvd.Render();
		}

		public void Edit(int id)
		{
			var item = new LendablesRepository().Load(id);
			var type = item.GetType().Name;
			PropertyBag[type] = item;
			RenderView("Edit" + type);
		}

		public void Save([DataBind("book")]Book book)
		{
			if (Validator.IsValid(book) == false)
			{
				Flash["Book"] = book;
				Flash["message"] = string.Join("<br/>",
				                               Validator.GetErrorSummary(book).ErrorMessages);
				MyActions.NewBook().Redirect();
				return;
			}
			new LendablesRepository().Save(book);
			MyActions.Index().Redirect();
		}

		public void Save([DataBind("Dvd")]Dvd dvd)
		{
			if (dvd.Year < 1980)
			{
				Flash["Dvd"] = dvd;
				Flash["message"] = "Cannot add dvds from before 1980";
				MyActions.NewDvd().Redirect();
				return;
			}
			new LendablesRepository().Save(dvd);
			MyActions.Index().Redirect();
		}
		
	}
}