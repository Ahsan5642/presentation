using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using WebService;
using WebService.IServices;

namespace presentation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private readonly ICustomers _customerservice;

       
        WebForm1(ICustomers customerservice)
        {
            _customerservice = customerservice;   
        }
        WebService1 webservice = new WebService1();
       // WebService1.Customers customers = new WebService1.Customers();
        static bool flag = true;
        static string selected = "";
        //static List<WebService.Products> productlist;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] customersdata = webservice.GetFirstCustomerData();
                var customerdata = _customerservice.GetAllCustomers();
                //customers = webservice.GetFirstCustomerData();
                //DisplayProducts();
                //Customerid.Text = customers.CustomerID;
                //Number.Text = customers.ContactName;
                //customeraddress.Text = customers.Address;
                //contactnumber.Text = customers.CustomerID;
                //ShowOrders();
                //Customerid.Text = customersdata[0]; 
                //Number.Text = customersdata[0]


            }
        }
        public void DisplayProducts()
        {
            //try
            //{
            //    productlist = webservice.GetProductss();
            //    ProductsNme.DataSource = productlist;
            //    ProductsNme.DataBind();

            //}
            //catch (Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Products not Loaded '"+exp.Message+"'')", true);
            //}
        }
        public void ShowOrders()
        {
            //try
            //{
            //    GridView2.DataSource = webservice.GetOrdersByCustomerr(Customerid.Text);
            //    GridView2.DataBind();
            //}

            //catch (Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No Orders to Show '" + exp.Message + "' ')", true);
            //    throw new Exception("Error Occurred");
            //}

        }

        private void DisplayLastCustomer()
        {
            //try
            //{
            //    customers = webservice.GetLastCustomers();
            //    Customerid.Text = customers.CustomerID;
            //    Number.Text = customers.ContactName;
            //    customeraddress.Text = customers.Address;
            //    contactnumber.Text = customers.Phone;
            //}
            //catch(Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('"+exp.Message+"')", true);
            //}


        }
        protected void EditCustomer(object sender, EventArgs e)
        {
            Number.Enabled = true;
            Number.ReadOnly = false;

            customeraddress.Enabled = true;
            customeraddress.ReadOnly = false;

            contactnumber.Enabled = true;
            contactnumber.ReadOnly = false;
           

        }

        protected void SaveACustomer(object sender, EventArgs e) 
        {
          
            //try
            //{
            //    webservice.SaveCustomerr(Customerid.Text, Number.Text, customeraddress.Text, contactnumber.Text, flag);
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Customer Saved')", true);
            //    ShowOrders();
            //}
            //catch(Exception exp)
            //{

            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", exp.Message, true);
            //}
        }
        protected void LastCustomer(object sender, EventArgs e)
        {
            //try
            //{
            //    DisplayLastCustomer();
            //    ShowOrders();

            //}
            //catch (Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + exp.Message + "')", true);
            //}

        }
        protected void FirstCustomer(object sender, EventArgs e)
        {

            //Customerid.ReadOnly = true;
            //Number.ReadOnly = true;
            //customeraddress.ReadOnly = true;
            //contactnumber.ReadOnly = true;
            //try
            //{
            //    customers = webservice.GetFirstCustomerData();
            //    Customerid.Text = customers.CustomerID;
            //    Number.Text = customers.ContactName;
            //    customeraddress.Text = customers.Address;
            //    contactnumber.Text = customers.Phone;
            //    ShowOrders();
            //    DisplayProducts();

            //}
            //catch(Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('"+exp.Message+"')", true);
            //}
            //DisplayProducts();
        }

        protected void NextCustomers(object sender, EventArgs e)
        {

            //try
            //{
            //    customers = webservice.GetNextCustomerr(Customerid.Text);
            //    Customerid.Text = customers.CustomerID;
            //    Number.Text = customers.ContactName;
            //    customeraddress.Text = customers.Address;
            //    contactnumber.Text = customers.Phone;
            //    ShowOrders();
            //    DisplayProducts();
            //}
            //catch (Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", exp.Message, true);

            //}

        }

        protected void PreviousCustomers(object sender, EventArgs e)
        {
            //try
            //{
            //    customers = webservice.LoadPreviousCustomerr(Customerid.Text);
            //    Customerid.Text = customers.CustomerID;
            //    Number.Text = customers.ContactName;
            //    customeraddress.Text = customers.Address;
            //    contactnumber.Text = customers.Phone;
            //    ShowOrders();
            //    DisplayProducts();
            //}
            //catch (Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + exp.Message + "')", true);
            //}
        }

        protected void Newcustomers(object sender, EventArgs e)
        {

            Customerid.Enabled = true;
            Customerid.ReadOnly = false;
            Customerid.Text = "";
            Number.Enabled = true;
            Number.ReadOnly = false;
            Number.Text = "";
            customeraddress.Enabled = true;
            customeraddress.ReadOnly = false;
            customeraddress.Text = "";
            contactnumber.Enabled = true;
            contactnumber.ReadOnly = false;
            contactnumber.Text = "";
            flag = false;
            //ShowOrders();
            //DisplayProducts();
            

        }

        protected void DeleteCustomerr(object sender, EventArgs e)
        {
            //try
            //{
            //    string mes = webservice.DeleteCustomerr(Customerid.Text);
            //    Result.Text = mes;
            //    Customerid.Text = "";
            //    Number.Text = "";
            //    customeraddress.Text = "";
            //    contactnumber.Text = "";
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Customer Deleted')", true);
            //    ShowOrders();
            //}
            //catch (Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + exp.Message + "')", true);

            //}

        }

        protected void PlaceAOrder(object sender, EventArgs e)
        {
            //try
            //{
            //    webservice.SaveOrderr(Customerid.Text, webservice.GetsProductID(selected));
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Order Placed')", true);
            //    ShowOrders();
            //}
            //catch(Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + exp.Message + "')", true);

            //}

        }
    
        protected void ProductsNameSelect(object sender, EventArgs e)
        {
            //try
            //{ 
            //    selected =  ProductsNme.SelectedItem.Value;
            //}
            //catch (Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + exp.Message + "')", true);
            //}

        }
        protected void MoreProducts(object sender, EventArgs e)
        {
            //try
            //{
            //    if (webservice.GetNextProducts(productlist[19].ProductID) == null)
            //    {
            //        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No More Products to View')", true);
            //        DisplayProducts();
            //    }
            //    productlist = webservice.GetNextProducts(productlist[19].ProductID);
            //    ProductsNme.DataSource = productlist;
            //    ProductsNme.DataBind();
            //}
            //catch (Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + exp.Message + "')", true);
            //}

        }
        protected void PreviousProductsButton(object sender, EventArgs e)
        {
            
            //try
            //{
            //    productlist = webservice.PreviousProduct(productlist[0].ProductID);

            //    ProductsNme.DataSource = productlist;
            //    ProductsNme.DataBind();

            //}
            //catch(Exception exp)
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + exp.Message + "')", true);
            //}
        }
    }
}

