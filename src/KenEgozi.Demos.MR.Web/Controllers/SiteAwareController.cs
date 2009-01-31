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

using Castle.Components.DictionaryAdapter;
using Castle.MonoRail.Framework;
using Castle.Tools.CodeGenerator.Services;
using KenEgozi.Demos.MR.Web.SiteMap;
using KenEgozi.Demos.MR.Web.Views;

namespace KenEgozi.Demos.MR.Web.Controllers
{
	/// <summary>
	/// Basic functionality for Code Generator aware controllers
	/// </summary>
	public class SiteAwareController : SmartDispatcherController
	{
		/// <summary>
		/// Will be overridden in generated partial controllers
		/// </summary>
		protected virtual void PerformGeneratedInitialize()
		{
			CodeGeneratorServices.RailsContext = Context;
			CodeGeneratorServices.Controller = this;
			Site = new RootAreaNode(CodeGeneratorServices);
			var view = DictionaryAdapterFactory.GetAdapter<ISiteAwareView>(PropertyBag);
			view.Site = Site;
		}

		/// <summary>
		/// Building typed adapters
		/// </summary>
		public IDictionaryAdapterFactory DictionaryAdapterFactory { get; set; }

		/// <summary>
		/// used for generated partial controllers
		/// </summary>
		public ICodeGeneratorServices CodeGeneratorServices { get; set; }

		/// <summary>
		/// Access the generated Monorail site map
		/// </summary>
		protected RootAreaNode Site { get; set; }

		public override void Initialize()
		{
			base.Initialize();
			PerformGeneratedInitialize();
		}

	}
}