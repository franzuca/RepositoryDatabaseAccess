using RepositoryDatabaseAccess.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryDatabaseAccess.WebAppDemo.Demo.Entities
{
    public class Company : AuditoryEntity
    {
        public string CompanyName { get; set; }

        public IList<Client> Clients { get; set; }
    }
}