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
using System.Linq;
using System.Collections.Generic;
using KenEgozi.Demos.MR.Web.Domain.Entities;

namespace KenEgozi.Demos.MR.Web.Domain.Repository
{
	public class LendablesRepository : ILendablesRepository
	{
		static readonly Dictionary<int, Lendable> lendables = new Dictionary<int, Lendable>{
			{1, new Book { Id=1, Author = "Stephan King", Title = "The Gunslinger", Year = 1978 }},
			{2, new Book { Id=2, Author = "Charles Dickens", Title = "A Christmas Carol", Year = 1843 }},
			{3, new Book { Id=3, Author = "Jeremy Clarkson", Title = "The World According to Clarkson", Year = 2005 }},
			{4, new Dvd { Id=4, Title = "Fight Club", Director = "David Fincher", Year = 1999, Actors= new[] {"Edward Norton", "Brad Pitt"} } },
			{5, new Dvd { Id=5, Title = "Mr. Deeds", Director = "Steven Brill", Year = 2002, Actors= new[] {"Adam Sandler", "John Turturro"} } },
			{6, new Dvd { Id=6, Title = "Blade Runner", Director = "Ridley Scott", Year = 1982, Actors= new[] {"Harrison Ford", "Rutger Hauer"} } },
			{7, new Dvd { Id=7, Title = "In Bruges", Director = "Martin McDonagh", Year = 2008, Actors= new[] {"Colin Farrell", "Brendan Gleeson"} } }
		};

		public Lendable[] FindAll()
		{
			return
				lendables.Values
				.ToArray();
		}

		public Lendable[] FindAllTitledLike(string name)
		{
			return
				lendables.Values
				.Where(l=>l.Title.IndexOf(name, StringComparison.InvariantCultureIgnoreCase) > -1)
				.ToArray();
		}

		public void Save(Dvd item)
		{
			item.RemoveNullActors();
			Save((Lendable)item);
		}

		public void Save(Lendable item)
		{
			if (item.Id == default(int))
			{
				item.Id = FindAll().Max(i => i.Id) + 1;
				lendables.Add(item.Id, item);
			}
			else
			{
				lendables[item.Id] = item;
			}
		}

		public Lendable Load(int id)
		{
			if (lendables.ContainsKey(id))
				return lendables[id];

			throw new Exception(string.Format("Cannot find Landable#{0}", id));
		}
	}
}