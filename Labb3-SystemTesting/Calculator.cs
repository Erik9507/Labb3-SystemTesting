using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_SystemTesting
{
    public class Calculator
    {
        public double input1;
        public double input2;
        public List<string> Calculations = new List<string>();
        public double Addition(double input1, double input2)
        {
            double res = input1 + input2;
            string result = ($"{input1} + {input2} = {res}");
            Console.WriteLine(result);
            AddToHistory(result);
            return res;
        }
        public double Subtract(double input1, double input2)
        {
            double res = input1 - input2;
            string result = $"{input1}-{input2}={res}";
            Console.WriteLine(result);
            AddToHistory(result);
            return res;
        }
        public double Multiply(double input1, double input2)
        {
            double res = input1 * input2;
            string result = $"{input1}*{input2}={res}";
            Console.WriteLine(result);
            AddToHistory(result);
            return res;
        }
        public double Devide(double input1, double input2)
        {
            double res = input1 / input2;
            string result = $"{input1}/{input2}={res}";
            Console.WriteLine(result);
            AddToHistory(result);
            return res;
        }

        public void AddToHistory(string calc)
        {
            Calculations.Add(calc);
        }
        public void PrintHistory()
        {
            foreach (var item in Calculations)
            {
                Console.WriteLine(item);
                
            }
            Console.ReadKey();
            Console.Clear();
        }
        



    }
}
