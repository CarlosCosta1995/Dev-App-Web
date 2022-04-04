using System.Collections.Generic;
using Teste.Models;

namespace Teste.Data
{
    public class StoreDBInitializer
    {
        public static void InsertData(StoreContext context) // 5.c
        {
            /* public int productId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int Stock { get; set; }
            public double Price { get; set; } */
            var Milk = new Product
            {
                Name = "Mimosa",
                Description = "Leite",
                Stock = 75,
                Price = 0.30,
            };
            context.products.Add(Milk);

            var Mushroom = new Product
            {
                Name = "Cogumelos",
                Description = "Asiaticos",
                Stock = 30,
                Price = 0.50,
            };
            context.products.Add(Mushroom);

            /* public int orderId { get; set; }
            public IList<Product> productoList { get; set; }
            public double Amount { get; set; }
            public DateTime OrderDate { get; set; }*/

            //OrderDetail orderDetail = new OrderDetail
            //{
            //    productoList =
            //    {
            //        Mushroom,
            //        Milk,
            //    },
            //    productoList = Mushrooms,
            //    Amount = 25,
            //    OrderDate = DateTime.Now,
            //};
            //context.orderDetails.Add(orderDetail);

            context.orderDetails.Add(new OrderDetail
            {
                //productoList =
                //{
                //    Mushroom,
                //    Milk,
                //},
                productoList = Mushroom,
                Amount = 25,
                OrderDate = DateTime.Now,
            });

            context.SaveChanges();
        }
    }
}

