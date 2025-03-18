using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orders
    {
        public int OrderID { get; set; }

        public string CustomerID { get; set; }

        public string EmployeeID { get; set; }

        public string ShipVia { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipRegion { get; set; }
        
        public DateTime OrderDate { get; set; }

    }
}
