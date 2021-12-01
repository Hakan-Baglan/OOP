using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMananger customerMananger = new CustomerMananger();
            customerMananger.add();
            customerMananger.Update();
            
            ProductMananger productMananger = new ProductMananger();
            productMananger.add();
            productMananger.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";
            //Console.WriteLine(customer.City);

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Derin",
                LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
