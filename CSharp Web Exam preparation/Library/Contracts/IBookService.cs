using Library.Data;
using Library.Models;
using Library.Services;

namespace Library.Contracts
{
	public interface IBookService
	{
		




		Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync();

	}
}
