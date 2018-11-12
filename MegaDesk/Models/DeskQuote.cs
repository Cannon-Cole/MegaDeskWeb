using System;
using System.ComponentModel.DataAnnotations;
namespace MegaDesk.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public string Material { get; set; }
        public int Rush { get; set; }
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Total { get; set; }
    }
}