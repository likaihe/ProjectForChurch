using ChurchMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChurchMvc.Controllers.Api
{
    public class GroupsController : ApiController
    {
        private ApplicationDbContext _context;

        private GroupsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET/Api/GROUP
        public IHttpActionResult GetCustomers()
        {
            return Ok(_context.Customers.ToList());
        }
    }
}
