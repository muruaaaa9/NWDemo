using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NWDemo.Data.Contracts;
using NWDemo.Model.Models;

namespace NWDemo.Web.Controllers
{
    public class LookupsController : ApiBaseController
    {
        public LookupsController(INWDemoUow uow)
        {
            Uow = uow;
        }
        // GET: api/lookups/categories
        [ActionName("Categories")]
        public IEnumerable<Category> GetCategories()
        {
            return Uow.Categories.GetAll().OrderBy(r => r.CategoryName);
        }

        //GET : api/lookups/products
        [ActionName("Products")]
        public IEnumerable<Product> GetProducts()
        {
            return Uow.Products.GetAll().OrderBy(p => p.ProductName);
        }

        //GET: api/lookups/customers
        [ActionName("Customers")]
        public IEnumerable<Customer> GetCustomers()
        {
            return Uow.Customers.GetAll().OrderBy(c => c.CustomerID);
        }
    }
}
