using Ninject;
using Ninject.Modules;
using NRules.Fluent;
using NRules.Fluent.Dsl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NRules.Integration.Ninject
{
    public class NinjectRuleActivator : IRuleActivator
    {
        private readonly IKernel _kernel;

        public NinjectRuleActivator(INinjectModule container) : this(new StandardKernel(container))
        {

        }

        public NinjectRuleActivator(IKernel kernel) => _kernel = kernel;

        public IEnumerable<Rule> Activate(Type type) => _kernel.GetAll(type).Cast<Rule>();
    }
}
