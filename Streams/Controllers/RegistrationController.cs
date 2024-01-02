
using Microsoft.AspNetCore.Mvc;
using Streams.Data.Context;
using Streams.Entites;

namespace Streams.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RegistrationController : ControllerBase
	{

		private readonly StreamContext _streamContext;

        public RegistrationController(StreamContext streamContext)
        {
            _streamContext = streamContext;	
        }


        [HttpPost]
		[Route("Register")]
		[ProducesResponseType(201)]
		[ProducesResponseType(400)]
		[ProducesResponseType(500)]

		public User AddUser(User user) { 
		
			_streamContext.Users.Add(user);		
			_streamContext.SaveChanges();	
		
			return user;	

		}



		[HttpPost]
		[Route("Login")]
		[ProducesResponseType(201)]
		[ProducesResponseType(400)]
		[ProducesResponseType(500)]

		public LoginModel Login(LoginModel loginModel)
		{

			var isUserExist = _streamContext.Users.SingleOrDefault(u => u.UserName == loginModel.UserName && u.Password==loginModel.Password);

			if (isUserExist != null)
			{
				loginModel.UserId = isUserExist.UserId;
				loginModel.Result = true;
				loginModel.Message = "Login Success";
			}
			else {
				loginModel.Result= false;	
				loginModel.Message = "Login Failed";

			
			}
			return loginModel;	

		}









	}
}
