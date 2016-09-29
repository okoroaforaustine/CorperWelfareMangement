using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CorpersWelfareManager.Models;
using CorpersWelfareManager.Models.Repository;

namespace CorpersWelfareManager.Controllers
{
    [EnableCors(origins: "http://localhost:35630",
  headers: "accept,content-type,origin,x-my-header", methods: "GET,POST,PUT,DELETE")]
    [RoutePrefix("api/Batch")]
    public class BatchController : ApiController
    {
        // GET: api/Batch




          private BatchRepository _Repo = null;

        public BatchController()
        {

            this._Repo = new BatchRepository();

        }
        public IQueryable Get()
        {
            return _Repo.getBatch(); 
        }

        // GET: api/Batch/5
       

        // POST: api/Batch
        public IHttpActionResult Post(Batch batch)
        {
           if (ModelState.IsValid)
            {
                if (_Repo.postBatch(batch))
                {
                    _Repo.Save();
                    return Ok();

                }


                else
                {


                    return BadRequest("Batch Name already exist!");
                }

            }
            else
            {



                return BadRequest("failed to  Create Batch");
            }

           

        }
           

        

      

     
    }
        

       
       
        
}
