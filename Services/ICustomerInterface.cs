using System;
using Billingly.Entities.Invoice;
using Billingly.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Billingly.WEB.Services
{
    public interface ICustomerService : IBaseService<Customer>
    {
        Task<IEnumerable<SelectListItem>> GetAllCustomersForDropDownAsync();
    }
}

