<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="presentation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Presentation</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" 
        crossorigin="anonymous"/>
</head>

<body>
     <h2 class="accordion"> Customer Form </h2>
    <form id="form1" runat="server">
        <asp:Label ID="CID" runat="server" Text="Customer ID : " Width="100px"></asp:Label>
            <asp:TextBox ID="Customerid" runat="server" Enabled="False" Width="150px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Contact Name" Width="150px" Height="20px"></asp:Label>
        <asp:TextBox ID="Number" runat="server" Width="150px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Address " Width="100px"></asp:Label>
            <asp:TextBox ID="customeraddress" runat="server" Width="150px"></asp:TextBox>
            <asp:Label ID="ContactName" runat="server" Text="Contact number" Width="150px" Height="20px"></asp:Label>
            <asp:TextBox ID="contactnumber" runat="server" Width="150px" Wrap="False"></asp:TextBox>
            
        </p>
        <asp:DataList ID="DataList1" runat="server">
        </asp:DataList>
    
        <h3>Change Customer Data</h3>
        <asp:Button ID="Lastcustomer" runat="server" OnClick="LastCustomer" Text="Last " Width="120px" />
        <asp:Button ID="Firstcustomer" runat="server" OnClick="FirstCustomer" Text="First" Width="120px" />
        <asp:Button ID="NextCustomer" runat="server" OnClick="NextCustomers" Text="Next" Width="120px" />
        <asp:Button ID="PreviousCustomer" runat="server" OnClick="PreviousCustomers" Text="Previous" Width="120px" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
            SelectCommand=""></asp:SqlDataSource>
    
        <asp:Button ID="Editcustomer" runat="server" Text="Edit" OnClick="EditCustomer" Width="120px" />
        <asp:Button ID="SaveCustomer" runat="server" Text="Save" OnClick="SaveACustomer" Width="120px" />
        <asp:Button ID="DeleteCustomer" runat="server" Text="Delete" OnClick="DeleteCustomerr" Width="120px" />
        <asp:Button ID="Newcustomer" runat="server" OnClick="Newcustomers" Text="New" Width="120px" />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        

        
        <asp:DropDownList ID="ProductsNme" DataValueField="ProductName"  runat ="server" OnSelectedIndexChanged="ProductsNameSelect" AutoPostBack="true" ReadOnly="true" >
            <asp:ListItem Text=" Select Products" Value="-1"></asp:ListItem>
            <asp:ListItem Text></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="PlaceOrder" runat="server" Text="Place-Order" OnClick="PlaceAOrder" Width="120px" />


        <asp:Button ID="ViewMoreProducts" runat="server" Text="More Products" OnClick ="MoreProducts" Width="120px" />
        <asp:Button ID="PreviousButton" runat="server" Text="Previous Products" OnClick="PreviousProductsButton" />

        <p>
            &nbsp;</p>


        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Result" runat="server" Text="Label"></asp:Label>


    </form>

</body>

</html>
