using System;
using TaxCalculator.IoC;

namespace TaxCalculator
{
    [Logging]
    public class SalesTax : ITaxType
    {
        public decimal Calculate(decimal subTotal)
        {
            return Math.Round(subTotal * 1.0825m, 2, MidpointRounding.ToEven);
        }

        public void ErrorMethod()
        {
            throw new NotImplementedException();
        }
    }
}
