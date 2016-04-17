using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_2.Models
{
    public class Users
    {
        public Users()
        {
            order = new List<Orders>();
        }
        public int UsersId { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }
        public int EmailVerified { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Country { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string UserIp { get; set; }
        [DataType(DataType.DateTime)]
        public string creation_date { get; set; }

        public virtual ICollection<Orders>order { get; set; }
    }
}