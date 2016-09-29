using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorpersWelfareManager.Models.Repository
{
    public class NyscYearRepository
    {
    WelfareManagerContext _context;

        public NyscYearRepository()
            : this(new WelfareManagerContext())
        {

        }

        public NyscYearRepository(WelfareManagerContext context)
        {

             _context = context;

        }

        public IQueryable<NyscYear> getNyscYear()

        {

            return _context.NyscYear;
        
        
        }


        public bool postNyscyear(NyscYear NyscYear)
        {
             var CountNyscyear = _context.NyscYear.Where(X => X.NyscYearName == NyscYear.NyscYearName).Count();
            if (CountNyscyear <= 0)
            {
                _context.NyscYear.Add(NyscYear);



                return true;

            }
            else
            {

                return false;
            }


        }



        public void Save()
        {

            _context.SaveChanges();
        }

           

        

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);

        }



    }


    
}