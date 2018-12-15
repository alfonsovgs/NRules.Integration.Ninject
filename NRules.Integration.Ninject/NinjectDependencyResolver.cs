using System;
using Ninject;
using Ninject.Modules;
using NRules.Extensibility;

namespace NRules.Integration.Ninject
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver(INinjectModule container) : this(new StandardKernel(container))
        {

        }

        public NinjectDependencyResolver(IKernel kernel) => _kernel = kernel;

        public object Resolve(IResolutionContext context, Type serviceType) => _kernel.Get(serviceType);
    }
}
