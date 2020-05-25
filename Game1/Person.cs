using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game1
{
    public class Person
    {
        protected Bitmap bitmap;
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected int hp;
        protected int speed;

        public Bitmap Bitmap
        {
            get
            {
                return bitmap;
            }
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
        }
        public int Hp
        {
            get
            {
                return hp;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
        }

        public Person(Bitmap bitmap, int x, int y)
        {
            this.bitmap = bitmap;
            this.x = x;
            this.y = y;
            this.width = bitmap.Width;
            this.height = bitmap.Height;
            this.hp = 100;
            this.speed = 5;
        }
    }
}
