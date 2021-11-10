using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qna.Services;
using Qna.Models.CoreModels;
using System.Web.Http;

namespace Qna.Controllers
{
    [System.Web.Http.RoutePrefix("user")]
    public class UserController : ApiController
    {
        public IUserService UserService;
        public UserController(IUserService UserService)
        {
            this.UserService = UserService;
        }

        [System.Web.Http.Route("get")]
        public IHttpActionResult Get()
        {
            IEnumerable<UsersView> Users = UserService.GetUsersView();
            if(Users.Count() == 0)
            {
                NotFound();
            }
            return Ok(Users);
        }
    }
}