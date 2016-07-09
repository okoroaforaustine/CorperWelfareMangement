using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Language;
using Moq.Linq;
using Moq.Properties;
using Moq.Proxy;
using CorpersWelfareManager.Models.Repository;
using CorpersWelfareManager.Models;

namespace CorpersWelfareManager.Tests
{

    [TestClass]
    public class CorperRepoTest
    {

      

        [TestMethod]
        public void Return_All_Corpers()
        {
            IList<Corper> Corpers = new List<Corper>
                {
                    new Corper { CorperID = 1, Statecode ="rv/15A/1581",Firstname="Leo",Lastname="okeke",CommunityID=1,MonthlyID=1  }
                };


            //arrange
            Mock<IcorperRepository> AllCorpRepo = new Mock<IcorperRepository>();
            AllCorpRepo.Setup(x => x.GetAllCorper()).Returns(Corpers);

            var Rep = AllCorpRepo.Object;

            //act
            var Result =Rep.GetAllCorper() as IList<Corper>;

            //Assert

            Assert.AreEqual(1,Result.Count);

            


        }
        [TestMethod]
        public void Find_A_Corper_Byid()
        {
            //Assert
            Mock<IcorperRepository> AllCorpRepo = new Mock<IcorperRepository>();
            AllCorpRepo.Setup(x => x.FindCorperbyID(It.IsAny<int>())).Returns(new Corper { CorperID=1});





            var Rep=AllCorpRepo.Object;
            //act
            var Result = Rep.FindCorperbyID(1);

            //assert
            Assert.AreEqual(1, Result.CorperID);



        }
        

        













    }
}