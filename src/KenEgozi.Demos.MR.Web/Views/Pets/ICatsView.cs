using Castle.Components.Pagination;
using KenEgozi.Demos.MR.Web.Domain.Entities;

namespace KenEgozi.Demos.MR.Web.Views.Pets
{
	public interface ICatsView : ISiteAwareView
	{
		IPaginatedPage<Cat> Cats { get; set; }
	}
}