using System;

namespace EBAUExercise.Models
{
    public class OrderByDate
    {
        public string OrderDate { get; set; }
        public int OrderCount { get; set; }
        public decimal OrderTotal { get; set; }

        public OrderByDate(string orderDate, int orderCount, decimal total)
        {
            OrderDate = orderDate;
            OrderCount = orderCount;
            OrderTotal = total;
        }
    }
}