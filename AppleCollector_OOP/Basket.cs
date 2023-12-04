using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleCollector_OOP
{
    public class Basket:GameObject
    {
        public Basket() {
            Image = System.Drawing.Image.FromFile("basket.png");
            Size = new Size(100, 90);
        }
    }
}
