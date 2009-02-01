using Castle.MonoRail.Framework;
using KenEgozi.Demos.MR.Web.Domain.Repository;
using KenEgozi.Demos.MR.Web.Filters;
using KenEgozi.Demos.MR.Web.Views.Pets;
using KenEgozi.Demos.MR.Web.Domain.Entities;

namespace KenEgozi.Demos.MR.Web.Controllers
{
	[Layout("Pets")]
	[Filter(ExecuteWhen.BeforeAction, typeof(AjaxAwareFilter))]
	public partial class PetsController : SiteAwareController
	{
		const int PAGE_SIZE = 3;
		readonly ICatsRepository catsRepository;

		public PetsController(ICatsRepository catsRepository)
		{
			this.catsRepository = catsRepository;
		}

		public void Cats(int page, string orderBy, string sortOrder)
		{
			if (page == 0)
				page = 1;

			var view = Typed<ICatsView>();
			view.Cats = catsRepository.FindAll(page, PAGE_SIZE, orderBy, sortOrder);
		}


		public void CatsGrid()
		{
		}

		[return:JSONReturnBinder]
		public object CatsList(int page, string sidx, string sord, int rows)
		{
			if (page == 0)
				page = 1;

			var cats = catsRepository.FindAll(page, rows, sidx, sord);

			return new 
			{
				page	= page,
				total	= cats.TotalPages,
				records	= cats.TotalItems,
				rows	= cats,
			};
		}

		public void Cat(int id)
		{
			var view = Typed<ICatView>();
			view.Cat = catsRepository.GetById(id);;
			MyViews.EditCat.Render();
		}

		public void Cat([DataBind("Cat")]Cat cat)
		{
			var catToUpdate = catsRepository.GetById(cat.Id);
			catToUpdate.Name = cat.Name;
			catToUpdate.Gender = cat.Gender;
			catToUpdate.Age = cat.Age;
			MyActions.Cat(cat.Id).Redirect();
		}

		public void Cat(int id, string name, Gender gender, int age)
		{
			var cat = catsRepository.GetById(id);
			cat.Name = name;
			cat.Gender = gender;
			cat.Age = age;

			RenderText("OK");

			if (IsAjax == false)
				MyActions.Cat(cat.Id).Redirect();
		}
	}

}