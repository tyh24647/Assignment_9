using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_9.Models;

namespace Assignment_9.Services {
    public class GargoyleDatabase : IGargoyleDatabase {

        public Dictionary<string, GargoyleModel> All = new Dictionary<string, GargoyleModel>();

        public string Id { get; set; }

        public GargoyleDatabase() {
            //
            // TODO figure out constructor
            //
            // needs "at least two values"
            //
        }

        public GargoyleModel Gargoyle(string id) {
            GargoyleModel model = null;
            if (All.TryGetValue(id, out model)) {
                return model;
            }
            return null;
        }

        public void Add(string id, GargoyleModel model) {
            All.Add(id, model);
        }

        public Dictionary<string, GargoyleModel> GetAll() {
            return All;
        }

    }
}
