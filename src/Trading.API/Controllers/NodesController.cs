using Common;
using Microsoft.AspNetCore.Mvc;

namespace Trading.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // This sets the URL to be "api/nodes"
    public class NodesController : ControllerBase
    {
        // For now, we will create a hard-coded list of nodes for testing.
        // Later, this data will come from a database.
        private static readonly List<Node> _nodes = new List<Node>
        {
            new Node
            {
                Id = Guid.NewGuid(),
                Name = "RaspberryPi-Alpha",
                Status = "Online",
                AssignedTickers = { "AAPL", "GOOGL" },
                LastHeartbeat = DateTime.UtcNow.AddMinutes(-1)
            },
            new Node
            {
                Id = Guid.NewGuid(),
                Name = "Desktop-Main",
                Status = "Trading",
                AssignedTickers = { "MSFT", "TSLA", "NVDA" },
                LastHeartbeat = DateTime.UtcNow.AddSeconds(-30)
            },
            new Node
            {
                Id = Guid.NewGuid(),
                Name = "Old-Laptop",
                Status = "Offline",
                AssignedTickers = { "AMD" },
                LastHeartbeat = DateTime.UtcNow.AddHours(-5)
            }
        };

        [HttpGet] // This marks the method to run for HTTP GET requests
        public ActionResult<List<Node>> GetNodes()
        {
            return Ok(_nodes); // Returns the list of nodes with a 200 OK status
        }
    }
}