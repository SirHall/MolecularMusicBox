using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolecularMusicBox
{
    class MathE
    {
        public static int WrapBasic(int value, int min, int max)
        {
            if(value >= min && value <= max)
            {
                return value;
            }else if (value < min)
            {
                return max;
            }
            else
            {
                return min;
            }
        }
    }
}
