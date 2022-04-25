using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Object
{
    class Import
    {
        string ImportID;
        public string Import_ID
        {
            get { return ImportID; }
            set { ImportID = value; }
        }
        string ProductID;
        public string Product_ID
        {
            get { return ProductID; }
            set { ProductID = value; }
        }
        string ProductName;
        public string Product_Name
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        DateTime ImportDate;
        public DateTime Import_Date
        {
            get { return ImportDate; }
            set { ImportDate = value; }
        }
        int Quantity;
        public int QuantityProduct
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        float Price;
        public float ProductPrice
        {
            get { return Price; }
            set { Price = value; }
        }
    }
}
