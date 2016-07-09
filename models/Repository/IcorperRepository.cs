using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpersWelfareManager.Models.Repository
{
  public  interface IcorperRepository:IDisposable
    {
        IEnumerable<Corper> GetAllCorper();
        bool AddCorper(Corper corper);

        Corper FindCorperbyID(int CorperID);
        

        bool CorperExist(Corper corper);

        void Save();
        void CountNumberOfCorpers();


        void Dispose();


    }
}
