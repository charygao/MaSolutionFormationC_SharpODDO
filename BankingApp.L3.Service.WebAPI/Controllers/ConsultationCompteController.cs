﻿using BankingApp.L2.Business.Facade;
using BankingApp.L2.Business.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankingApp.L3.Service.WebAPI.Controllers
{
    public class ConsultationCompteController : ApiController
    {
        private ICompteBusiness business = new CompteBusinessImpl();


        // GET api/values
        public decimal Get(string numero)
        {
            return business.ConsulterSolde(numero);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
