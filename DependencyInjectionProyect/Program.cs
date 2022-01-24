using DependencyInjectionProyect.Repositories;
using DependencyInjectionProyect.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dependencies
            var sender = new SMSService();
            var connection = new OracleConnection();
            var repository = new CustomerRepository(connection);

            var customerService = new CustomerService(repository);
            var communicationService = new CommunicationService(sender);

            var customers = customerService.GetCustomers();
            var message = "Message to broadcast to all customers";

            foreach(var customer in customers)
            {
                communicationService.SendMessage(customer, message);
            }
        }
    }
}
