using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Field
    {
        List<Figure> wals;

        public Field(int width, int heith, char sym)
        {
            wals = new List<Figure>();

            HLine up = new HLine(0, width-2, 0, sym);            
            HLine down = new HLine(0, width-2, heith-1, sym);            
            VLine left = new VLine(0, 0, heith-1, sym);            
            VLine right = new VLine(width-2, 0, heith-1, sym);

            wals.Add(up);
            wals.Add(down);
            wals.Add(left);
            wals.Add(right);


        }

        public bool isHit(Figure fig)
        {
            foreach(var wall in wals)
            {
                if (wall.isHit(fig)) return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach(var w in wals)
            {
                w.Draw();
            }
        }

    }
}
