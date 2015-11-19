using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Assignment_9.Services;
using Assignment_9.Models;

namespace Assignment_9.Controllers {
    [Route("api/[controller]")]
    public class GargoylesController : Controller {

        private IGargoyleDatabase database;

        public GargoylesController(IGargoyleDatabase database) {
            this.database = database;
        }
        
        [HttpGet]
        public IEnumerable<GargoyleModel> Get() {
            return database.All.Values;
        }
        
        [HttpGet("{id}")]
        public string Get(string id) {
            return database.Gargoyle(id).ToString();
        }

        [HttpPost]
        public void Post([FromBody] string value) {
            GargoyleModel model = null;
            database.All.Add(value, model);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody]string value) {
            GargoyleModel model = null;

            if (!database.All.ContainsKey(id)) {
                database.All.Add(id, model);
            }
        }

        [HttpDelete("{id}")]
        public void Delete(string id) {
            GargoyleModel model = null;

            if (database.All.TryGetValue(id, out model)) {
                database.All.Remove(id);
            }
        }
    }
}
