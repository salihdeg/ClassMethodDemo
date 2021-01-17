using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = customerManager.GetCustomers();

            customerManager.MusteriEkle(customers);

            customerManager.MusteriList(customers);

            customerManager.MusteriUpdate(ref customers[2],"Muhammed Sencer", customers[2].Soyadi, customers[2].MusteriNumarasi);
            customerManager.MusteriEkle(customers[2]);
            customerManager.MusteriList(customers);

        }
    }
}
