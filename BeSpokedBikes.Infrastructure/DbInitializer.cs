using BeSpokedBikes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Infrastructure
{
    public class DbInitializer
    {
        public static void Initialize(BSBContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Products.Any())
            {


                var products = new List<Product>();

                for (int i = 0; i < 10; i++) context.Products.Add(new Product { Name = $"Super Bike {i + 1}", Style = "White", SalePrice = 10.00M * (i + 1), PurchasePrice = 10.00M * (i + 1), Manufacturer = $"Company {i + 1}", CommissionPercentage = .05M, Quantity = 1 });

                foreach (Product s in products) context.Products.Add(s);
            }

            //var addresses = new List<Address>();

            //var address = new Address { StreetAddress = "321 Maple Street", City = "Atlanta", State = "GA", PostalCode = "30360" };

            //if (!context.Addresses.Any()) addresses.Add(address);

            var customers = context.Customers.ToList();
            var salesPeople = context.SalesPeople.ToList();
            customers[0].Contact.Address.State = "MI";
            salesPeople[0].Contact.Address.State = "MI";

            //if (context.Contacts.Any()) return;

            context.SaveChanges();
        }
    }
}
