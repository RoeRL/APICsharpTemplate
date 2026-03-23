using APITemplate.Wrapper;
using Microsoft.AspNetCore.Mvc;

namespace APITemplate.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    protected IActionResult HandleResult<T>(T data, string message = null)
    {
        if (data == null) 
        {
            return NotFound(new ApiResponse<T> 
            { 
                Success = false, 
                Message = "Resource not found." 
            });
        }

        return Ok(new ApiResponse<T>(data, message));
    }
}