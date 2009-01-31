using KenEgozi.Demos.MR.Web.SiteMap;

namespace KenEgozi.Demos.MR.Web.Views
{
	public interface ISiteAwareView
	{
		RootAreaNode Site { get; set; }
	}
}