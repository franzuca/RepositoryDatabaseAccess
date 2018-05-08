using RepositoryDatabaseAccess.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryDatabaseAccess.WebAppDemo.Demo.Entities
{
    public class Client : TenantAuditoryEntity<Company>
    {
        public string ClientName { get; set; }
    }
}