using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_code_first_tutorial.Models {
    public class OrderLine {
        //PK
        public int Id { get; set; }

        //reg props
        public int Quantity { get; set; } = 1;

        //FK's
        public int OrderId { get; set; }
        public virtual Order Order { get; set; } = null!;//property that allows us to see associated Order
        public int ItemID { get; set; }
        public virtual Item Item { get; set; } = null!;

        //Contructors
        public OrderLine() { }
    }
}
