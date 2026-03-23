using APITemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace APITemplate.Controllers;
public class UsersController : BaseApiController
{
    [HttpGet("{id}")]
    public IActionResult GetUser([FromRoute]int id)
    {
        var user = new UserData() { Id = id, Username = "Roe", Email = "roe@example.com" };
            
        return HandleResult(user, "User retrieved successfully.");
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody]UserData user)
    {
        return HandleResult(user, "User created successfully.");
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser([FromRoute]int id, [FromBody] UserData user)
    {
        user.Id = id;
        return HandleResult(user, "User updated successfully.");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser([FromRoute]int id)
    {
        return HandleResult(true, $"User {id} has been deleted.");
    }
}