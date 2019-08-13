using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_PR
{
    public class OrderModel
    {
        public int Order_Id { get; set; }
        public int Customer_Id { get; set; }
        public string Date { get; set; }


        public OrderModel()
        {

        }

        public OrderModel(int Customer_Id, string Date)
        {
            this.Customer_Id = Customer_Id;
            this.Date = Date;
        }
    }
}
