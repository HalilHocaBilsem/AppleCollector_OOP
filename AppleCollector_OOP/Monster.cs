using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleCollector_OOP
{
    public class Monster : GameObject
    {
        public Monster()
        {
            Image = System.Drawing.Image.FromFile("monster.png");
            Size = new Size(50, 50);
        }
    }
}
