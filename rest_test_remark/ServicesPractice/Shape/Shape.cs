using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rest_test_remark
{
    public class Shape : IShape
    {
        private readonly ILogger<Shape> _logger;
        private readonly IConfiguration _configuration;

        public Shape(ILogger<Shape> logger,
                                  IConfiguration configuration
                                        )
        {
            _configuration = configuration;
            _logger = logger;
        }

        public void Draw()
        {
            _logger.LogInformation($"draw");
        }
    }
}