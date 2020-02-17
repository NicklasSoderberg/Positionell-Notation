using System;
using System.Linq;

namespace positionellNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Number;
            string Base;
            string Print;
            int Res;
            bool keepGoing = true;
            while (keepGoing){
                Console.Clear();
                Console.Write("Input a number: ");
                Number = Console.ReadLine();
                Console.Write("Input base: ");
                Base = Console.ReadLine();
                if (Number.All(char.IsDigit)&&(Base.All(char.IsDigit)))
                {
                    Print = "";
                    Res = 0;
                    for (int i = 0; i < Number.Length; i++)
                    {
                        if(Print != "")
                        {
                            Print += " + ";
                        }
                        Print += "(" + Number[i] + " * " + Base + " ^ " + Convert.ToString(Number.Length - i - 1) + ")";
                        Res += int.Parse(Number[i].ToString()) * Convert.ToInt32(Math.Pow(int.Parse(Base), Number.Length - i - 1));
                    }
                    Console.WriteLine("");
                    Console.WriteLine(Print + " = " + Res.ToString());
                    Console.WriteLine("");
                    Console.WriteLine("Try again? press enter..  0 = Exit  :)");
                    keepGoing = Console.ReadLine() != "0";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try again..");
                }
            }

        }
    }
}
