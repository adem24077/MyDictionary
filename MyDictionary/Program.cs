using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> clientBalance = new MyDictionary<int, string>();
            clientBalance.Add(100000,"Chris Brown");
            clientBalance.Add(20000,"Adam Green");
            clientBalance.Add(35000, "Elizabeth Hawkins");
            clientBalance.Add(254422, "Sony Blair");

            for (int i = 0; i < clientBalance.Count; i++)
            {
                Console.WriteLine("Balance:" +" "+ clientBalance.Keys[i]+ " " +" Name:" + clientBalance.Values[i] );
            }
        }
    }
}
