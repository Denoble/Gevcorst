using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Moq;
using Gevcorst.Domain.Abstract;
using Gevcorst.Domain.Entities;
using Gevcorst.WebU1.Controllers;

using System.Collections.Generic;

namespace Gevcorst.UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Can_Paginate()
        {// Arrange
            Mock<IBeneficiaryRepository> mock = new Mock<IBeneficiaryRepository>();
            mock.Setup(m => m.Beneficiaries).Returns(new Beneficiary[] {
            new Beneficiary{ID=1,FirstName="Mandy",LastName="Idowu",Category="Scholarship"},
            new Beneficiary{ID=2,FirstName="Kerry", LastName="John", Category="Sec"},
            new Beneficiary{ID=3,FirstName="Trump",LastName="Osundu",Category="Whistle_Blower"}, 
            new Beneficiary{ID=4,FirstName="Eze",LastName="Musa",Category="Sports"},
            new Beneficiary{ID=5,FirstName="Brandon",LastName="James",Category="Mentor"}, 
            new Beneficiary{ID=6,FirstName="Moss",LastName="Ramsey",Category="Scholoarship"},
            new Beneficiary{ID=7,FirstName="Zuma",LastName="Nhuru",Category="Mentor"}, 
            new Beneficiary{ID=8,FirstName="Bandan",LastName="Swanzi",Category="Entertainer"},
            new Beneficiary{ID=9,FirstName="LLoyd",LastName="Dele",Category="Inventor"}, 
            new Beneficiary{ID=10,FirstName="Andrea",LastName="Uche",Category="Techie"},
            new Beneficiary{ID=11,FirstName="Grace",LastName="Snow",Category="Nurse"}, 
            new Beneficiary{ID=12,FirstName="Lucy",LastName="Casie",Category="Doctor"},
            new Beneficiary{ID=13,FirstName="Balogun",LastName="Churchill",Category="Magnate"}, 
            new Beneficiary{ID=14,FirstName="Ali",LastName="Malik",Category="Mentor"},});

            BeneficiaryController bControl = new BeneficiaryController(mock.Object);
            bControl.pagesize = 3;
            //Act
            IEnumerable<Beneficiary> result = (IEnumerable<Beneficiary>)bControl.Beneficiary_list(2).Model;
            //Assert
            Beneficiary[] bb = result.ToArray();
            //Assert.IsTrue(bb.Length == 2);
            //Assert.AreEqual(bb[0].ID, 1);
            Assert.AreEqual(bb[1].ID, 10);
        }
        
    }
}
