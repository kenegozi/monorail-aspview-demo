using Castle.MonoRail.Framework.Helpers;
using Castle.MonoRail.Views.AspView;

using KenEgozi.Demos.MR.Web.SiteMap;
using KenEgozi.Demos.MR.Web.Views;

/// <summary>
/// Base type for view templates
/// </summary>
/// <typeparam name="T">The view's interface</typeparam>
public abstract class View<T> : AspViewBase<T>
	where T : ISiteAwareView
{
	/// <summary>
	/// An identifier for the current request
	/// </summary>
	protected int RequestId { get { return Context.UnderlyingContext.Request.GetHashCode(); } }

	/// <summary>
	/// Site map
	/// </summary>
	protected RootAreaNode Site
	{
		get { return view.Site; }
	}

	/// <summary>
	/// Adds an entry to the current property bag,
	/// marking the given type for validation helper usage
	/// </summary>
	/// <typeparam name="TValidatedType">The type of the validated entity</typeparam>
	protected void RegisterValidation<TValidatedType>()
	{
		var type = typeof(TValidatedType);
		Context.CurrentControllerContext.PropertyBag.Add(type.Name + "type", type);
	}

	/// <summary>
	/// Creates a key/value dictionary
	/// </summary>
	/// <param name="key">The key</param>
	/// <param name="value">The value</param>
	/// <returns>Case insensitive dictionary</returns>
	protected DictHelper.MonoRailDictionary N(string key, string value)
	{
		return DictHelper.CreateN(key, value);
	}

}
