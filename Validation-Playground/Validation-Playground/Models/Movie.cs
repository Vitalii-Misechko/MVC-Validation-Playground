using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web.Mvc;

namespace Validation_Playground.Models {

	[Bind( Include = "ID,Title,ReleaseDate,Genre,Price" )]
	public class Movie {

		public int ID { get; set; }

		public string Title { get; set; }

		[DisplayName("Release Date")]
		[DisplayFormat( ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}" )]

		public DateTime ReleaseDate { get; set; }

		public string Genre { get; set; }

		public decimal Price { get; set; }

	}

	public class MovieDbContext : DbContext {

		public DbSet<Movie> Movies { get; set; }

	}
}