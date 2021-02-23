using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLibrary
{
    public static class InputHandler
    {
        private static string _input;
        public static string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        public static int GetInputAsInt(string input)
        {
            return ConvertInputToInt(input);
        }

        private static int ConvertInputToInt(string input)
        {
            if (IsValidInput(input))
            {
                return Int32.Parse(input)-1;
            }
            else
            {
                throw new ArgumentException("Input is invalid");
            }
        }

        private static bool IsValidInput(string input)
        {
            int convertedInput;
            bool canConvert = Int32.TryParse(input, out convertedInput);
            if (canConvert)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
