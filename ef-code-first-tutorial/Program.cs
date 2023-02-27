
using ef_code_first_tutorial;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;


//********initialize _context db pick an order and get all the orderlines their items and price
//********then multiply the quantity
var _context = new SalesDbContext();
var order = _context.Orders
                    .Include(x => x.OrderLines)
                        .ThenInclude(x => x.Item)
                    .Include(x => x.Customer)
                    .Single(x => x.Id == 4);


Console.WriteLine($"ORDER: Description: {order.Description}");
foreach(var ol in order.OrderLines) {
    Console.WriteLine($"ORDERLINE: Product: {ol.Item.Name}, " +
                         $"Quantity: {ol.Quantity}," +
                         $" Price: {ol.Item.Price:C}, " +
                         $"Line total: {ol.Quantity*ol.Item.Price:C}");

}
var orderTotal = order.OrderLines.Sum(ol => ol.Item.Price * ol.Quantity);
Console.WriteLine($"Total: {orderTotal:C}");


//Console.WriteLine($"OrderID: {order}");




//********initialize a _context copy of database and write to screen all customer names
//var _context = new SalesDbContext();
//_context.Customers.ToList().ForEach(c => Console.WriteLine(c.Name));