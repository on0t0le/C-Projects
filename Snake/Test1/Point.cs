using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point(int xz, int yz, char chz)
        {
            this.x = xz;
            this.y = yz;
            this.symb = chz;

        }
        
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        public void Move(int offset, Direction dir)
        {
            if(dir == Direction.RIGHT)
            {
                x = x + offset;
            }
            if (dir == Direction.LEFT)
            {
                x = x - offset;
            }
            if (dir == Direction.UP)
            {
                y = y - offset;
            }
            if (dir == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }

        internal void Clear()
        {
            symb = ' ';
            Draw();
        }

        public bool isHit(Point p)
        {
            return (p.x == this.x && p.y == this.y);
           
        }


        public override string ToString()
        {
            return x+", "+y+", "+symb;

        }


    }
}
