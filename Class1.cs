using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Square
    {
        public int side;
        public void setsquare(int side)
        {
            this.side = side;
        }
        public int getSquare()
        {
            return this.side * this.side;
        }
        public int getPeremeter()
        {
            return this.side * 4;
        }
            
    }
  

}
