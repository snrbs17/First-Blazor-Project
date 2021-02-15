using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using database.Models;

namespace database.Daos
{
    public class CustomerDao
    {
        public async Task<List<Customers>> GetCustomersAsync()
        {
            await using(var context = new DataContext())
            {
                var query = context.Customers.ToList();

                return query.ToList();
            }
        }
    }
}