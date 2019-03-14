
using NC.OS.Model;
using NC.OS.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NC.OS.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/order")]
    public class OrderController : ApiController
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }


        [Route("Estimate")]
        [HttpGet]
        public HttpResponseMessage GetEstimatePriceAndTotal(string from, string to, double weight, double height, double depth, double breadth)
        {
            HttpResponseMessage response = null;

            var packageModel = new PackageModel
            {
                From = from,
                To = to,
                Weight = weight,
                Breadth = breadth,
                Depth = depth,
                Height = height
            };

            var result = _orderService.GetEstimatePriceAndTotal(packageModel);

            if (result != null)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            }

            response = Request.CreateResponse(HttpStatusCode.OK, result);

            return response;
        }


    }
}
