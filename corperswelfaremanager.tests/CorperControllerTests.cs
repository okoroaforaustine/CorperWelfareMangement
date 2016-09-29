using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorpersWelfareManager.Models;
using Moq;
using CorpersWelfareManager.Models.Repository;
using CorpersWelfareManager.Controllers;
using System.Web.Http.Results;

namespace CorpersWelfareManager.Tests
{
    /// <summary>
    /// Summary description for CorperControllerTests
    /// </summary>
    [TestClass]
    public class CorperControllerTests
    {

        [TestMethod]
        public void Post()
        {
            //arrange

            Corper corper = new Corper { CorperID = 1, Statecode = "rv/15A/1581", Firstname = "Leo", Lastname = "okeke", Sex = "male", Batch = "C", NyscYear = "2015", Cds = "Anti-Corruption", Community = "okobo" };

            Mock<IcorperInterface> AllCorpRepo = new Mock<IcorperInterface>();
            AllCorpRepo.Setup(x => x.AddCorper(It.IsAny<Corper>())).Returns(true);

            var obj = AllCorpRepo.Object;
            var Control = new CorpersController(obj);
            //act
            var Result = Control.Post(corper) as OkNegotiatedContentResult<Corper>;
            //Assert
            Assert.IsNotNull(Result);

            Assert.AreEqual(Result as OkNegotiatedContentResult<Corper>, Result);


        }
       








    }
}
