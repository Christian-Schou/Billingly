using System;
using System.Linq.Expressions;
using Billingly.Data.Repositories.Base;
using Billingly.Entities.Invoice;
using Billingly.Services;
using Billingly.WEB.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Billingly.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerService
    {
        public CustomerRepository(ApplicationDbContext appDbContext)
            : base(appDbContext)
        {
        }

        public void CreateCustomer(Customer customer)
        {
            Create(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            Delete(customer);
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await FindAll()
                .OrderBy(customer => customer.Name)
                .ToListAsync();
        }

        public IEnumerable<SelectListItem> GetAllCustomersForDropDown()
        {
            return FindAll().Select(customer => new SelectListItem
            {
                Text = customer.Name,
                Value = customer.Id.ToString()
            });
        }


        public async Task<Customer> GetCustomerByIdAsync(int customerId)
        {
            return await FindByCondition(customer => customer.Id.Equals(customerId))
                .FirstOrDefaultAsync();
        }

        public void UpdateCustomer(Customer customer)
        {
            Update(customer);
        }
    }
}

