using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class NumberCalcButton : CalcButton
    {
        int value;

        public NumberCalcButton(ButtonType type, int val) : base(type)
        {
            this.value = val;
        }
    }
}
