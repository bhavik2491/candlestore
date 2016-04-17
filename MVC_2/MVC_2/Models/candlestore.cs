using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_2.Models
{
    public class candlestore : System.Data.Entity.DbContext
    {
        public candlestore() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Candles> Candle { get; set; }

        public System.Data.Entity.DbSet<MVC_2.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<MVC_2.Models.Users> Users { get; set; }
    }
}