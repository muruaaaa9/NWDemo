using System.Web.Http;
using NWDemo.Data.Contracts;

namespace NWDemo.Web.Controllers
{
    public abstract class ApiBaseController : ApiController
    {
        protected INWDemoUow Uow { get; set; }
    }
}