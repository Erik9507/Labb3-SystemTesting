using System;

namespace Labb3_SystemTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            bool active = true;
            while (active)
            {
                Console.WriteLine("\n1: Calculate \n2: Calculation History");
                int menu1 = Convert.ToInt32(Console.ReadLine());
                if (menu1 == 1)
                {
                    Console.WriteLine("Please enter a number");                    
                    while (!double.TryParse(Console.ReadLine(), out cal.input1))
                    {
                        Console.WriteLine("Error, enter a number instead");
                    }              
                    Console.WriteLine("Please enter another number");
                    while (!double.TryParse(Console.ReadLine(), out cal.input2))
                    {
                        Console.WriteLine("Error, enter a number instead");
                    }

                    Console.Clear();
                    Console.WriteLine("Select calculator function");
                    Console.WriteLine("\n1: Addition \n2: Subtract \n3: Multiply \n4: Devide");
                    
                    int menu2 = Convert.ToInt32(Console.ReadLine());
                    switch (menu2)
                    {
                        case 1:
                            cal.Addition(cal.input1, cal.input2);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            cal.Subtract(cal.input1, cal.input2);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            cal.Multiply(cal.input1, cal.input2);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            cal.Devide(cal.input1, cal.input2);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("unvalid input");
                            break;
                    }
                }
                else if (menu1 == 2)
                {
                    cal.PrintHistory();
                }
                else
                {
                    Console.WriteLine("Unvalid input");
                    active = true;
                }
            }


        }
    }
}

