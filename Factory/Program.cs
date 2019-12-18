using System;

namespace Factory
{

    class Program
    {
        static void Main(string[] args)
        {
        Transport transport;
            Console.WriteLine("Sea or Land");
            var input = Console.ReadLine();
            if (input == "Sea")
            {
                transport = new SeaTransport();
            }
            else if (input == "Land")
            {

                transport = new LandTransport();
            }
            else
                throw new Exception("Error! Unknown operating system.");

          var x =  transport.PrepareTransport();
            Console.WriteLine("Hello World!");
        }
    }
}
