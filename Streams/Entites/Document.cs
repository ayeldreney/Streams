using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streams.Entites
{
	public class Document
	{
		[Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int DocumentId { get; set; }

		public string Name { get; set; } = string.Empty;	

		public string CreatedDate { get; set; } = string.Empty;

		public int Priority { get; set;} 

		public string Due_date { get; set; } = string.Empty;

		public Priorities priorities { get; set; } = null!;
	}
}
