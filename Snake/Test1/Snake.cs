using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Snake : Figure

    {

        Direction direction;

        public Snake(Point tail, int length, Direction dir)
        {
            direction = dir;

            pList = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, dir);
                pList.Add(p);
            }
            
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = getNext();
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }

        public void Handle(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }

        internal bool isHitTail()
        {
            var head = pList.Last();
            for(int i = 0; i < pList.Count - 2; i++)
            {
                if (head.isHit(pList[i]))
                    return true;
            }
            return false;
        }

        public Point getNext()
        {
            Point head = pList.Last();
            Point next = new Point(head);
            next.Move(1, direction);
            return next;
        }

        public bool Eat(Point food)
        {
            Point head = getNext();
            if (head.isHit(food))
            {
                head.Draw();
                food.symb = head.symb;
                pList.Add(food);
                return true;
            }
            else return false;
        }

    }
}
