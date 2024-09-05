using CheckDbApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CheckDbApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CheckController : ControllerBase
	{
		private readonly CheckdbContext _context;
        public CheckController(CheckdbContext context)
        {
			_context = context;
            
        }
		[HttpGet("check-db-connection")]
		public async Task<IActionResult> CheckDbConnection()
		{
			try
			{
				await _context.Database.ExecuteSqlRawAsync("SELECT 1");
				return Ok("Db Connection successful");
			}
			catch (Exception ex)
			{
				return StatusCode(500,$"Db Connection failed: {ex.Message}");
			}
		}
	}
}
