using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
	public class Book
	{
		[Key]
		[Required]
		public string ISBN { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string Author { get; set; }
		[Required]
		[Range(0, 9999)]
		public int Pages { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		[DataType(DataType.ImageUrl)]
		public string ImageFileName { get; set; }
		[Required]
		[Range(0, 9999)]
		public int Copies { get; set; }
		[Required]
		public string Publisher { get; set; }
		[Required]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:DD MMM YYYY}")]
		public DateTime DatePublished { get; set; }
		[Required]
		public string Edition { get; set; }
		[Required]
		public int GenreId { get; set; }
		public Genre Genre { get; set; }
	}
}
