using System;
namespace MegaDesk
{
    public class Desk
    {
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_HEIGHT = 12;
        public const int MAX_HEIGHT = 48;

        public int height { get; set; }
        public int width { get; set; }
        public int drawers { get; set; }
        public string rush { get; set; }
        public string material { get; set; }

        public enum Materials
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        };
    }
}
