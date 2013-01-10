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
        // GET: api/lookups/employees
        [ActionName("Categories")]
        public IEnumerable<Category> GetCategories()
        {
            return Uow.Categories.GetAll().OrderBy(r => r.CategoryName);
        }
    }
}
