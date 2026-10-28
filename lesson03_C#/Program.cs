using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson03_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] russianAlphabet = {
                'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й',
                'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф',
                'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
            };

            string text;
            Console.Write("Введите текст для шифровки: ");
            text = Console.ReadLine();

            int shift;
            Console.Write("Задайте сдвиг: ");
            shift = int.Parse(Console.ReadLine());

            string result = EncryptText(text, shift, russianAlphabet);
            string result2 = UnEncryptText(result, shift, russianAlphabet);

            Console.WriteLine($"Зашифрованный текст: {result}");
            Console.WriteLine();
            Console.WriteLine($"Разшифрованный текст: {result2}");
        }

        public static string EncryptText(string text, int shift, char[] alph)
        {
            string result = "";
         
            string upText = text.ToUpper();

            for (int i = 0; i < upText.Length; i++)
            {
                if (upText[i] == ' ')
                {
                    result += upText[i];
                }
                else
                {
                    for (int j = 0; j < alph.Length; j++)
                    {

                        if (upText[i] == alph[j])
                        {
                            if (alph.Length > j + shift)
                            {
                                result += alph[j + shift];
                            }
                            else
                            {
                                result += alph[((j + shift) % alph.Length)];
                            }
                        }
                    }
                }
                
            }

            return result;

        }

        public static string UnEncryptText(string text, int shift, char[] alph)
        {
            string result = "";

            string upText = text.ToUpper();

            for (int i = 0; i < upText.Length; i++)
            {
                if (upText[i] == ' ')
                {
                    result += upText[i];
                }
                else
                {
                    for (int j = 0; j < alph.Length; j++)
                    {

                        if (upText[i] == alph[j])
                        {
                            if (alph.Length > j + shift)
                            {
                                result += alph[j - shift];
                            }
                            else
                            {
                                result += alph[((j - shift) % alph.Length)];
                            }
                        }
                    }
                }

            }

            return result;

        }
    }
}
