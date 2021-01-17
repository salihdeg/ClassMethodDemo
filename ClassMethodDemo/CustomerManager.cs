using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public Customer[] GetCustomers()
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Adi = "Salih";
            customer1.Soyadi = "Değirmenci";
            customer1.MusteriNumarasi = "YKTR000717";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Adi = "Engin";
            customer2.Soyadi = "Demiroğ";
            customer2.MusteriNumarasi = "YKTR000153";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Adi = "Sencer";
            customer3.Soyadi = "Mandıralı";
            customer3.MusteriNumarasi = "YKTR006161";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            return customers;
        }

        public void MusteriEkle(Customer customer)
        {
            if (customer.Id == -1)
            {
                Console.WriteLine("Müşteri Yok");
                return;
            }
            Console.WriteLine(customer.Adi + " " + customer.Soyadi + " Eklendi!");
            Console.WriteLine();
        }

        public void MusteriEkle(params Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Adi + " " + customer.Soyadi + " Eklendi!");
            }
            Console.WriteLine(customers.Length + " Müşteri Eklendi!");
            Console.WriteLine();
        }

        public void MusteriList(Customer[] customers)
        {
            Console.WriteLine("Listeleniyor");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Adi);
                Console.WriteLine(customer.Soyadi);
                Console.WriteLine(customer.MusteriNumarasi);
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*");
            }
            Console.WriteLine();
        }

        public void MusteriUpdate(ref Customer customer, string Adi, string Soyadi, string MusteriNumarasi)//update işlemi gerçekleşmesi için kullanıcının değeri olması lazım out yerine ref bu yüzden kullandım veri tabanımdaki tüm kolonlar not null (boş olamaz) olarak işaretli, senaryo oluşturdum.
        {
            customer.Adi = Adi;
            customer.Soyadi = Soyadi;
            customer.MusteriNumarasi = MusteriNumarasi;
            Console.WriteLine("Güncelleme İşlemi Tamamlandı!");
        }

    }
}
