using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlainInfoController : ControllerBase
    {
        private static ILogger<PlainInfoController> _logger;


        private static readonly string[] Secrets = new[]
        { "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" }; // GitHubの期限切れアクセストークン

        public PlainInfoController(ILogger<PlainInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPlainInfo")]
        public IEnumerable<PlainInfo> Get()
        {
            return Enumerable.Range(1, 3).Select(index => new PlainInfo
            {
                No = index,
                Content = "コンテンツ" + index,
                Created = DateTime.Now.AddDays(index)
            }).ToArray();
        }
    }
}
