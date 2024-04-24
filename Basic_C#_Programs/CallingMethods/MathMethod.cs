using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
	public class MathMethod
	{
        public int DoubleNumber(int num)
        {
            return num * 2;
        }

        public int SquareNumber(int num)
        {
            return num * num;
        }

        public int IncrementNumber(int num)
        {
            return num + 1;
        }
    }
}
