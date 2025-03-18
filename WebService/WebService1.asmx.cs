using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DAL;
using Model;
namespace WebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1 : System.Web.Services.WebService
    {
        Customers customer = new Customers();
        
        OrderController order = new OrderController();
        CustomerController customercontroller = new CustomerController();
        ProductController productController = new ProductController();
        
        ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
        //public string GetCustomersData()
        //{
        //    customer = customercontroller.GetFirstCustomer();

        //}
        
        //[WebMethod]
        //public int GetsProductID(string productname)
        //{
        //    int productid = productController.GetProductID(productname);
        //    return productid;
        //}
        //[WebMethod]
        //public List<Products> GetProductss()
        //{

        //   // return productController.GetProducts();

        //}
        //[WebMethod]
        //public List<Orders> GetOrdersByCustomerr(string customerid) {

        //  // return order.GetOrdersByCustomer(customerid);
        //}
        [WebMethod]
        public string[] GetFirstCustomerData()
        {
            string[] customerdata = customercontroller.GetFirstCustomer();
            customer.CustomerID = customerdata[0];
            customer.ContactName = customerdata[0];

            return customerdata;
            
        }
        [WebMethod]
        public Customers GetLastCustomers()
        {

            Customers customers = customercontroller.GetLastCustomer();
            return customers;
        }
        //[WebMethod]
        //public Customers GetNextCustomerr(string ID)
        //{

        //    Customers customers = customercontroller.LoadNextCustomer(ID);
        //    return customers;

        //}
        //[WebMethod]
        //public Customers LoadPreviousCustomerr(string id)
        //{

        //    Customers customers = customercontroller.LoadPreviousCustomer(id);
        //    return customers;

        //}
        //[WebMethod]
        //public void DeleteCustomerOrderr(string id)
        //{
        //    order.DeleteCustomerOrder(id);

        //}
        //[WebMethod]
        //public void DeleteCustomerDemoo(string id)
        //{
        //    customercontroller.DeleteCustomerDemo(id);
        //}
        //[WebMethod]
        //public string DeleteCustomerr(string id)
        //{
        //    DeleteCustomerOrderr(id);
        //    DeleteCustomerDemoo(id);
        //    string message = customercontroller.DeleteCustomer(id);
        //    return message;
        //}
        //[WebMethod]
        //public void SaveCustomerr(string customerid, string contactname, string address, string contactnumber, bool flag)
        //{
        //    customercontroller.SaveCustomer(customerid, contactname, address, contactnumber, flag);
        //}
        //[WebMethod]
        //public void CreateNewCustomerr(string customerID, string contactname, string address, string contactnumber)
        //{
        //    customercontroller.CreateNewCustomer(customerID, contactname, address, contactnumber);
        //}
        //public void SaveOrderr(string customerid, int productID)
        //{
        //    order.SaveOrder(customerid, productID);
        //}
        //[WebMethod]
        //public List<Products> GetNextProducts(int nextproducts)
        //{
        //    return productController.GetNextProducts(nextproducts);
        //}
        //[WebMethod]
        //public List<Products> PreviousProduct(int productid)
        //{
        //    return productController.PreviousProducts(productid);
        //}
    }
}
