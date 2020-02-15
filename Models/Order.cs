using System;

namespace BakerApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public DateTime CreatedDate { get; set; }
        public OrderStatus Status { get; set; }

    }
}