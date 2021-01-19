using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazvetAlg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Высокий уровень #28
            int x = 0;
            int y = 0;
            int z = 0;

            try
            {
                {
                    Console.Write("Введите трехзначное число A: ");
                    string str = Console.ReadLine();
                    string output = "";
                    int count = 0;
                    foreach (char ch in str)
                    {
                        string s = ch.ToString();
                        count++;
                        if (count == 1) x = int.Parse(s);
                        else if (count == 2) y = int.Parse(s);
                        else if (count == 3) z = int.Parse(s);
                        else throw new Exception();
                    }
                    output = "" + x + y + z;
                    int A = int.Parse(output);

                    Console.WriteLine("Является ли произведение цифр числа A меньше его самого?");
                    if (x * y * z < A) Console.WriteLine("Да");
                    else Console.WriteLine("Нет");

                    Console.WriteLine("Кратна ли 5 сумма его цифр");
                    if ((x + y + z) % 5 == 0) Console.WriteLine("Да");
                    else Console.WriteLine("Нет");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Только трехзначные числа");
            }
            Console.ReadKey();
        }
    }
}