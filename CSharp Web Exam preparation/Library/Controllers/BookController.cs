﻿using Library.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
	public class BookController : BaseController
	{
		private readonly IBookService _bookService;

		public BookController(IBookService bookService)
		{
			_bookService = bookService;
		}

		public async Task<IActionResult> All()
		{

			var model = await _bookService.GetAllBooksAsync();
			return View(model);
		}
	}
}
