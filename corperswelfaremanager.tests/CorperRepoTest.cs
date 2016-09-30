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
using System.Data.Entity;

namespace CorpersWelfareManager.Tests
{

    [TestClass]
    public class CorperRepoTest
    {

        
       

       
        [TestMethod]
        public void Find_A_Corper_Byid()
        {
         

          
            //arrange
            int ExpectedCorpID = 2;
            var Corps = new CorperRepository();
         
            //Act
            Corper result =Corps.FindCorperbyID(ExpectedCorpID);
            

          
            //assert
            Assert.AreEqual(2, result.CorperID);



        }
        
        [TestMethod]
        public void AddCorper()
        {
            //arrange
            Corper form = new Corper { CorperID = 1, Statecode = "rv/15A/1581", Firstname = "Leo", Lastname = "okeke", Sex = "male", Batch = "C", NyscYear = "2015", Cds = "Anti-Corruption", Community = "okobo" };
            Corper Db = new Corper{CorperID = 1, Statecode ="rv/15A/1581",Firstname="Leo",Lastname="okeke",Sex="male",Batch="C",NyscYear="2015",Cds="Anti-Corruption",Community="okobo" };
         
            var CorpRepo = new CorperRepository();
            //act
          
           var Result = CorpRepo.AddCorper(form);
           
            //assert
 
           Assert.AreEqual(Db.Statecode,"rv/15A/1581");

          



        }

        [TestMethod]

        public void Check_if_Corper_exist()
        {
            //arrange
            Corper Db = new Corper { CorperID = 1, Statecode = "rv/15A/1581", Firstname = "Leo", Lastname = "okeke", Sex = "male", Batch = "C", NyscYear = "2015", Cds = "Anti-Corruption", Community = "okobo" };
            Corper corper = new Corper { CorperID = 1, Statecode = "rv/15A/1581", Firstname = "Leo", Lastname = "okeke", Sex = "male", Batch = "C", NyscYear = "2015", Cds = "Anti-Corruption", Community = "okobo" };

               var CorperRepo=new CorperRepository();
              //act
            var Result=CorperRepo.CorperExist(corper);
            
            //assert
            Assert.AreEqual(true,Result);
            

        




        }








    }
}