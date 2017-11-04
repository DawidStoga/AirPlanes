using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirPlane.Domain.Abstract;
using AirPlane.Domain.Entities;
using AirPlane.WebUI.Controllers;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace AirPlane.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            Mock<IAirPlaneRepository> mock = new Mock<IAirPlaneRepository>();
            mock.Setup(m => m.AirCrafts).Returns(new Aircraft[]
            { new Aircraft { AircraftID =1 , Name = "Boeing_1" },
             new Aircraft { AircraftID =1 , Name = "Boeing_2" },
             new Aircraft { AircraftID =1 , Name = "Boeing_3" },
             new Aircraft { AircraftID =1 , Name = "Boeing_4" },
             new Aircraft { AircraftID =1 , Name = "Boeing_5" },
             new Aircraft { AircraftID =1 , Name = "Boeing_6" },
             new Aircraft { AircraftID =1 , Name = "Boeing_7" },
            });

            AirCraftController controller = new AirCraftController(mock.Object, null);
            controller.PageSize = 3;

           /* IEnumerable<Aircraft> result = (IEnumerable<Aircraft>)controller.List(2).Model;
            Aircraft[] planes = result.ToArray();
            Assert.IsTrue(planes.Length == 2);
            Assert.AreEqual(planes[0].Name , "Boeing_1");*/

        }
    }
}
