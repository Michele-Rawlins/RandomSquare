using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomNumberList = new List<int>();
            var squaredNumberList = new List<int>();
            var evenSquaredList = new List<int>();


            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(1, 51);
                randomNumberList.Add(randomNumber);
                Console.WriteLine($"Random Number List: {string.Join(",", randomNumber)}");
            }
            
                
            foreach( var num in randomNumberList)
            {
                int squared = num * num;
                squaredNumberList.Add(squared);
                Console.WriteLine($"Squared Number List: {string.Join(",", squared)}");

            }

            foreach(var even in squaredNumberList)
            {
                if (even % 2 == 0)
                
                Console.WriteLine($"Even numbers only:  { even}");
            }

            //var randomNumber = random.RandomNumbe(1, 50);

        }
    }
}
