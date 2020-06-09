using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sendsatTimeclock.Data;
using sendsatTimeclock.Models;

namespace sendsatTimeclock.Pages.Index
{
    public class IndexModel : PageModel
    {
        private readonly sendsatTimeclock.Data.sendsatTimeclockContext _context;

        public IndexModel(sendsatTimeclock.Data.sendsatTimeclockContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
