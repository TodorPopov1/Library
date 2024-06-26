﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{

	[Comment("Books for the library")]
	public class Book
	{
		[Comment("Primary Key")]
		[Key]
		public int Id { get; set; }

		[Comment("Title of the book")]
		[Required]
		[MaxLength(50)]
		public string Title { get; set; } = null!;

		[Comment("Author of the book")]
		[Required]
		[MaxLength(50)]
		public string Author { get; set; } = null!;


		[Comment("Discription of the book")]
		[Required]
		[MaxLength(5000)]
		public string Description { get; set; } = null!;

		[Comment("Image URL of the book")]
		[Required]
		public string ImageUrl { get; set; } = null!;

		[Comment("Rating of the book")]
		[Required]
		public decimal Rating { get; set; }

		[Comment("Category of the book")]
		[Required]
		public int CategoryId { get; set; }

		[Comment("Category of the book")]
		[ForeignKey(nameof(CategoryId))]
		public Category Category { get; set; } = null!;
		 
		public List<IdentityUserBook> UsersBooks { get; set; } = new List<IdentityUserBook>();

		
	}
}
