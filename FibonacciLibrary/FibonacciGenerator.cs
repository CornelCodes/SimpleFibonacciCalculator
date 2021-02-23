using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLibrary
{
    public class FibonacciGenerator
    {
        private List<long> _fibonacciNumbers;

        public List<long> FibonacciNumbers
        {
            get { return _fibonacciNumbers; }
            set { _fibonacciNumbers = value; }
        }

        public FibonacciGenerator(int numbersToGenerate)
        {
            //Initialise empty list
            FibonacciNumbers = GenerateFibonacciNumbers(numbersToGenerate);
        }

        private List<long> GenerateFibonacciNumbers(int amountOfNumbers)
        {
            //Get last two numbers in list
            //Add them together
            //Add result to list
            //Repeat until list has amountOfNumbers
            List<long> tempList = new List<long>();
            for (int i = 0; i < amountOfNumbers; i++)
            {
                //Check if list is empty
                //If yes add first number
                if(tempList.Count < 1)
                {
                    tempList.Add(0);
                }
                else if(tempList.Count < 2)
                {
                    tempList.Add(1);
                }
                else
                {
                    if(tempList.Count < 3)
                    {
                        tempList.Add(tempList[i-1] + tempList[i-1]);
                    }
                    else
                    {
                        tempList.Add(tempList[i-1] + tempList[i - 2]);
                    }
                }
            }
            Console.WriteLine($"{amountOfNumbers} Fibonacci numbers generated");
            return tempList;
        }

        public long GetNumberAtIndex(int index)
        {
            return FibonacciNumbers[index];
        }
    }
}
