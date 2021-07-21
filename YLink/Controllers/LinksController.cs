using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YLink.Data;

namespace YLink.Controllers
{
    [ApiController]
    public class LinksController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public LinksController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("{key}")]
        public IActionResult GoToLink(string key)
        {
            var link = _db.Links.FirstOrDefault(l => l.Key == key);
            if (link  == null)
            {
                return NotFound();
            }

            return Redirect(link.Url);
        }
    }
}
