using System;
using Microsoft.EntityFrameworkCore;

namespace MegaDesk.Models
{
    public class DeskQuoteContext : DbContext
    {
        public DeskQuoteContext(DbContextOptions<DeskQuoteContext> options)
                : base(options)
        {
        }

        public DbSet<DeskQuote> DeskQuote { get; set; }
    }
}
