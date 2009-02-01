using System;
using System.Collections.Generic;
using System.Linq;
using Castle.Components.Pagination;
using KenEgozi.Demos.MR.Web.Domain.Entities;

namespace KenEgozi.Demos.MR.Web.Domain.Repository
{
	/// <summary>
	/// A faked DB for cats
	/// </summary>
	public class CatsRepository : ICatsRepository
	{
		/// <summary>
		/// A new CatsRepository
		/// </summary>
		public CatsRepository()
		{
			cats = new Cat[]
			{
				new Cat {Id = 1, Name = "Hooli", Gender = Gender.Male, Age = 5},
				new Cat {Id = 2, Name = "Nina", Gender = Gender.Female, Age = 4},
				new Cat {Id = 3, Name = "Uzi", Gender = Gender.Male, Age = 3},
				new Cat {Id = 4, Name = "Batya", Gender = Gender.Female, Age = 5},
				new Cat {Id = 5, Name = "Imale", Gender = Gender.Female, Age = 5},
				new Cat {Id = 6, Name = "Trickey", Gender = Gender.Female, Age = 3},
				new Cat {Id = 7, Name = "Pretty", Gender = Gender.Female, Age = 3},
				new Cat {Id = 8, Name = "Geoffrey", Gender = Gender.Male, Age = 4},
				new Cat {Id = 9, Name = "Gingi", Gender = Gender.Male, Age = 1},
				new Cat {Id = 10, Name = "Tinofet", Gender = Gender.Male, Age = 2},
				new Cat {Id = 11, Name = "Namnam", Gender = Gender.Male, Age = 10},
				new Cat {Id = 12, Name = "Patch", Gender = Gender.Male, Age = 3},
				new Cat {Id = 13, Name = "Cupidon", Gender = Gender.Male, Age = 15},
				new Cat {Id = 14, Name = "Hardali", Gender = Gender.Male, Age = 7},
				new Cat {Id = 15, Name = "Tsion", Gender = Gender.Male, Age = 10},
				new Cat {Id = 16, Name = "Moshe", Gender = Gender.Male, Age = 7},
				new Cat {Id = 17, Name = "Levana", Gender = Gender.Male, Age = 2},
			};
		}


		public Cat GetById(int id)
		{
			return cats.Where(c => c.Id == id).FirstOrDefault();
		}

		public IEnumerable<Cat> FindAll()
		{
			return cats;
		}

		public IEnumerable<Cat> FindAll(string sortBy, string sortOrder)
		{
			if (string.IsNullOrEmpty(sortBy))
				return cats;

			return sortOrder == "desc"
					? cats.OrderByDescending(orderOptions[sortBy.ToLower()])
					: cats.OrderBy(orderOptions[sortBy.ToLower()]);
		}
        

		public IPaginatedPage<Cat> FindAll(int page, int pageSize, string sortBy, string sortOrder)
		{
			var skip = (page - 1) * pageSize;
			var catsToTake =
				FindAll(sortBy, sortOrder)
				.Skip(skip)
				.Take(pageSize);

			return new GenericCustomPage<Cat>(
				catsToTake, page, pageSize, cats.Length);
		}

		public void Save(Cat cat)
		{
			throw new NotImplementedException();
		}

		readonly Cat[] cats;
		readonly Dictionary<string, Func<Cat, object>> orderOptions = new Dictionary<string, Func<Cat, object>>
		{
			{"id", (c => c.Id)},
			{"name", (c => c.Name)},
			{"gender", (c => c.Gender)},
			{"age", (c => c.Age)},
		};
	}
}