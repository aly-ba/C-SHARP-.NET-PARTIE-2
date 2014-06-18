using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Lesson02;


namespace AutreCouche
{
    class Program
    {
        static void Main(string[] args)
        {
            //i neeed 5 computer et 3 smart phone
            Console.Write("Client(a or b): ");
            var client = Console.ReadLine();

            IFactory factory;

            if (client == "a")
            {
                factory = new ClientAFactory();
            }

            else if (client == "b")
            {
                factory = new ClientBFactory();
            }
            else
            {
                return;
            }
            //var company= new HandyDandyApplication();

            var order = new Order();

            Console.Write("How many Computers ?");
            order.Computers = ConvertToInt32(Console.ReadLine());


            Console.Write("How many Tablets ?");
            order.Tablets = ConvertToInt32(Console.ReadLine());

            Console.Write("How many Phones ?");
            order.SmartPhones = ConvertToInt32(Console.ReadLine());

            


            var company = new HandyDandyManufacturingCompany(factory);
            company.Produce(order);



            Console.ReadLine();
        }

        private static int ConvertToInt32(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            return Int32.Parse(input);
        }
    }
}
