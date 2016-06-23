using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {     
                new Product { ID =1, Description="Cristal", Price=3.0, RegistrationDate= DateTime.Now},
                new Product { ID =2, Description="Cuzqueña", Price=0.0, RegistrationDate= DateTime.Now},
                new Product { ID =3, Description = "Pilsen", Price = 3.0, RegistrationDate=null },
                new Product { ID =4, Description = "producto1", Price = 3.0, RegistrationDate=null },
                new Product { ID =5, Description="producto2", Price=0.0, RegistrationDate= DateTime.Now}
            };

        }
    }
}
