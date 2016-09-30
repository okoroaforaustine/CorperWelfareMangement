using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CorpersWelfareManager.Models;
using CorpersWelfareManager.Models.Repository;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace CorpersWelfareManager.Controllers
{
  [EnableCors(origins: "http://localhost:35630",
    headers: "accept,content-type,origin,x-my-header", methods: "GET,POST,PUT,DELETE")]
     [RoutePrefix("api/Corpers")]
    public class CorpersController : ApiController
    {
      public IcorperInterface _Repo;

      

       public CorpersController(IcorperInterface Repo)
       {
           _Repo = Repo;


       }

        
      
      
        // POST: api/Corpers

       [Authorize]
       [Route("Post")]
       public IHttpActionResult Post(Corper corper)
       {
           if (ModelState.IsValid)
           {
               if (_Repo.AddCorper(corper))
               {
                   _Repo.Save();
                   return Ok(corper);

               }
               else
               {

                   return BadRequest("Corper Already Exist");
               }

           }
           else
           {

               return BadRequest("failed to Save Corper");
           }





       }




           






       
       
      [Authorize]
          
         [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
              
            var corper = this._Repo.GetAllCorper().FirstOrDefault(c => c.CorperID == id); 
 
            return Ok(corper); 
        } 
 
            

        
        
      

        
             
        [Authorize]

        // GET: api/Corpers/name
        [Route("{name:alpha}")]
        public IHttpActionResult Get(string name)
        {
            var Corper = this._Repo.GetAllCorper().FirstOrDefault(c => c.Firstname == name);

            return Ok(Corper);
        }
        [Authorize]
        // GET: api/Clubs/pageSize/pageNumber/orderBy(optional) 
        [Route("{pageSize:int}/{pageNumber:int}/{orderBy:alpha?}")]
        public IHttpActionResult Get(int pageSize, int pageNumber, string orderBy = "")
        {
            var totalCount = this._Repo.GetAllCorper().Count();
            var totalPages = Math.Ceiling((double)totalCount / pageSize);
            var CorperQuery = this._Repo.GetAllCorper();

            
             CorperQuery = CorperQuery.OrderBy(c => c.CorperID);
            

            var Pagination = CorperQuery.Skip((pageNumber - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToList();

            var result = new
            {
                TotalCount = totalCount,
                totalPages = totalPages,
                Corper = Pagination
            };

            return Ok(result);
        } 








        




  
  

  

      }
       
       
      

       
    }
