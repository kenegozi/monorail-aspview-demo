using System.Collections.Generic;
using System.Linq;

using Castle.Components.Validator;

using Newtonsoft.Json;

namespace KenEgozi.Demos.MR.Web.Domain.Entities
{
	public enum Gender
	{
		Male, Female
	}

	public class Cat
	{
		public int Id { get; set; }

		[ValidateNonEmpty]
		public string Name { get; set; }

		[JsonIgnore]
		public Gender Gender { get; set; }

		[JsonProperty("Gender")]
		public string GenderString { get { return Gender.ToString(); } }

		[ValidateRange(1, 20)]
		public int Age { get; set; }

		static Cat[] cats;
		static Cat()
		{
			cats = new Cat[]
			{
				new Cat {Id = 1, Name = "Hooli", Gender = Gender.Male, Age = 5},
				new Cat {Id = 2, Name = "Nina", Gender = Gender.Female, Age = 4},
				new Cat {Id = 3, Name = "Uzi", Gender = Gender.Male, Age = 3},
			};
		}

		public static Cat WithId(int id)
		{
			return cats.Where(c => c.Id == id).FirstOrDefault();
		}
		public static IEnumerable<Cat> All()
		{
			return cats;
		}
	}
}