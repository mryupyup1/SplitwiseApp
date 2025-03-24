using CreateGroup.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreateGroup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateGroupController : ControllerBase
    {
        private readonly SplitwiseContext _context;

        public CreateGroupController(SplitwiseContext context)
        {
            _context = context;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateGroup([FromBody] CreateGroupRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.GroupName) || request.UserNames == null || !request.UserNames.Any())
            {
                return BadRequest(new { Message = "Invalid group data." });
            }


            var newGroup = new Group
            {
                GroupName = request.GroupName,
                GroupMemberNames = string.Join(", ", request.UserNames) // Convert list to comma-separated string
            };

            _context.Groups.Add(newGroup);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Group created successfully", GroupId = newGroup.GroupId });
        }
    }
}
