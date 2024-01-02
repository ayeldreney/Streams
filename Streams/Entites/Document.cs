namespace Streams.Entites
{
	public class Document
	{

		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;	

		public string CreatedDate { get; set; } = string.Empty;

		public int Priority { get; set;} 

		public string Due_date { get; set; } = string.Empty;

		public Priorities priorities { get; set; } = null!;
	}
}
