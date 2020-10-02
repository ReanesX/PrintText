using System;
using System.Threading;

namespace PrintText
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Введите текст: ");
                string text = Console.ReadLine();

                char[] charText = text.ToCharArray();

                Console.Write("Введите кол-во задержки: ");
                int timeout = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                for (int i = 0; i < charText.Length; i++)
                {
                    Console.Write(charText[i]);
                    Thread.Sleep(timeout);
                }
                
                Console.WriteLine("\nПовторить Y/N ?");
                if (Console.ReadKey(true).Key != ConsoleKey.Y)
                    break;
            }
        }
    }
}
