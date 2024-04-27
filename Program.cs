using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmilCS
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region out int console
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш город: ");
            string city = Console.ReadLine();

            Console.WriteLine("Введите ваш рост: ");
            double height = double.Parse(Console.ReadLine());

            // Конкатенация 
            Console.WriteLine("Ваше имя: " + name);
            Console.WriteLine("Ваш возраст: " + age);
            Console.WriteLine("Ваш город: " + city);
            Console.WriteLine("Ваш рост: " + height);

            // Плейсхолдеры (placeholder)
            Console.WriteLine("Ваше имя: {0}, ваш возраст: {1}, ваш город: {2}, ваш рост: {3}", name, age, city, height);

            // Интерполяция строк
            Console.WriteLine($"Ваше имя: {name}, ваш возраст: {age}, ваш город: {city}, ваш рост: {height}");

            #endregion

            #region PrintPause
            PrintPause.Print("Это метод Print");
            PrintPause.Pause();
            #endregion

            #region MyMethod2
            int a = Addition(6, 70);
            #endregion

            #region object of Client
            Client client = new Client();
            client.Name = "Amil";
            client.OrderNumber = 1235676723;
            client.ID = 1;

            Console.WriteLine(client);
            #endregion

            #region Index
            Console.WriteLine("Введите свой вес");
            double mass = double.Parse(Console.ReadLine());

            Console.WriteLine(mass / (height * height));
            #endregion

            #region Rasstoyanie
            Rasstoyanie rasstoyanie = new Rasstoyanie();
            rasstoyanie.R();
            #endregion
        }



        public static int Addition(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
            int sum = firstNum + secondNum;
            return sum;
        }


    }

    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Клиент: {Name}, Номер заказа: {OrderNumber}";
        }
    }
    public class Rasstoyanie
    {
        public int x1 { get; set; }
    public int y1 { get; set; }
        public int x2 { get; set; }
    public int y2 { get; set; }


        public void R()
        {
            Console.WriteLine("Введите первый x");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первый y");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй x");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй y");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }
    }
}

public class PrintPause
{
    public static void Print(string str)
    {
        Console.WriteLine(str);
    }
    public static void Pause()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Sleep for 2 seconds.");
            Thread.Sleep(2000);
        }

        Console.WriteLine("Main thread exits.");
    }
}

