using Teste.Models;

namespace Teste.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly StoreContext context;
        public OrderDetailService(StoreContext _context)
        {
            this.context = _context;
        }

        public OrderDetail Create(OrderDetail newOrder)
        {
            OrderDetail newOrderDetails = context.orderDetails.Find(newOrder.orderId);

            if (newOrderDetails is not null)
            {
                return null;
            }
            else
            {
                context.orderDetails.Add(newOrder);
                context.SaveChanges();
                return newOrder;
            }
        }

        public void DeleteById(int oderId)
        {
            var deleteOrder = context.orderDetails.Find(oderId);
            if (deleteOrder != null)
            {
                context.orderDetails.Remove(deleteOrder);
            }
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            var allOrders = context.orderDetails.AsEnumerable();
            return allOrders;
        }

        public OrderDetail GetById(int oderId)
        {
            var orderById = context.orderDetails.SingleOrDefault(order => order.orderId == oderId);
            if (orderById != null)
            {
                return orderById;
            }
            else
            {
                throw new NotImplementedException("Nao order com este id!");
            }
        }

        public IEnumerable<Product> GetProducts(int orderId)
        {
            var ordersWithProducts = context.orderDetails.Where(p => p.orderId == orderId).AsEnumerable();
            if (ordersWithProducts is null)
            {
                throw new NotImplementedException("Nao eexistem produtos");
            }
            else
            {
                return (IEnumerable<Product>)ordersWithProducts;
            }
        }

        public void Update(int oderId, OrderDetail updateOrder)
        {
            var orderToUpdate = context.orderDetails
                .SingleOrDefault(ord => ord.orderId == oderId);

            if (orderToUpdate == null)
            {
                throw new NotImplementedException("Order dont exist!");
            }
            else
            {
                //Product products = context.orderDetails.Find(updateOrder.productoList);
                orderToUpdate.Amount = updateOrder.Amount;
                orderToUpdate.OrderDate = updateOrder.OrderDate;
                orderToUpdate.productoList = updateOrder.productoList;

                context.SaveChanges();
            }
        }

        public void UpdateAmout(int orderId, double amout)
        {
            var orderToUpdateAmout = context.orderDetails.SingleOrDefault(order => order.orderId == orderId);
            if (orderToUpdateAmout is not null)
            {
                orderToUpdateAmout.Amount = amout;
                context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("Nao existem orders");
            }
        }
    }
}
