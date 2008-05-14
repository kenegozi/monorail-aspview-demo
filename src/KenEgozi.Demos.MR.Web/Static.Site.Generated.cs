
namespace StaticSiteMap
{
	public static class Static
	{
		public static Root Site = new Root();
	}
	public partial class Root 
	{
		public readonly Root_Assets Assets = new Root_Assets();
	}

	public partial class Root_Assets 
	{
		public readonly Root_Assets_Images Images = new Root_Assets_Images();
		public readonly Root_Assets_Scripts Scripts = new Root_Assets_Scripts();
		public readonly Root_Assets_Styles Styles = new Root_Assets_Styles();
	}

	public partial class Root_Assets_Images 
	{
		public readonly string error_jpg = "/Assets/Images/error.jpg";
	}

	public partial class Root_Assets_Scripts 
	{
		public readonly string prototype_1_6_0_2_js = "/Assets/Scripts/prototype-1.6.0.2.js";
		public readonly string validation_js = "/Assets/Scripts/validation.js";
	}

	public partial class Root_Assets_Styles 
	{
		public readonly string default_css = "/Assets/Styles/default.css";
	}

}
