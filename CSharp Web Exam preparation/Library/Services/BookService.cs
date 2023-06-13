using Library.Contracts;
using Library.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
	public class BookService : IBookService
	{

		private readonly LibraryDbContext dbContext;

		public BookService(LibraryDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync()
		{
			return await dbContext
			.Books
			.Select(x => new AllBookViewModel
			{
				Id = x.Id,
				Title = x.Title,
				Author = x.Author,
				ImageUrl = x.ImageUrl,
				Rating = x.Rating,
				Category = x.Category.Name
			})
			.ToListAsync();
		}
	}
}
