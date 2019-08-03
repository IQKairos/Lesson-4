using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {           
            int squareSide = 10;
                     
            Square mySquare = new Square();
            mySquare.setsquare(squareSide);
            mySquare.getSquare();           
            mySquare.getPeremeter();

            Progression myProgression = new Progression();
            myProgression.setParam(firstElem:0, step: 5, nElem: 11);          
            myProgression.getNElem();
            myProgression.getSumToNElem();
            myProgression.getMidle();
        }
    }
}
