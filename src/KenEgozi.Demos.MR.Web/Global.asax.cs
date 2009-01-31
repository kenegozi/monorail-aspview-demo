#region license
// MonoRail - AspView demo
// Copyright 2008-2009 Ken Egozi http://www.kenegozi.com/
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

using System;
using System.IO;
using System.Reflection;
using System.Web;

using Castle.Components.DictionaryAdapter;
using Castle.MicroKernel.Registration;
using Castle.MonoRail.Framework;
using Castle.MonoRail.Framework.Configuration;
using Castle.MonoRail.Framework.Helpers.ValidationStrategy;
using Castle.MonoRail.Framework.Internal;
using Castle.MonoRail.Framework.JSGeneration;
using Castle.MonoRail.Framework.JSGeneration.jQuery;
using Castle.MonoRail.Views.AspView;
using Castle.MonoRail.WindsorExtension;
using Castle.Tools.CodeGenerator.Services;
using Castle.Windsor;
using KenEgozi.Demos.MR.Web.Controllers;
using KenEgozi.Demos.MR.Web.Domain.Repository;

namespace KenEgozi.Demos.MR.Web
{
	/// <summary>
	/// The HttpApplication's declaration
	/// </summary>
	public class Global : HttpApplication, IMonoRailConfigurationEvents, IContainerAccessor
	{
		private static WindsorContainer container;

		/// <summary>
		/// What happens when an application instance starts
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void Application_Start(object sender, EventArgs e)
		{
			container = new WindsorContainer();
			container.AddFacility("MonoRailFacility", new MonoRailFacility());

			RegisterComponents();
		}

		private static void RegisterComponents()
		{
			container.Register(
				AllTypes.Of<Controller>().
					FromAssembly(typeof(HelloController).Assembly),
				AllTypes.Of<IFilter>().
					FromAssembly(typeof(HelloController).Assembly),
				AllTypes.Of<ViewComponent>().FromAssembly(typeof(Global).Assembly)
					.Configure(reg => reg.Named(reg.ServiceType.Name))
			);

			container.Register(
				Component.For<IArgumentConversionService>().ImplementedBy<DefaultArgumentConversionService>().LifeStyle.Transient,
				Component.For<ICodeGeneratorServices>().ImplementedBy<DefaultCodeGeneratorServices>().LifeStyle.Transient,
				Component.For<IControllerReferenceFactory>().ImplementedBy<DefaultControllerReferenceFactory>().LifeStyle.Transient,
				Component.For<IRuntimeInformationService>().ImplementedBy<DefaultRuntimeInformationService>().LifeStyle.Transient);

			container.Register(
				Component.For<IDictionaryAdapterFactory>().ImplementedBy<DictionaryAdapterFactory>().LifeStyle.Transient);

			container.Register(
				Component.For<ILendablesRepository>().ImplementedBy<LendablesRepository>().LifeStyle.Singleton
				);
		}

		public void Configure(IMonoRailConfiguration configuration)
		{
			configuration.ControllersConfig.AddAssembly(Assembly.GetExecutingAssembly());
			configuration.ViewEngineConfig.ViewPathRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views");
			configuration.ViewEngineConfig.ViewEngines.Add(new ViewEngineInfo(typeof(AspViewEngine), false));

			configuration.JSGeneratorConfiguration
				.AddLibrary("jquery-1.2.1", typeof(JQueryGenerator))
					.AddExtension(typeof(CommonJSExtension)).ElementGenerator
					.AddExtension(typeof(JQueryElementGenerator))
					.Done
				.BrowserValidatorIs(typeof(JQueryValidator))
				.SetAsDefault();
		}

		/// <summary>
		/// The Windsor container
		/// </summary>
		public IWindsorContainer Container
		{
			get { return container; }
		}

	}
}