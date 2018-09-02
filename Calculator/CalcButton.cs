using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ButtonType
{
    CLEAR,
    DELETE,
    DIVIDE,
    MULTIPLY,
    SUBTRACT,
    ADD,
    ENTER,
    NUMBER
};

namespace Calculator
{
    public class CalcButton
    {
        
        ButtonType type;

        public CalcButton(ButtonType type)
        {
            this.type = type;
        } 
    }
}
