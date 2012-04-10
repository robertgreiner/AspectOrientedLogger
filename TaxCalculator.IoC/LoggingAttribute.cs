using System;
using Ninject;
using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Attributes;
using Ninject.Extensions.Interception.Request;

namespace TaxCalculator.IoC
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class LoggingAttribute : InterceptAttribute
    {
        public override IInterceptor CreateInterceptor(IProxyRequest request)
        {
            return request.Kernel.Get<LoggingInterceptor>();
        }
    }
}
