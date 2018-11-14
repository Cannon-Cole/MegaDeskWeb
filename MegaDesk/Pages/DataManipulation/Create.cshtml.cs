using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk.Models;

namespace MegaDesk.Pages.DataManipulation
{
    public class CreateModel : PageModel
    {
        private readonly MegaDesk.Models.DeskQuoteContext _context;

        public CreateModel(MegaDesk.Models.DeskQuoteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DeskQuote.Total = DeskQuoteCalculations.getPrice(DeskQuote.Depth, DeskQuote.Width, DeskQuote.Material, DeskQuote.Rush, DeskQuote.Drawers);

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}