using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorpersWelfareManager.Models.Repository
{
    public class BatchRepository
    {

         WelfareManagerContext _context;

        public BatchRepository()
            : this(new WelfareManagerContext())
        {

        }

        public BatchRepository(WelfareManagerContext context)
        {

             _context = context;

        }

        public IQueryable<Batch> getBatch()

        {

            return _context.Batch;
        
        
        }


        public bool postBatch(Batch batch)
        {

            //count cds

            var CountBatch = _context.Batch.Where(X => X.BatchName == batch.BatchName).Count();
            if (CountBatch <= 0)
            {
                _context.Batch.Add(batch);



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