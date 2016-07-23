using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool isHit(Figure fig)
        {
            foreach(var p in pList)
            {
                if (fig.isHit(p))
                    return true;
            }
            return false;
            
        }

        private bool isHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.isHit(point))
                    return true;
            }
            return false;
        }
    }
}
