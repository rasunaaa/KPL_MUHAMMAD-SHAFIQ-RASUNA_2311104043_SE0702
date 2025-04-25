using System;
using Microsoft.AspNetCore.Mvc;
using modul9_04043.Models;
using modul9_04043.Moduls;

namespace modul9_04043.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
    {
		private static List<User> users = new List<User>
		{
			new User{id=1, name = "alisa", email="alisa@gamil.com"},
			new User{id=2, name = "bob", email="bob@gamil.com"}
		};

		[HttpGet]
		public ActionResult<List<User>> GetUser()
		{
			return Ok(users);
		}

		[HttpGet("{id}")]
		public ActionResult<User> GetUser(int id)
		{
			var user = users.FirstOrDefault(u => u.id == id);
			if (user == null)
			{
				return NotFound();
			}
			return Ok(user);

		}
        [HttpPost]
        public ActionResult<User> CreateUser(UserDto userCreate)
        {
            int new_id = users.Count + 1;
            User user = new User
            {
                id = new_id,
                name = userCreate.name,
                email = userCreate.email
            };
            users.Add(user);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, UserDto userUpdate)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            user.name = userUpdate.name;
            user.email = userUpdate.email;
            return Ok(user);
        }
    }
}