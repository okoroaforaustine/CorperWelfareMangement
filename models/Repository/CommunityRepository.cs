using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorpersWelfareManager.Models.Repository
{
    public class CommunityRepository:IDisposable
    {




          WelfareManagerContext _context;

        public CommunityRepository()
            : this(new WelfareManagerContext())
        {

        }

        public CommunityRepository(WelfareManagerContext context)
        {

             _context = context;

        }

        public IQueryable<Community> getCommunity()

        {

            return _context.Community;
        
        
        }


        public bool postCommunity(Community community)
        { 
            var Countcommunity = _context.Community.Where(X => X.CommunityName == community.CommunityName).Count();
            if (Countcommunity <= 0)
            {
                _context.Community.Add(community);



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