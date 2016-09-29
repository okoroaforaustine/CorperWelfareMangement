using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CorpersWelfareManager.Models.Repository;
using CorpersWelfareManager.Models;
using System.Web.Http.Cors;

namespace CorpersWelfareManager.Controllers
{
    [EnableCors(origins: "http://localhost:35630",
   headers: "accept,content-type,origin,x-my-header", methods: "GET,POST,PUT,DELETE")]
    [RoutePrefix("api/Cds")]
    public class CdsController : ApiController
    {

        private CdsRepository _Repo = null;

        public CdsController()
        {

            this._Repo = new CdsRepository();

        }
        // GET: api/Cds
      //  [Authorize]
        [Route("Get")]
        public IQueryable Get()
        {
         return   _Repo.getCds();

          

            

        }

      

        // POST: api/Cds
       // [Authorize]
        [Route("Post")]

        public IHttpActionResult Post(Cds cds)
        {
            if (ModelState.IsValid)
            {
                if (_Repo.postCds(cds))
                {
                    _Repo.Save();
                    return Ok();

                }


                else
                {


                    return BadRequest("Cds Name already exist!");
                }

            }
            else
            {



                return BadRequest("failed to Create Cds");
            }

           

        }
           

        

      

     
    }
}
