using System.ComponentModel.DataAnnotations;

namespace Batch47.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(20)]
		public string Name { get; set; }

		[Required]
		[Range(1,10)]
		public int DisplayOrder { get; set; }
	}
}
