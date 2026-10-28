using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_HW_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите выражение: ");
            string txt = Console.ReadLine();

            int result = EvaluateExpression(txt);

            Console.WriteLine($"Ответ такой: {result}");
        }

        public static int EvaluateExpression(string expression)
        {
            expression = expression.Replace(" ", "");

            int result = 0;
            string temp = "";
            char sign = '+';
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                if (char.IsDigit(c))
                {
                    temp += expression[i];
                }
                if(c == '+' || c == '-' || i == expression.Length-1)
                {
                    if(temp.Length > 0)
                    {
                        int currentNum = int.Parse(temp);

                        if (sign == '+')
                        {
                            result += currentNum;
                        }
                        else if (sign == '-')
                        {
                            result -= currentNum;
                        }

                        temp = "";
                    }

                    if(c == '+' || c == '-')
                    {
                        sign = c;
                    }
                }
            }

            return result;
        }
    }
}
