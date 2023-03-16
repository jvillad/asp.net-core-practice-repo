using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
	public class Book
	{
		[Required]
		public int Id { get; set; }
		[Required]
		public string ISBN { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string Author { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		[DataType(DataType.ImageUrl)]
		public string ImageURL { get; set; }
		[Required]
		[Range(0, 10000)]
		public int Copies { get; set; }
		[Required]
		public string Publisher { get; set; }
		[Required]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0: MMM DD YYYY}")]
		public DateTime PublishedDate { get; set; }
		[Required]
		public int Pages { get; set; }
		[Required]
		public int GenreId { get; set; }
		public Genre Genre { get; set; }
	}
}
