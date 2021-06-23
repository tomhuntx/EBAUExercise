using System;
using System.Collections.Generic;

namespace EBAUExercise.Models
{
    /// <summary>
    /// Generic model class to access all order reports
    /// </summary>
    public class OrderReports
    {
        public ListModel<CustomerOrder> CustomerOrders { get; set; }
        public ListModel<OrderByCustomer> OrdersByCustomer { get; set; }
        public ListModel<OrderByDate> OrdersByDate { get; set; }
    }
}