using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ten: ");
            string name = Console.ReadLine();

            Console.WriteLine("Nhap phone: ");
            string phone = Console.ReadLine();

            Console.WriteLine("Nhap dia chi: ");
            string address = Console.ReadLine();

            Console.WriteLine("Name " + name  + ", Phone " + phone + ", Address " + address );
        }
    }
}
