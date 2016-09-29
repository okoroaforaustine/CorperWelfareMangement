using System;
namespace CorpersWelfareManager.Models.Repository
{
   public interface IcorperInterface
    {
        bool AddCorper(Corper corper);
        bool CorperExist(CorpersWelfareManager.Models.Corper corper);
        void Dispose();
        CorpersWelfareManager.Models.Corper FindCorperbyID(int? CorperID);
        System.Linq.IQueryable<CorpersWelfareManager.Models.Corper> GetAllCorper();
        void Save();
        void UpdateCorper(CorpersWelfareManager.Models.Corper Corper);
    }
}
