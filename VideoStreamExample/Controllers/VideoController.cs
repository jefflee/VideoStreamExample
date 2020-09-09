using Microsoft.AspNetCore.Mvc;

namespace VideoStreamExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        [HttpGet("movie", Name = "Get a movie")]
        public FileResult GetTestMovie()
        {
            return PhysicalFile($"D:\\documents\\temp\\test2.mp4", "application/octet-stream",
                enableRangeProcessing: true);
        }
    }
}
