using System.Data.Entity;
using System.Linq;
using NWDemo.Data.Contracts;
using NWDemo.Model.Models;

namespace NWDemo.Data.Repositories
{
    public class EmployeesRepository : EFRepository<Employee>, IEmployeesRepository
    {
        public EmployeesRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Employee> GetEmployees()
        {
            return (IQueryable<Employee>) DbContext
                                    .Set<Employee>()
                                    .ToList();
        }
    }
}