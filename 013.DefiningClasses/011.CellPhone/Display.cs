using System;
using System.Collections.Generic;
using System.Text;

namespace CellPhone
{
    public class Display
    {
        private double width;
        private double height;
        private int colors;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        public int Colors { get => colors; set => colors = value; }

        public Display()
        {
            this.width = 0.00;
            this.height = 0.00;
            this.colors = 0;
        }

        public Display(double width, double height, int colors)
        {
            this.width = width;
            this.height = height;
            this.colors = colors;
        }
    }
}
