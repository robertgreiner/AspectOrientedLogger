namespace TaxCalculator
{
    public interface ITaxType
    {
        decimal Calculate(decimal subTotal);
        void ErrorMethod();
    }
}
