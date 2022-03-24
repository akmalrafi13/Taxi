using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                double num1 = 0;
                double num2 = 0;
                double result = 0;

                // menu
                Console.WriteLine("---CALCULATOR---\n");
                Console.WriteLine("Pilih Menu Kalkulator\n");

                Console.WriteLine("1. Penambahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian\n");

                // choise menu
                Console.Write("Input nomer menu[1..4] : ");
                int menu = int.Parse(Console.ReadLine());

                // input number with Exception
                try
                {
                    // percabangan untuk menentukan nilai
                    switch (menu)
                    {
                        case 1:
                            Console.Write("\nInputkan nilai number 1 = ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Inputkan nilai number 2 = ");
                            num2 = Convert.ToDouble(Console.ReadLine());

                            result = num1 + num2;
                            Console.WriteLine($"Your Result : {num1} + {num2} = {result}");
                            break;
                        case 2:
                            Console.Write("\nInputkan nilai number 1 = ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Inputkan nilai number 2 = ");
                            num2 = Convert.ToDouble(Console.ReadLine());

                            result = num1 - num2;
                            Console.WriteLine($"Your Result : {num1} - {num2} = {result}");
                            break;
                        case 3:
                            Console.Write("\nInputkan nilai number 1 = ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Inputkan nilai number 2 = ");
                            num2 = Convert.ToDouble(Console.ReadLine());

                            result = num1 * num2;
                            Console.WriteLine($"Your Result : {num1} * {num2} = {result}");
                            break;
                        case 4:
                            Console.Write("\nInputkan nilai number 1 = ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Inputkan nilai number 2 = ");
                            num2 = Convert.ToDouble(Console.ReadLine());

                            result = num1 / num2;
                            Console.WriteLine($"Your Result : {num1} / {num2} = {result}");
                            break;
                        default:
                            Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                            break;
                    }
                    // jika yang dimasukkan bukan number maka akan exception
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.Write("\nTekan Enter untuk menggulangi");
                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}
