namespace KenEgozi.Demos.MR.Web.Views.Layouts
{
	public interface ISiteAwareLayout : ISiteAwareView
	{
		string Scripts { get; set; }
		string Styles { get; set; }
	}
}