using Teste.Models;

namespace Teste.Services
{
    public interface IOrderDetailService
    {
        public abstract IEnumerable<OrderDetail> GetAll();
        public abstract OrderDetail Create(OrderDetail newOrder);
        public abstract IEnumerable<Product> GetProducts(int orderId);
        public abstract void DeleteById(int oderId);
        public abstract OrderDetail GetById(int oderId);
        public abstract void Update(int oderId, OrderDetail updateOrder);
        public abstract void UpdateAmout(int orderId, double amout);
        
    }
}
