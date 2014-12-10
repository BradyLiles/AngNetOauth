using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJSAuthentication.API.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ShippedCity { get; set; }
        public Boolean IsShipped { get; set; }
        public static List<Order> CreateOrders()
        {
            List<Order> orderList = new List<Order>()
            {
                new Order { OrderId = 1, CustomerName = "First1 Last1", ShippedCity = "City1", IsShipped = true },
                new Order { OrderId = 2, CustomerName = "First2 Last2", ShippedCity = "City2", IsShipped = false },
                new Order { OrderId = 3, CustomerName = "First3 Last3", ShippedCity = "City3", IsShipped = false },
                new Order { OrderId = 4, CustomerName = "First4 Last4", ShippedCity = "City4", IsShipped = false },
                new Order { OrderId = 5, CustomerName = "First5 Last5", ShippedCity = "City5", IsShipped = true },
            };
            return orderList;
        } 
    }
}
