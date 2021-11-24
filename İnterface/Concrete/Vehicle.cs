using İnterface.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace İnterface
{
    public class Vehicle : ICredit
    {
        public int Id { get; set; }
        public int Interest { get; set; }
        public int CreditLimit { get; set; }

        public void Calculate()
        {
            Console.WriteLine("CreditLimit:" + CreditLimit + " " + "Interest:" + Interest + " "  + " transport Credit(Taşıt kredisi)");
        }
    }
}
