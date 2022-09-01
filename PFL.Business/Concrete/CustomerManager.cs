using Microsoft.EntityFrameworkCore.Query;
using PFL.Business.Abstract;
using PFL.Business.Request.Customer;
using PFL.Core.Abstract;
using PFL.Core.Authentication;
using PFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomer _customer;
        public CustomerManager(ICustomer customer)
        {
            _customer = customer;
        }
        
        public int Add(Customer entity)
        {
            return _customer.Add(entity);
        }

        public bool Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter = null, Func<IQueryable<Customer>, IIncludableQueryable<Customer, object>> includesPath = null)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null, Func<IQueryable<Customer>, IIncludableQueryable<Customer, object>> includesPath = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
