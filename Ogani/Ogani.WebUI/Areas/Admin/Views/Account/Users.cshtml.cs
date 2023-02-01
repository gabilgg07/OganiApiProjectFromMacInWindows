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
    public class UsersModel : PageModel
    {
        private readonly OganiDbContext _context;

        public UsersModel(OganiDbContext context)
        {
            _context = context;
        }

        public IList<OganiUser> OganiUser { get;set; }

        public async Task OnGetAsync()
        {
            OganiUser = await _context.Users.ToListAsync();
        }
    }
}
