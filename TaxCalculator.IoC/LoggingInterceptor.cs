using System;
using Ninject.Extensions.Interception;

namespace TaxCalculator.IoC
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                Console.WriteLine("Start");
                invocation.Proceed();
                Console.WriteLine("Success!");
            }
            catch
            {
                Console.WriteLine("Error!");
                throw;
            }
            finally
            {
                Console.WriteLine("Exit");
            }

        }
    }
}
