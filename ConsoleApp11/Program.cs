using System;
namespace hej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är din ålder");
            int ålder= int.Parse(Console.ReadLine());
            if (ålder <= 16 )
            {
                Console.WriteLine("Du är för ung, väx upp för fan");
            }
            else if( ålder >= 19 )
            {
                Console.WriteLine("Du är för gammal, clicka ok för att åka till ålderdomsehem");
            }
            else
            {
                Console.WriteLine("Välkommen hit gubbe");
            }
        }
    }
}