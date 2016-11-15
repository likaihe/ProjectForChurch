using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChurchMvc.Models
{
    public class Group
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public List<Customer> Customers { set; get; }

    }
}