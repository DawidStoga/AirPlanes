using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Web.Mvc;
using AirPlane.Domain.Abstract;
using System.Configuration; //todo; po co to!
using AirPlane.Domain.Concrete;
using AirPlane.Domain.Entities;
using Moq;
using AirPlane.WebUI.Infrastructure.Abstract;
using AirPlane.WebUI.Infrastructure.Concrete;

namespace AirPlane.WebUI.Infrastructure
{
    class NinjectDependencyResolver : IDependencyResolver //from System.Web.MVC
    {
        //Tworzymy kernel  - IKernerl z Ninject
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();  //bindowanie
        }

        private void AddBindings()
        {
            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
            kernel.Bind<IAirPlaneRepository>().To<EFAirPlaneRepostory>();
            kernel.Bind<IStudentRepository>().To<EFStudentRepository>();
            EmailSettings emailSetting = new EmailSettings()
            {
                WriteAsFile = bool.Parse(ConfigurationManager.AppSettings["Email.WriteAsFile"] ?? "false")
            };

            kernel.Bind<IOrderProcessor>().To<EmailOrderProcessor>().WithConstructorArgument("settings", emailSetting);
           /*  Mock<IAirPlaneRepository> mock = new Mock<IAirPlaneRepository>();
             mock.Setup(m => m.AirCrafts).Returns(new List<Aircraft>
             {
                 new Aircraft { Name = "Boeing" , Category = "Passenger", Type="747", EngineCnt=4 },
                 new Aircraft { Name = "AirBus" , Category = "Passenger", Type="A380", EngineCnt=4 },
                 new Aircraft { Name = "AirBus" , Category = "Passenger", Type="A320", EngineCnt=2 },
             });
             kernel.Bind<IAirPlaneRepository>().ToConstant(mock.Object);
             */
            // throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}
