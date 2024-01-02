
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streams.Entites
{
	public class User
	{

		[Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserId { get; set; }	
		public string UserName { get; set; } = string.Empty;

		public string Email { get; set; } = string.Empty;

		public string Password { get; set; } = string.Empty;	

		public string Address { get; set; } = string.Empty;


		public virtual ICollection<Document> Documents { get; set; } = new HashSet<Document>();


	}
}
