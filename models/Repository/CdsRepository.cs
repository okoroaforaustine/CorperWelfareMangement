using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorpersWelfareManager.Models.Repository
{
    public class CdsRepository:IDisposable
    {
        WelfareManagerContext _context;

        public CdsRepository()
            : this(new WelfareManagerContext())
        {

        }

        public CdsRepository(WelfareManagerContext context)
        {

             _context = context;

        }

        public IQueryable getCds()

        {

            return _context.Cds;
        
        
        }


        public bool postCds(Cds cds)
        {

            //count cds

            var Countcds = _context.Cds.Where(X => X.CdsName == cds.CdsName).Count();
            if (Countcds<=0)
            {
                _context.Cds.Add(cds);



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