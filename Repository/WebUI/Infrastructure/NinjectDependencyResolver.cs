using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Moq;
using Repository.Entities;
using Repository.Abstract;
using System.Linq;
using Repository.Concrete;

namespace WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {

            kernel.Bind<IGenericRepository<Employee>>().To<GenericRepository<Employee>>().WithConstructorArgument("dbContext", new VaerkstedContext());
            kernel.Bind<IGenericRepository<Customer>>().To<GenericRepository<Customer>>().WithConstructorArgument("dbContext", new VaerkstedContext());
            kernel.Bind<IGenericRepository<Car>>().To<GenericRepository<Car>>().WithConstructorArgument("dbContext", new VaerkstedContext());
            kernel.Bind<IGenericRepository<Task>>().To<GenericRepository<Task>>().WithConstructorArgument("dbContext", new VaerkstedContext());

            //Mock<IGenericRepository<Employee>> mock = new Mock<IGenericRepository<Employee>>();
           
            //IQueryable<Employee> employees = (new List<Employee>
            //{
            //    new Employee { Name="Lars", Surname="Petersen", Mail="fake@mail.com", Login="Lars", Password="123" },
            //    new Employee { Name="Lars2", Surname="Petersen2", Mail="fake2@mail.com", Login="Lars2", Password="1234" },
            //}).AsQueryable();
            //mock.Setup(m => m.GetAll()).Returns(employees);
               
            //kernel.Bind<IGenericRepository<Employee>>().ToConstant(mock.Object);
        }
    }
}   