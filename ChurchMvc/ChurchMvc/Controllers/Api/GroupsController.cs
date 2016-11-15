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

        //GET/Api/GroupS/{action}
        public IHttpActionResult GetCustomers()
        {
            return Ok(_context.Customers.ToList());
        }

        public IHttpActionResult GetCustomersByGroup(int id)
        {
            return Ok(_context.Groups.Where(c => c.Id == id).SelectMany(c =>c.Customers).ToList());
        }

        public IHttpActionResult GetCustomerById(int id)
        {
            return Ok(_context.Customers.SingleOrDefault(c => c.Id == id));
        }

        public IHttpActionResult GetGroupById(int id)
        {
            return Ok(_context.Groups.SingleOrDefault(c => c.Id == id));
        }

        public IHttpActionResult GetGroups()
        {
            return Ok(_context.Groups.ToList());
        }

       
    }
}
