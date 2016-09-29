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
    public class CommunityController : ApiController
    {
        // GET: api/Community

        
          private CommunityRepository _Repo = null;

        public CommunityController()
        {

            this._Repo = new CommunityRepository();

        }

        public IQueryable Get()
        {
            return _Repo.getCommunity();
        }

        // GET: api/Community/5
       

        // POST: api/Community
        public IHttpActionResult Post(Community community)
        {
            if (ModelState.IsValid)
            {
                if (_Repo.postCommunity(community))
                {
                    _Repo.Save();
                    return Ok();

                }


                else
                {


                    return BadRequest("Community Name already exist!");
                }

            }
            else
            {



                return BadRequest("failed to  Create Community");
            }



        }

        // PUT: api/Community/5
      
    }
}
