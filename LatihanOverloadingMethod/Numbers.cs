using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        private int _x, _y;
        public int FindMinimum(int number1, int number2)
        {
            return number1 < number2 ? number1 : number2;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            _x = number1 < number3 ? number1 : (int)number3;
            _y = number2 < number3 ? number2 : (int)number3;
            return number1 < number2 ? _x : _y;
        }

        public int FindMaximum(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            _x = number1 > number3 ? number1 : (int)number3;
            _y = number2 > number3 ? number2 : (int)number3;
            return number1 > number2 ? _x : _y;
        }
    }
}
