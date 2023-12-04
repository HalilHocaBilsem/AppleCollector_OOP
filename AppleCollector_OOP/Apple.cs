using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleCollector_OOP
{
   public  class Apple:GameObject
    {
      public Apple()
        {
            Image = System.Drawing.Image.FromFile("apple.png");
            Size = new Size(50, 50);
        }
    }
}
