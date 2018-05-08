using RepositoryDatabaseAccess.Domain.Repositories;
using RepositoryDatabaseAccess.WebAppDemo.Demo.DbContext;
using RepositoryDatabaseAccess.WebAppDemo.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryDatabaseAccess.WebAppDemo.Demo.Repositories
{
    public class CompanyRepository : BaseRepository<DemoDbContext, Company>
    {
        public CompanyRepository() : base(new DemoDbContext())
        {
        }

        public override void Add(Company entity)
        {
            if (Entities.Any(x => x.CompanyName == entity.CompanyName))
            {
                throw new Exception("Company name must be unique");
            }
            base.Add(entity);
        }
    }
}