namespace Rules
{
    public interface IDiscountRule
    {
        decimal CalcumateDiscount(Customer customer);
    }
}
