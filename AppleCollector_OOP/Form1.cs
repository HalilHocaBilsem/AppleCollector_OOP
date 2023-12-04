using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleCollector_OOP
{
    public partial class Form1 : Form
    {
        Basket basket;
        List<GameObject> gameObjects;
        Timer timer;
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
           basket= new Basket() { Location=new Point(300,400) }; 
            gameObjects = new List<GameObject>();
            gameObjects.Add(basket);
            timer = new Timer() {Interval=100, Enabled=true };
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (gameObjects.Count<4)
            {
                int random = new Random().Next(0,2);
                int randomX = new Random().Next(100, 500);
                if (random==0)
                {

                    gameObjects.Add(new Apple() { Location=new Point(randomX,0), Speed=new Point(0,1)});
                }
                else
                {
                    gameObjects.Add(new Monster() {Location=new Point(randomX,0), Speed = new Point(0, 2)   });
                }
               
            }

            foreach (var item in gameObjects)
            {
                item.Move();
            }
            this.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Right)
            {
                basket.Speed.X +=  1;               
            }
            else
            {
               basket.Speed.X -=    1;              
            }

          

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
       

            foreach (var item in gameObjects)
            {
                item.Draw(e.Graphics);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
