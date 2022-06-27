namespace HelloWorld  
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int number = new Random().Next(100, 1000);
            Console.WriteLine(number);
            Console.WriteLine($"{number / 100}{number % 10}");
            string str = Convert.ToString(number);
            Console.WriteLine($"{str[0]}{str[2]}");

        }  
    }
}