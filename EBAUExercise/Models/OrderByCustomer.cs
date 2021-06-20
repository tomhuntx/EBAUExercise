using System;

namespace EBAUExercise.Models
{
    public class OrderByCustomer
    {
        public int CustomerId { get; set; }
        public int OrderCount { get; set; }
        public decimal OrderTotal { get; set; }

        public OrderByCustomer(int customerId, int orderCount, decimal total)
        {
            CustomerId = customerId;
            OrderCount = orderCount;
            OrderTotal = total;
        }
    }
}