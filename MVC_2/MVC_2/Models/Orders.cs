using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_2.Models
{
    public class Orders
    {
        public Orders()
        {

            OrderDetail = new List<OrderDetails>();
        }
        public int OrdersId { get; set; }

        public int UsersId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("UsersId")]
        public virtual Users user { get; set; }
        public float amount { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }

    

        [DataType(DataType.MultilineText)]
        public string BillAddress { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCity { get; set; }
        public string BillState { get; set; }
        public float OrderTax { get; set; }

        [DataType(DataType.PhoneNumber)]

        public string Phone { get; set; }
        public string Country { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        public string Orderdate { get; set; }

        public int OrderShipped { get; set; }
        public string OrderTrackingNumber { get; set; }

        
        public virtual ICollection<OrderDetails> OrderDetail { get; set; }
    }
}