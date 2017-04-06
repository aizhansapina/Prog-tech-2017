using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class Calculate
    {
        public double FirstNumber;
        public double SecondNumber;
        public double result;
        public string operation;
        

        public void Calcul()
        {
            
            switch (operation)
            {
                case "+":
                    result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    result = FirstNumber - SecondNumber;
                    break;
                case "×":
                    result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    result = FirstNumber / SecondNumber;
                    break;
                /*case "%":
                    result = (FirstNumber * SecondNumber) / 100;
                    break;*/
                default:
                    break;
            }
        }
    }
}
