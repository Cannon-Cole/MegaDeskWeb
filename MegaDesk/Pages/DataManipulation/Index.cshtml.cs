using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Models;

namespace MegaDesk.Pages.DataManipulation
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk.Models.DeskQuoteContext _context;

        public IndexModel(MegaDesk.Models.DeskQuoteContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            if (!String.IsNullOrEmpty(searchString))
                CurrentFilter = searchString;

            IQueryable<DeskQuote> deskQuote = from s in _context.DeskQuote
                                              select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                deskQuote = deskQuote.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    deskQuote = deskQuote.OrderByDescending(s => s.Name);
                    break;
                case "Date":
                    deskQuote = deskQuote.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    deskQuote = deskQuote.OrderByDescending(s => s.Date);
                    break;
                default:
                    deskQuote = deskQuote.OrderBy(s => s.Name);
                    break;
            }

            DeskQuote = await deskQuote.AsNoTracking().ToListAsync();
        }
    }
}
