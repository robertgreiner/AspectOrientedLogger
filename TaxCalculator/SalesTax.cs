using System;
using TaxCalculator.IoC;

namespace TaxCalculator
{
    [Logging]
    public class SalesTax : ITaxType
    {
        [Logging]
        public virtual decimal Calculate(decimal subTotal)
        {
            return Math.Round(subTotal * 1.0825m, 2, MidpointRounding.ToEven);
        }

        [Logging]
        public virtual void ErrorMethod()
        {
            throw new NotImplementedException();
        }
    }
}
