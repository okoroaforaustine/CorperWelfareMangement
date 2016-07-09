using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorpersWelfareManager.Models.Repository
{
    public class MonthlyDuesRepository
    {
          WelfareManagerContext _context;
        
     public MonthlyDuesRepository()
            : this(new WelfareManagerContext())
        {

        }


     public MonthlyDuesRepository(WelfareManagerContext context)
        {

            _context = context;
        }

     public IQueryable<MonthlyDues>GetMonthly()
     {


        return _context.MonthlyDues;
     }

        public void PostMonthly(MonthlyDues Monthly)
     {

         _context.MonthlyDues.Add(Monthly);


     }

        public void SaveMonthly()
        {

            _context.SaveChanges();
        }

       public void CountDues(MonthlyDues Monthly)
        {

            _context.MonthlyDues.Select(x => x.Paid && x.Month == "August");
                     
        }

    }
}