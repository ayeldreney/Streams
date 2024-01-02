﻿namespace Streams.Entites
{
	public class User
	{
		public int Id { get; set; }	
		public string Name { get; set; } = string.Empty;

		public string Email { get; set; } = string.Empty;

		public string Password { get; set; } = string.Empty;	

		public string Address { get; set; } = string.Empty;


		public virtual ICollection<Document> Documents { get; set; } = new HashSet<Document>();


	}
}
