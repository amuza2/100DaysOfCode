using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    public class Area
    {
        string a = Codewarss.name;
        string b = Codewarss.name;
        public double Width { get; set; }
        public double Height { get; set; }
        public Area(double width)
        {
            Width = width;
        }
        public Area(double width, double height)
        {
            Width = width;
            Height = height;
        }
        private void CoordenatesChecker()
        {
            if (Width > 100 || Height > 100)
                throw new OutOfBoundException($"{Width} or {Height} out of bound");
        }
        public double RectangleArea()
        {
            CoordenatesChecker();
            return Width * Height;
        }
        public double SquareArea()
        {
            CoordenatesChecker();
            return Width * Width;
        }
    }
}
