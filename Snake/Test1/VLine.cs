using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class VLine : Figure
    {


        public VLine(int x, int yU, int yD, char sym)
        {
            pList = new List<Point>();

            for(int y=yU; y<= yD; y++)
            {

                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        
    }
}
