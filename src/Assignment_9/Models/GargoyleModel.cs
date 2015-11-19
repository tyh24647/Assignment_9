using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_9.Models {
    public class GargoyleModel {

        public DateTime Updated { get; private set; }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        public string Color { get; set; }

        [Required]
        [MinLength(1)]
        public string Size { get; set; }

        [Required]
        [MinLength(1)]
        public string Gender { get; set; }
        
        public string ETag {
            get {
                return "\"" + this.Updated.ToLongTimeString() + "\"";
            }
        }
        
        public void Update() {
            Updated = DateTime.UtcNow;
        }
    }
}
 