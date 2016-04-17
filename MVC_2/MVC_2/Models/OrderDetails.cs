using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_2.Models
{
    public class OrderDetails
    {
        public OrderDetails()
        {
            

        }
        public int OrderDetailsId { get; set; }

        public int OrdersId { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("OrdersId")]
        public virtual Orders order { get; set; }

        public int CandlesId { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("CandlesId")]
        public virtual Candles candle { get; set; }

        public string DetailName { get; set; }
        public float price { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }

        
        
    }
}