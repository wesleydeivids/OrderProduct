using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProduct.Entities.Enums;
using System.Globalization;


namespace OrderProduct.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        
        public List<OrderItem> Items { get; set; }= new List<OrderItem>();

        public Order() 
        { 
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void Additem(OrderItem item) {
            Items.Add(item);
        }
        public void Removeitem(OrderItem item) {
            Items.Remove(item);
        }
        public double Total() {
            double sum = 0;
            foreach (OrderItem item in Items) {
               sum += item.Subtotal();
            
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status " + Status);
            sb.AppendLine("client " + Client);
            sb.AppendLine("Order items ");
            foreach (OrderItem item in Items) {
                sb.AppendLine(item.ToString());
            
            }
            sb.AppendLine("total price $ " + Total().ToString("f2",CultureInfo.InvariantCulture) );
            return sb.ToString();

            
        }

    }
}
