using System;
using Billingly.Entities.Invoice;
using Billingly.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Humanizer.In;

namespace Billingly.WEB.Services
{
    public interface ICustomerService : IBaseService<Customer>
    {
        IEnumerable<SelectListItem> GetAllCustomersForDropDown();
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int customerId);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}

