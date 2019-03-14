using NC.OS.API.Models;
using NC.OS.Model;
using NC.OS.Services.Interface;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NC.OS.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        public UserController(IUserService userService, IOrderService orderService)
        {
            _userService = userService;
            _orderService = orderService;
        }

        [Route("login")]
        [HttpPost]
        public HttpResponseMessage Login(LoginModel user)
        {
            HttpResponseMessage response = null;

            if (ModelState.IsValid)
            {
                var result = _userService.Login(user.Username, user.Password);
             

                if (result != null)
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, new { success = true });
                }
                else
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, new { success = false });
                }

                
            }
            else
                response = Request.CreateResponse(HttpStatusCode.BadRequest, new { success = false });

            return response;
        }
    }
}
