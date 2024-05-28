namespace ChainOfResponsibility
{
    public sealed class ExpenseReport : IExpenseReport
    {
        public ExpenseReport(decimal total)
        {
            Total = total;
        }

        public decimal Total { get; private set; }
    }
}