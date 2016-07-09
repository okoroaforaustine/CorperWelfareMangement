using CorpersWelfareManager.Models;
using CorpersWelfareManager.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CorpersWelfareManager.Controllers
{
    [EnableCors(origins: "http://localhost:35630",
      headers: "accept,content-type,origin,x-my-header", methods: "GET,POST,PUT,DELETE")]
    [RoutePrefix("api/MonthlyDues")]
    public class MonthlyDuesController : ApiController
    {
      
         private MonthlyDuesRepository _Repo = null;

      

       public MonthlyDuesController()
       {
           this._Repo = new MonthlyDuesRepository();


       }
        [Route("Get")]
        public IHttpActionResult Get(MonthlyDues Monthly)
       {

           _Repo.GetMonthly();
           return Ok(Monthly);

       }
        [Route("Post")]
      public IHttpActionResult Post(MonthlyDues Monthly)
       {

           if(ModelState.IsValid)
               if(Monthly.AmountMonthly>=200.00)
               {

                 _Repo.PostMonthly(Monthly);
                   _Repo.SaveMonthly();

                   return Ok(Monthly);

               }
                

            return BadRequest();
               
        
          

       }

          [Route("GetAmount")]
        public IHttpActionResult GetAmount(MonthlyDues Monthly)
        {
            _Repo.CountDues(Monthly);
            return Ok(Monthly);
        }
        
    }
}
