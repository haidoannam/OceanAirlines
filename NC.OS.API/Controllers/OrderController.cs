
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


        [Route("estimatePriceAndTotal")]
        [HttpPost]
        public HttpResponseMessage GetEstimatePriceAndTotal(OrderModel model)
        {
            HttpResponseMessage response = null;

            if (ModelState.IsValid)
            {
                var result = _orderService.GetEstimatePriceAndTotal(model);

                if (result != null)
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, result);
                }

            }
            else
                response = Request.CreateResponse(HttpStatusCode.BadRequest, new { success = false });

            return response;
        }
    }
}
