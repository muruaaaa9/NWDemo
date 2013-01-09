using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using NWDemo.Data.Contracts;

namespace NWDemo.Web.Controllers
{
    public abstract class ApiBaseController : ApiController
    {
        protected INWDemoUow Uow { get; set; }
    }
}
