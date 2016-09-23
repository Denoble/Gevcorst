using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Gevcorst.Domain.Abstract;
using Moq;
using Gevcorst.Domain.Entities;
using Gevcorst.Domain.Concrete;
namespace Gevcorst.WebU1.Infrastructure
{
    public class NinjectDependencyResolver:IDependencyResolver
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

            kernel.Bind<IBeneficiaryRepository>().To<EFBeneficiaryRepository>();
           kernel.Bind<IDonorRepository>().To<EFDonorRepository>();
        }
    }
}