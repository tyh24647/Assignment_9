using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Assignment_9.Services;
using Assignment_9.Models;

namespace Assignment_9.Controllers {
    [Route("[controller]")]
    public class GargoylesController : Controller {

        private IGargoyleDatabase database;

        public GargoylesController(IGargoyleDatabase database) {
            this.database = database;
        }
        
        [HttpGet]
        public IEnumerable<GargoyleModel> Get() {
            //return database.All.Values;
            return database.GetAll().Values;
        }
        
        [HttpGet("{id}")]
        public GargoyleModel Get(string id) {
            return database.Gargoyle(id);
        }
        
        [HttpPost]
        public void Post([FromBody] string value) {
            GargoyleModel model = null;
            
            // TODO look at code for "add" from lecture
             
            //database.GetAll().Add(value, );
            //database.All.Add(value, model);
        }
        

        [HttpPatch]
        public void Patch(string id, [FromBody]string value) {
            // TODO look at code for "set" from lecture
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody]string value) {
            GargoyleModel model = null;

            if (!database.GetAll().ContainsKey(id)) {
                database.GetAll().Add(id, model);
            }
        }

        [HttpDelete("{id}")]
        public void Delete(string id) {
            GargoyleModel model = null;

            if (database.GetAll().TryGetValue(id, out model)) {
                database.GetAll().Remove(id);
            }
        }
    }
}
