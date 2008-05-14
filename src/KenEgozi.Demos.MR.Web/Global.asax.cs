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

using System;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.MonoRail.WindsorExtension;
using Castle.Windsor;
using KenEgozi.Demos.MR.Web.Controllers;
using KenEgozi.Demos.MR.Web.Domain.Repository;

namespace KenEgozi.Demos.MR.Web
{
	/**/
	public class Global : System.Web.HttpApplication
	{
	}
	/**
	public class Global : HttpApplication, IContainerAccessor
	{
		public Global()
		{
			container = new WindsorContainer();
			container.AddFacility("MR", new MonoRailFacility());
			container.Register(
							Component.For<ILendablesRepository>().ImplementedBy<LendablesRepository>().LifeStyle.Singleton,
							Component.For<LendablesController>(),
							Component.For<SubscribersController>()
							);


		}
		readonly IWindsorContainer container;
		public IWindsorContainer Container
		{
			get { return container; }
		}
	}
	/**/
}