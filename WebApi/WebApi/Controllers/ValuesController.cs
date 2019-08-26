﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;

namespace WebApi.Controllers {
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController {
        LocacoaDB locacaoDB = new LocacoaDB();
        // GET api/values
        public List<Carros> Get() {
            return locacaoDB.Carros.ToList<Carros>();
        }
        /*
        public IEnumerable<string> Get() {
            return new string[] { "Café", "Cerveja Litrão" };
        }
        */
        // GET api/values/5
        public string Get(int id) {
            return new string[] { "Café", "Cerveja Litrão" }[id];
        }

        // POST api/values
        public void Post([FromBody]string value) {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/values/5
        public void Delete(int id) {
        }
    }
}
