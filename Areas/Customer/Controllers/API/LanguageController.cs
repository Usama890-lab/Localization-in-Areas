using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers.API
{
    [Area("Customer")]
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController1 : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController1> _localizer;
        public LanguageController1(IStringLocalizer<LanguageController1> localizer)
        {
            _localizer = localizer;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var guid = Guid.NewGuid();
            return Ok(_localizer["RandomGUID", guid.ToString()].Value);
        }
    }
}
