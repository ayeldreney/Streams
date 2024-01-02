namespace Streams.Entites
{
	public class LoginModel
	{
		public int UserId { get; set; }
		public string UserName { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;

		public bool Result { get; set; }

		public string Message { get; set; }	=string.Empty;	








	}
}
