using Newtonsoft.Json;
using RepositoryDatabaseAccess.WebAppDemo.Demo.Entities;
using RepositoryDatabaseAccess.WebAppDemo.Demo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryDatabaseAccess.WebAppDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCurrency(string currencyName, string currencySymbol)
        {
            Currency currency = new Currency()
            {
                CurrencyName = currencyName,
                CurrencySymbol = currencySymbol
            };
            CurrencyRepository currencyRepository = new CurrencyRepository();
            currencyRepository.Add(currency);
            currencyRepository.PersistChanges();

            Currency dbCurrency = currencyRepository.Get(currency.Id);

            return Content($"Inserted currency id: {dbCurrency.Id}");
        }

        public ActionResult GetAllCurrencies()
        {
            CurrencyRepository currencyRepository = new CurrencyRepository();
            IList<Currency> currencies = currencyRepository.List();
            return Content(JsonConvert.SerializeObject(currencies));
        }

        public ActionResult CreateCompany(string companyName)
        {
            if (string.IsNullOrEmpty(companyName))
            {
                throw new Exception("Specify a company name");
            }
            Company company = new Company()
            {
                CompanyName = companyName
            };

            CompanyRepository companyRepository = new CompanyRepository();
            companyRepository.Add(company);
            companyRepository.PersistChanges();
            return Content(JsonConvert.SerializeObject(company));
        }

        public ActionResult AddClient(long companyId, string clientName)
        {
            Client client = new Client()
            {
                TenantID = companyId,
                ClientName = clientName
            };
            ClientRepository clientRepository = new ClientRepository(companyId);
            clientRepository.Add(client);
            clientRepository.PersistChanges();
            return Content(JsonConvert.SerializeObject(client));
        }

        public ActionResult ListCompanyClients(long companyId)
        {
            ClientRepository clientRepository = new ClientRepository(companyId);
            IList<Client> tenantClients = clientRepository.List();
            return Content(JsonConvert.SerializeObject(tenantClients));
        }
    }
}