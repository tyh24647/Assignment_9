using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_9.Models;

namespace Assignment_9.Services {
    public interface IGargoyleDatabase {
        Dictionary<string, GargoyleModel> All { get; set; }
        //Dictionary<string, GargoyleModel> GetAll();
        string Id { get; set; }
        GargoyleModel Gargoyle(string id);
    }
}
