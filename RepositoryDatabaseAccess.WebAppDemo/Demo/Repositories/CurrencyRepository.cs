using RepositoryDatabaseAccess.Domain.Repositories;
using RepositoryDatabaseAccess.WebAppDemo.Demo.DbContext;
using RepositoryDatabaseAccess.WebAppDemo.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryDatabaseAccess.WebAppDemo.Demo.Repositories
{
    public class CurrencyRepository : BaseRepository<DemoDbContext, Currency>
    {
        public CurrencyRepository() : base(new DemoDbContext())
        {
        }
    }
}