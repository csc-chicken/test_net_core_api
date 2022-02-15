using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rest_test_remark.Controllers
{
    public class TestController : Controller
    {
        private readonly ILogger<TestController> _logger;
        private readonly IConfiguration _configuration;

        public TestController(ILogger<TestController> logger,
                                  IConfiguration configuration
                                        )
        {
            _configuration = configuration;
            _logger = logger;
        }

        /// <summary>
        /// hello
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <remarks>
        /// **注意**
        /// 亂打這隻者殺無赦
        ///
        ///
        ///
        /// </remarks>
        [HttpGet("Hello")]
        public IActionResult Hello(string userId)
        {
            return Ok();
        }
    }
}