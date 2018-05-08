using RepositoryDatabaseAccess.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryDatabaseAccess.WebAppDemo.Demo.Entities
{
    public class Currency : AuditoryEntity
    {
        public string CurrencySymbol { get; set; }

        public string CurrencyName { get; set; }
    }
}