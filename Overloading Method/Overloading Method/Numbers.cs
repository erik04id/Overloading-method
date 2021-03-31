using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Method
{
    class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            return (new int[] { number1, number2 }).Min();
        }
        public float FindMinimum(int number1, int number2, float number3)
        {
            return (new float[] { number1, number2, number3 }).Min();
        }
        public int FindMaximum(int number1, int number2)
        {
            return (new int[] { number1, number2 }).Max();
        }
        public float FindMaximum(int number1, int number2, float number3)
        {
            return (new float[] { number1, number2, number2, number3 }).Max();
        }
            
    }
}
