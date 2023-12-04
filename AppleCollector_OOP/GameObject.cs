using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleCollector_OOP
{
    public class GameObject
    {
        public Point Location;
        public Image Image;
        public Size Size;
        public Point Speed;

        public void Move()
        {
            Location.Y += Speed.Y;
            Location.X += Speed.X;
        }
        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(Image,new Rectangle( Location,Size));
        }
    }
}
