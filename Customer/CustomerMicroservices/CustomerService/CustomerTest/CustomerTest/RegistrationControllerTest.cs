using Customer.Controllers;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTest.CustomerTest
{
    public class RegistrationControllerTest
    {
        RegistrationController registrationController;
        private Mock<RegistrationController> _mockregistrationController;
        [SetUp]
        public void Setup()
        {
            _mockregistrationController = new Mock<RegistrationController>();
        }
        [Test]
        public async Task ShouldReturnCharged()
        {
            var words = new Dictionary<int, string>
            {
                 {1, "sky"},
                 {2, "cup"},
                 {3, "odd"},
                 {4, "cloud"},
                 {5, "forest"},
                 {6, "warm"},
            };
          //  _mockregistrationController.Setup(p => p.GetCountry()).Returns(words);

            // act
           // var result = controller.CheckOut(cardMock.Object, addressInfoMock.Object);

            // assert
            // myInterfaceMock.Verify((m => m.DoesSomething()), Times.Once());
           // shipmentServiceMock.Verify(s => s.Ship(addressInfoMock.Object, items.AsEnumerable()), Times.Once());

            Assert.AreEqual("charged", "");
        }
    }
}
