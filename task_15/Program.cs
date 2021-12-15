using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        interface ISeries
        {
            void setStart(int x);
            int getNext();
            void reset();
        }
        class ArithProgression : ISeries
        {
            int firstNumber = 2;
            int step = 3;
            int next;
            public int getNext(int f, int s)
            {
                next = firstNumber+step;
                return next;
            }

            public void reset()
            {
                throw new NotImplementedException();
            }

            public void setStart(int x)
            {
                
            }
        }
    }
}