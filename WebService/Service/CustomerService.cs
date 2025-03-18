using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.IServices;

namespace WebService.Service
{
    public class CustomerService : ICustomers
    {
        private readonly CustomerController _customerController;

        public CustomerService(CustomerController customerController)
        {
            _customerController = customerController;

        }
        public List<Customers> GetAllCustomers()
        {
            try
            {
                _customerController.GetFirstCustomer();

            }
            catch(Exception exp)
            {


            }
           
            throw new NotImplementedException();
        }
    }
}