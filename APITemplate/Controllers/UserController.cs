using APITemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace APITemplate.Controllers;
public class UsersController : BaseApiController
{
    [HttpGet("{id}")]
    public IActionResult GetUser(int id)
    {
        var user = new UserData() { Id = id, Username = "Roe", Email = "roe@example.com" };
            
        return HandleResult(user, "User retrieved successfully.");
    }
}