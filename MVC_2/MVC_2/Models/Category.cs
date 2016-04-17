using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_2.Models
{
    public class Category
    {
        public Category()
        {
            candle = new List<Candles>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Candles> candle { get; set; }
    }
}