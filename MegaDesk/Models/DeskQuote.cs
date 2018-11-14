using System;
using System.ComponentModel.DataAnnotations;
namespace MegaDesk.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }

        [Range(24, 96)]
        [Required]
        public int Width { get; set; }

        [Range(12, 48)]
        [Required]
        public int Depth { get; set; }

        [Range(0, 7)]
        [Required]
        public int Drawers { get; set; }

        [Required]
        public string Material { get; set; }

        [Required]
        public int Rush { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }

        public int Total { get; set; }
    }
}