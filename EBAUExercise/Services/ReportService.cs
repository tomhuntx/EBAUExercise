using EBAUExercise.Models;
using EBAUExercise.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EBAUExercise.Services
{
    public class ReportService
    {
        private readonly SampleDataRepository _sampleDataRepository;

        public ReportService(SampleDataRepository sampleDataRepository)
        {
            _sampleDataRepository = sampleDataRepository;

            CustomerReport();
            StoreDailyReport();
        }

        /// <summary>
        /// Build and output a list of data that breaks down the data by customer id, taking count of orders and summing 'order total'.
        /// </summary>
        private List<OrderByCustomer> CustomerReport()
        {
            var customerOrders = _sampleDataRepository.GetDataset;
            List<OrderByCustomer> customerHistory = new();

            // For every order in the list
            foreach (CustomerOrder order in customerOrders)
			{
                int customerId = order.CustomerId;

                // Attempt to find order history for this customer ID 
                int index = customerHistory.FindIndex(history => history.CustomerId == customerId);

                if (index != -1)
 				{ // Existing history for this customer is found, add the order to their total
                    customerHistory[index] = new OrderByCustomer(
                        customerId,
                        customerHistory[index].OrderCount + 1,
                        customerHistory[index].OrderTotal + order.OrderTotal
                    );
                }
                else
                { // Existing history for this customer is not found, create new history for them
                    customerHistory.Add(new OrderByCustomer(customerId, 1, order.OrderTotal));
				}
            }

            // Order the history by the customer ID in ascending order
            customerHistory = customerHistory.OrderBy(history => history.CustomerId).ToList();

            foreach (OrderByCustomer h in customerHistory)
            {
                Console.WriteLine("{0}, {1}, {2}", h.CustomerId, h.OrderCount, h.OrderTotal);
            }

            return customerHistory;
        }

        /// <summary>
        /// Build and output a list of data that shows the number of orders by date and a sum of 'order total'.
        /// </summary>
        private List<OrderByDate> StoreDailyReport()
        {
            var customerOrders = _sampleDataRepository.GetDataset;
            List<OrderByDate> customerHistory = new();

            // For every order in the list
            foreach (CustomerOrder order in customerOrders)
            {
                var orderDate = order.OrderDate.Date;

                // Attempt to find order history for this customer ID 
                int index = customerHistory.FindIndex(customer => customer.OrderDate == orderDate.ToString("dd/MM/yyyy"));

                if (index != -1)
                { // Existing history for this customer is found, add the order to their total
                    customerHistory[index] = new OrderByDate(
                        orderDate.ToString("dd/MM/yyyy"),
                        customerHistory[index].OrderCount + 1,
                        customerHistory[index].OrderTotal + order.OrderTotal
                    );
                }
                else
                { // Existing history for this customer is not found, create new history for them
                    customerHistory.Add(new OrderByDate(orderDate.ToString("dd/MM/yyyy"), 1, order.OrderTotal));
                }
            }

            // Order the history by the date in ascending order
            customerHistory = customerHistory.OrderBy(history => history.OrderDate).ToList();

            foreach (OrderByDate h in customerHistory)
            {
                Console.WriteLine("{0}, {1}, {2}", h.OrderDate, h.OrderCount, h.OrderTotal);
            }

            return customerHistory;
        }
    }
}