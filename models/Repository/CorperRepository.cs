using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CorpersWelfareManager.Models.Repository;
namespace CorpersWelfareManager.Models.Repository
{
    public class CorperRepository:IDisposable,IcorperInterface
    {

        WelfareManagerContext _context;
        private IcorperInterface Rep;
        
     public CorperRepository()
            : this(new WelfareManagerContext())
        {

        }


     public  CorperRepository(WelfareManagerContext context)
        {

            _context = context;
            _context.Configuration.ProxyCreationEnabled = false;  
        }

    
        public    IQueryable<Corper>GetAllCorper()
        {

            return _context.Corper;

        }
        public bool AddCorper(Corper corper)
        {

            var count = _context.Corper.Where(x => x.Statecode == corper.Statecode).Count();
            if (count <= 0)
            {
                _context.Corper.Add(corper);

                

                return true;

            }  
            else
            {

                return false;
            }
            
            
         

      }


     public   Corper FindCorperbyID(int? CorperID)
        {
            return _context.Corper.Find(CorperID);



        }

     

        

         public bool CorperExist(Corper corper)
         {
            var newCorper = corper.Statecode.Count() > 0;


            if(newCorper==true)
            {
                return true;

            }
            else
            {
                return false;
            }
      

        }

         public void UpdateCorper(Corper Corper)
         {

             _context.Entry(Corper).State = EntityState.Modified;

         }

      public  void Save()
         {

             _context.SaveChanges();
         }
        

        //counting Number of corpers in a community
     
   
     public    void Dispose()
        {
             _context.Dispose();
             GC.SuppressFinalize(this);
           
        }







    
    }




   

    
}