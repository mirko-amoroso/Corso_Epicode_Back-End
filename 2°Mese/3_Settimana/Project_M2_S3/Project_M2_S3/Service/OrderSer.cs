using Project_M2_S3.Context;
using Project_M2_S3.Interfacce;
using Project_M2_S3.Models.Entity;
using Project_M2_S3.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Project_M2_S3.Service
{
    public class OrderSer : IOrder
    {
        private readonly DataContext DContext;

        public OrderSer(DataContext context)
        {
            DContext = context;
        }
        public void Save(ListProductEccAddress Pizze, int idU)
        {
            Order ordine = new Order
            {
                UserId = idU,
                Address = Pizze.address,
                PlacedAt = Pizze.placedAt,
                Done = Pizze.done,
                Notes = Pizze.notes

            };
            DContext.Orders.Add(ordine);
            DContext.SaveChanges();
            foreach (var item in Pizze.listaClasse)
            {
                OrderItem a  = new OrderItem
                {
                    ProductId = item.Id,
                    OrderId = ordine.Id,
                    Quantity = item.quantita
                };
                DContext.orderItems.Add(a);
                DContext.SaveChanges();
            }

        }

        public IEnumerable<Tutto> GetAll()
        {
            List<Tutto> result = new List<Tutto>();
            List<Order> orders = new List<Order>();
            orders = DContext.Orders.ToList();
            foreach (Order order in orders) 
            {
                List<ProdQuant> products = new List<ProdQuant>();

                List<OrderItem> a = DContext.orderItems.Where(oi => oi.OrderId == order.Id).ToList();
                for (int i = 0; i < a.Count; i++) {
                   
                    var b = DContext.Products.Where(bi => bi.Id == a[i].ProductId).First();
                    ProdQuant d = new ProdQuant
                    {
                        Id = b.Id,
                        Name = b.Name,
                        Price = b.Price,
                        Photo = b.Photo,
                        DeliveryTimeInMinutes = b.DeliveryTimeInMinutes,
                        Quant = a[i].Quantity
                    };
                    products.Add(d);
                }
                result.Add(new Tutto
                {
                    ordine = order,
                    productss = products
                });

            }
            return result;
        }

        public void Update(int id)
        {
            var selezionatore = DContext.Orders.Where(d => d.Id == id).First();
            if (selezionatore != null)
            {
                selezionatore.Done = true;
                DContext.SaveChanges();
            }
        }
    }
}
