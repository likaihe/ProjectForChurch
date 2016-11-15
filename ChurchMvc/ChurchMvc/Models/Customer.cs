using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChurchMvc.Models
{
    public class Customer
    {
        public int Id { set; get; }
        public string Mail { set; get; }
        public string Name { set; get; }

        public List<Group> Groups { set; get; }
    }
}