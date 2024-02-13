using System.ComponentModel.DataAnnotations;

namespace Batch47.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
	}
}
