using System.ComponentModel.DataAnnotations;
namespace Teste.Models
{
    public class OrderDetail
    {
        public int orderId { get; set; }
        //public IList<Product> productoList { get; set; }
        public Product productoList { get; set; }
        public double Amount { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
    }
}
