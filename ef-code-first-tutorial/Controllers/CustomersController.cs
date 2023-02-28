using ef_code_first_tutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_code_first_tutorial.Controllers {
    public class CustomersController {//begins class

        private readonly SalesDbContext _context;

        public CustomersController() {
            _context = new SalesDbContext();
        }

        public async Task<ICollection<Customer>> GetCustomers() {
            return await _context.Customers
                                    //.Include(x => x.Orders)
                                    .ToListAsync();
        }

        public async Task<Customer?> GetCustomer(int id) {
            return await _context.Customers
                                    .FindAsync(id);
        }

        public async Task<Customer> InsertCustomer(Customer cust) {
            _context.Customers.Add(cust);
            var changes = await _context.SaveChangesAsync();
            if(changes != 1) {
                throw new Exception("Insert Failed!");
            }
            return cust;

        }


    }//ends class
}
