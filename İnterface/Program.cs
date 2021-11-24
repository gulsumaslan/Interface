using İnterface.Abstract;
using System;



namespace İnterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Housing housing1 = new Housing();
            housing1.Id = 1;
            housing1.Interest = 2;
            housing1.CreditLimit = 5000;
            housing1.Calculate();

            Console.WriteLine("+++++++++++");

            Vehicle vehicle1 = new Vehicle();
            vehicle1.Id = 3;
            vehicle1.Interest = 4;
            vehicle1.CreditLimit = 10000;
            vehicle1.Calculate();

            Console.WriteLine("++++++++++++");

            Need need = new Need();
            need.Id = 2;
            need.Interest = 6;
            need.CreditLimit = 6000;
            need.Avans = 2000;
            
            need.Calculate();

            need.Bonus();




        }
    }
}
