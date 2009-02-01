using KenEgozi.Demos.MR.Web.Domain.Entities;

namespace KenEgozi.Demos.MR.Web.Views.Pets
{
	public interface ICatView : ISiteAwareView
	{
		Cat Cat { get; set; }
	}
}