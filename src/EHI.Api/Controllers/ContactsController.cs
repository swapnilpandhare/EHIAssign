using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHI.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
           ""
        };

        private readonly ILogger<ContactsController> _logger;

        public ContactsController(ILogger<ContactsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ContactInfoDto> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ContactInfoDto
            {
                FirstName = "John"
            });
        }
    }
}
