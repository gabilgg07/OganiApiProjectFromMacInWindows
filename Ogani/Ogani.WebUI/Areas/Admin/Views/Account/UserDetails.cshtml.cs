using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ogani.Application.Models.DataContext;
using Ogani.Application.Models.Entity.Membership;

namespace Ogani.WebUI.Areas.Admin.Views.Account
{
    public class UserDetailsModel : PageModel
    {
        private readonly OganiDbContext _context;

        public UserDetailsModel(OganiDbContext context)
        {
            _context = context;
        }

        public OganiUser OganiUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OganiUser = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (OganiUser == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
