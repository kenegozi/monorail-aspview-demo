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

using KenEgozi.Demos.MR.Web.Domain.Entities;

namespace KenEgozi.Demos.MR.Web.Domain.Repository
{
	public interface ILendablesRepository
	{
		Lendable[] FindAll();
		Lendable[] FindAllTitledLike(string name);
		void Save(Dvd item);
		void Save(Lendable item);
		Lendable Load(int id);
	}
}