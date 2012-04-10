using Ninject.Extensions.Interception.Infrastructure.Language;
using Ninject.Modules;
using TaxCalculator.IoC;

namespace TaxCalculator.Common
{
    public class AppModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITaxType>().To<SalesTax>().Intercept().With<LoggingInterceptor>();
        }
    }
}
