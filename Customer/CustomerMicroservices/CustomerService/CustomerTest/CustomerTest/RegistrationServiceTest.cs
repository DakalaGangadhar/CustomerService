using Customer.Services;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTest.CustomerTest
{
    
    public class RegistrationServiceTest
    {
        RegistrationService registrationService;
        private Mock<RegistrationService> _mockregistrationService;
        public RegistrationServiceTest(RegistrationService _registrationService)
        {
            registrationService = _registrationService;
        }
        [SetUp]
        public void Setup()
        {
            _mockregistrationService = new Mock<RegistrationService>();
        }

        //[Test]
        //public void Test()
        //{
        //    var words = new Dictionary<int, string>
        //    {
        //         {1, "sky"},
        //         {2, "cup"},
        //         {3, "odd"},
        //         {4, "cloud"},
        //         {5, "forest"},
        //         {6, "warm"},
        //    };
        //    dynamic json = JsonConvert.SerializeObject(words);
        //   dynamic data= _mockregistrationService.Setup(x => x.GetCountryList()).Returns(json);
        //    Assert.IsNotNull(data);
        //}
    }
}
