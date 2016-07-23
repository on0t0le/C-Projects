using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Kitchen
    {
        int xlim;
        int ylim;
        char symb;
        Random rand = new Random();

        public Kitchen(int xlim, int ylim, char symb)
        {
            this.xlim = xlim;
            this.ylim = ylim;
            this.symb = symb;
        }

        public Point Cooking()
        {
            int x;
            int y;
            Point p;

            x = rand.Next(5, xlim - 5);
            y = rand.Next(5, ylim - 5);

            //x = 9;
            //y = 5;

            p=  new Point(x, y, symb);

            return p;
        }
    }
}
