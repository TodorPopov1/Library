﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Library.Data.Models
{

	[Comment("Categories for the books")]
	public class Category
	{
		[Comment("Primary key")]
		[Key]
		public int Id { get; set; }

		[Comment("Name of category")]
		[Required]
		[MaxLength(50)]
		public string Name { get; set; } = null!;


		public List<Book> Books { get; set; } = new List<Book>();
	}
}