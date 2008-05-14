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

namespace KenEgozi.Demos.MR.Web.Domain.Entities
{
	public class Subscriber
	{
		public int Id { get; set; }
		public string Name { get; set; }

		readonly List<Lendable> lendables = new List<Lendable>();
		public List<Lendable> Lendables { get { return lendables; } }

	}
}