﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YLink.Data;

namespace YLink.Pages.Links
{
    public class IndexModel : PageModel
    {
        private readonly YLink.Data.ApplicationDbContext _context;

        public IndexModel(YLink.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Link> Link { get;set; }

        public async Task OnGetAsync()
        {
            Link = await _context.Links.ToListAsync();
        }
    }
}
