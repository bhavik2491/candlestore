using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVC_2.Models
{
    public class Candles
    {
        public Candles()
        {
            order = new List<OrderDetails>();

        }
        public int CandlesId { get; set; }
        public string catagory { get; set; }
        public string name { get; set; }
        public byte[] photo { get; set; }
        public string description { get; set; }
        public int price { get; set; }

   
        public string shortdecription { get; set; }

        [DataType(DataType.DateTime)]
        public string Updatedate { get; set; }

        public int qty { get; set; }

        public virtual ICollection<OrderDetails> order { get; set; }

        public int CategoryId { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("CategoryId")]
       

        public virtual Category catagories { get; set; }


    }
    


}