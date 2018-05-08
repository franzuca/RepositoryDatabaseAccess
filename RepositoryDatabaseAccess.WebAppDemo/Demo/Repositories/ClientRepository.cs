using RepositoryDatabaseAccess.Domain.Repositories;
using RepositoryDatabaseAccess.WebAppDemo.Demo.DbContext;
using RepositoryDatabaseAccess.WebAppDemo.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryDatabaseAccess.WebAppDemo.Demo.Repositories
{
    public class ClientRepository : BaseTenantRepository<DemoDbContext, Client, Company>
    {
        public ClientRepository(long tenantId) : base(new DemoDbContext(), tenantId)
        {
        }
    }
}