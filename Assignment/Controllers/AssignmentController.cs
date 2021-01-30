using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {

        [HttpGet()]
        public async Task<IActionResult> Get(string startDate, string endDate)
        {
            AssignmentService assignmentService = new AssignmentService();
            var response = await assignmentService.GetResponse(startDate, endDate);

            return this.Ok(response);
        }

    }
}
