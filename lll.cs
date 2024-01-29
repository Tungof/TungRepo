using System;



class Program

{

    static void Main(string[] args)

    {

        while (true)

        {

            Console.WriteLine("Меню выбора:");

            Console.WriteLine("1. Ввести A");

            Console.WriteLine("2. Ввести B");

            Console.WriteLine("3. Выполнить операцию умножения");

            Console.WriteLine("4. Выполнить операцию деления");

            Console.WriteLine("5. Выполнить операцию возведения в степень");

            Console.WriteLine("6. Выполнить операцию деления с остатком");

            Console.WriteLine("0. Выйти из программы");



            Console.Write("Выберите пункт меню: ");

            string choice = Console.ReadLine();



            switch (choice)

            {

                case "1":

                    Console.Write("Введите A: ");

                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Вы ввели A = " + a);

                    break;

                case "2":

                    Console.Write("Введите B: ");

                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Вы ввели B = " + b);

                    break;

                case "3":

                    Console.WriteLine("Выполнить операцию умножения");

                   

                    break;

                case "4":

                    Console.WriteLine("Выполнить операцию деления");

                  

                    break;

                case "5":

                    Console.WriteLine("Выполнить операцию возведения в степень");

                   

                    break;

                case "6":

                    Console.WriteLine("Выполнить операцию деления с остатком");

                    

                    break;

                case "0":

                    Console.WriteLine("Выход из программы.");

                    return;

                default:

                    Console.WriteLine("Некорректный ввод.");

                    break;

            }



            Console.WriteLine(); 
        }

    }

}