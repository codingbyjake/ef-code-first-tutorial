using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_code_first_tutorial.Models {
    public class Order {
        //
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [StringLength(30)]
        public string? Description { get; set; } = null;
        [Column(TypeName = "decimal(7,2)")]
        public decimal Total { get; set; } 

        //Foreign Key Properties
        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        //adding other table lines as a prop
        public virtual ICollection<OrderLine> OrderLines { get; set; }

        //Constructors
        public Order() { }

    }
}
