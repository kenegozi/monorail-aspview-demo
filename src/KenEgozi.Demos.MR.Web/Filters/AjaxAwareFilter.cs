using Castle.MonoRail.Framework;

using KenEgozi.Demos.MR.Web.Controllers;

namespace KenEgozi.Demos.MR.Web.Filters
{
	/// <summary>
	/// Will set up 'IsAjax' in the property bag for ajax calls, and cancel the layout
	/// </summary>
	public class AjaxAwareFilter : IFilter
	{
		public bool Perform(ExecuteWhen exec, IEngineContext context, IController controller, IControllerContext controllerContext)
		{
			var isAjax = string.IsNullOrEmpty(context.Request.Headers["X-Requested-With"]) == false;

			if (isAjax)
			{
				((SiteAwareController) controller).CancelLayout();
				((SiteAwareController) controller).IsAjax = true;
			}
	
			controllerContext.PropertyBag["IsAjax"] = isAjax;

			return true;
		}
	}
}