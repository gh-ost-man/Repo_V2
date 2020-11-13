using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCardLib;
using CreditCardLib;
using Money;

namespace Task_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BusinessCard bc = new BusinessCard();
            CreditCard cc = new CreditCard();
            Money.Money m = new Money.Money();

            Console.WriteLine("Credit card: ");
            Console.WriteLine(cc);

            Console.WriteLine();
        }
    }
}
