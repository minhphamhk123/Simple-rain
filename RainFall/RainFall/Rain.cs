using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RainFall
{
    class Rain
    {
        Random random = new Random();
        public int X { get; set; }
        public int Y { get; set; }
        SolidBrush PR { get; set; }
        public int xucxac { get; set; }

        public Rain (int xx, int yy, SolidBrush B, int ngaunhien)
        {
            X = xx;
            Y = yy;
            PR = B;
            xucxac = ngaunhien;
        }

        public void Draw(Graphics e)
        {
            e.FillRectangle(PR, X, Y -30, 2, 10);
        }
        public void Draw1(Graphics e)
        {
            e.FillRectangle(PR, X, Y-30, 5, 20);
        }
        public void Draw2(Graphics e)
        {
            e.FillRectangle(PR, X, Y-30, 7, 30);
        }
        public void Draw3(Graphics e)
        {
            e.FillRectangle(PR, X, Y-30, 2, 5);
        }
    }
}
