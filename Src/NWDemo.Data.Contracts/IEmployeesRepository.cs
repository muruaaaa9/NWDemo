using System.Linq;
using NWDemo.Model.Models;

namespace NWDemo.Data.Contracts
{
    public interface IEmployeesRepository : IRepository<Employee>
    {
        IQueryable<Employee> GetEmployees();
    }
}