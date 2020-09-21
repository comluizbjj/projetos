using ModuloIX.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ModuloIX.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; } = new Client();
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        
        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0.00;
            foreach(OrderItem lista in Items)
            {
                total = lista.SubTotal() + total;
            }
            return total;
        }
        public override string ToString()
        {

            StringBuilder dados = new StringBuilder();
            
            foreach (OrderItem lista in Items)
            {
                dados.Append(lista.Product.Name);
                dados.Append(", Quantity: ");
                dados.Append(lista.Quantity);
                dados.Append(", Subtotal: $");
                dados.Append(lista.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                dados.AppendLine(" ");
            }            
            return dados.ToString();
        }

    }
}
