using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NWDemo.Model.Models;

namespace NWDemo.Data.Contracts
{
    public interface INWDemoUow
    {
        // Save pending changes to the data store.
        void Commit();

        // Repositories
        IRepository<Employee> Employees { get; }
    }
}
