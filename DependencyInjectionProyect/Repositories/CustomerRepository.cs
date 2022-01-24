using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionProyect.Repositories
{
    public class CustomerRepository :IRepository
    {
        private IDbConnection _connection;

        public CustomerRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<Customer> GetCustomers()
        {
            if (_connection.GetType() == typeof(MySQLConnection))
                Console.WriteLine("Get Customers from MySQL");
            else if (_connection.GetType() == typeof(OracleConnection))
                Console.WriteLine("Get Customers from Oracle");
            return new List<Customer>
            {
                new Customer() {Id=1, Name ="John Wick", Email="john@wick.com", Phone="0273487620"},
                new Customer() {Id=2, Name ="Clint Eastwood", Email="clint@wick.com", Phone="0273487672"}
            };
        }
    }
}
