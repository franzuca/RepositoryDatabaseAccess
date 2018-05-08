using RepositoryDatabaseAccess.Context;
using RepositoryDatabaseAccess.WebAppDemo.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryDatabaseAccess.WebAppDemo.Demo.DbContext
{
    public class DemoDbContext : BaseDbContext<DemoDbContext>
    {
        public DemoDbContext() : base("DemoDbEntities")
        {

        }

        public DbSet<Client> Client { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Currency> Currency { get; set; }
    }
}