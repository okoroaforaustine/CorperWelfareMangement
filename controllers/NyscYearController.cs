using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CorpersWelfareManager.Models;
using CorpersWelfareManager.Models.Repository;

namespace CorpersWelfareManager.Controllers
{
    public class NyscYearController : ApiController
    {

        
          private NyscYearRepository _Repo = null;

        public NyscYearController()
        {

            this._Repo = new NyscYearRepository();

        }
        // GET: api/NyscYear
        public IQueryable Get()
        {
            return _Repo.getNyscYear();
        }

    
        // POST: api/NyscYear
        public IHttpActionResult Post(NyscYear year)
        {
            if (ModelState.IsValid)
            {
                if (_Repo.postNyscyear(year))
                {
                    _Repo.Save();
                    return Ok();

                }


                else
                {


                    return BadRequest("BatchYear  already exist!");
                }

            }
            else
            {



                return BadRequest("failed to  Create batch");
            }



        }

      
      
       
    }
}
