using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
	public class Genre
	{
		[Required]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
	}
}
