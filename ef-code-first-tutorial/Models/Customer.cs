using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_code_first_tutorial.Models {
    public class Customer {//start class
        //Class properties
        public int Id { get; set; } = 0;
        [StringLength(50)]
        [Required]
        public string Name { get; set; } = string.Empty;
        [StringLength(30)]
        [Required]
        public string City { get; set; } = string.Empty;
        [StringLength(2)]
        //[Required] new C# now defaults to non-nullable aka required so this isn't needed anymore
        public string StateCode { get; set; } = "OH"; //OH will be default value if not set manually
        [Column(TypeName = "decimal(9,2)")]
        public decimal Sales { get; set; }
        public bool Active { get; set; } = true;

        //default constructor
        public Customer() { }



    }//end class
}
