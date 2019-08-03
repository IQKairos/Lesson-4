using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Progression
    {
        public int firstElem;
        public int step;
        public int nElem;
        public void setParam(int firstElem, int step, int nElem)
        {
            this.firstElem = firstElem;
            this.step = step;
            this.nElem = nElem;
        }
        
        public int getNElem()
        {
            return firstElem + (nElem - 1) * step;
        }
        public int getSumToNElem()
        {
            return (firstElem + (firstElem + (nElem - 1) * step)) * nElem / 2;
        }
        public float getMidle()
        {
            float firstElem1 = (float)firstElem;
            float nElem1 = (float)nElem;
            float step1 = (float)step;
            return (firstElem1 + (firstElem1 + (nElem1 - 1) * step1)) / 2;
        }
    }
}
