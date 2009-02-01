using System.Collections.Generic;
using Castle.Components.Pagination;
using KenEgozi.Demos.MR.Web.Domain.Entities;

namespace KenEgozi.Demos.MR.Web.Domain.Repository
{
	/// <summary>
	/// Represents the cats DB
	/// </summary>
	public interface ICatsRepository
	{
		/// <summary>
		/// Gets a Cat by it's id
		/// </summary>
		/// <param name="id">The cat's Id</param>
		/// <returns>The cad with id id</returns>
		Cat GetById(int id);

		/// <summary>
		/// Saves a cat instance
		/// </summary>
		/// <param name="cat">The cat instance to save</param>
		void Save(Cat cat);

		/// <summary>
		/// All cats in the DB
		/// </summary>
		/// <returns></returns>
		IEnumerable<Cat> FindAll();

		/// <summary>
		/// All cats, sorted
		/// </summary>
		/// <param name="sortBy"></param>
		/// <param name="sortOrder"></param>
		/// <returns></returns>
		IEnumerable<Cat> FindAll(string sortBy, string sortOrder);

		/// <summary>
		/// All cats, sorted and paged
		/// </summary>
		/// <param name="page"></param>
		/// <param name="pageSize"></param>
		/// <param name="sortBy"></param>
		/// <param name="sortOrder"></param>
		/// <returns></returns>
		IPaginatedPage<Cat> FindAll(int page, int pageSize, string sortBy, string sortOrder);
	}
}