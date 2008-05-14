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

using System.Collections.Generic;
using System.Linq;
using KenEgozi.Demos.MR.Web.Domain.Entities;

namespace KenEgozi.Demos.MR.Web.Domain.Repository
{
	public class SubscribersRepository
	{
		readonly Dictionary<int, Subscriber> subscribers = new Dictionary<int, Subscriber>{
			{1, new Subscriber{Id=1, Name="Ken"}},
			{2, new Subscriber{Id=2, Name="Lee"}},
			{3, new Subscriber{Id=3, Name="Anthony"}}
		};

		public SubscribersRepository()
		{
			LendablesRepository lendablesRepository = new LendablesRepository();

			subscribers[1].Lendables.Add(lendablesRepository.Load(1));
			subscribers[1].Lendables.Add(lendablesRepository.Load(2));

			subscribers[2].Lendables.Add(lendablesRepository.Load(10));
			subscribers[2].Lendables.Add(lendablesRepository.Load(11));


			subscribers[3].Lendables.Add(lendablesRepository.Load(3));
			subscribers[3].Lendables.Add(lendablesRepository.Load(11));
		}

		public Subscriber[] FindAll()
		{
			return subscribers.Values.ToArray();
		}

		public Subscriber Load(int id)
		{
			return subscribers[id];
		}

	}
}