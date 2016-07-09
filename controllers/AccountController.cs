using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CorpersWelfareManager.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace CorpersWelfareManager.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {

        private AccountRepository _repo = null;

        public AccountController()
        {
            _repo = new AccountRepository();
        }

        // POST api/Account/Register
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await _repo.RegisterUser(userModel);

            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }
            //checking if creating a user does'nt succed
            if (!result.Succeeded)
            {
                if (result.Errors != null)// checking if error is not empty
                {
                    foreach (string error in result.Errors)// loop throw all the errors
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid) //if it satisfies the model
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState); // otherwise return bad request
            }

            return null;




        }
    }
}
