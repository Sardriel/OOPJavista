using System;

namespace OOPJavista
{
    class Program
    {
        static void Main(string[] args)
        {
            Javista karel = new Javista("Karel Nový", 25, "JAVA");
            Console.WriteLine(karel);
            karel.Behej(10);
            karel.Behej(10);
            karel.Programuj(5);
            karel.Behej(10);
            karel.Odpocivej(8);
            karel.Programuj(100);
            Console.ReadKey();
        }
    }
}
