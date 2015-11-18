using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_9.Models;

namespace Assignment_9.Services {
    public class GargoyleDatabase {

        private Dictionary<string, GargoyleModel> Gargoyles;

        private string Id { get; set; }

        private GargoyleModel Gargoyle(string id) {
            GargoyleModel outModel;

            if (Gargoyles.ContainsKey(id)) {
                //return Gargoyles.TryGetValue(id, out outModel);
            }

        }

    }
}
