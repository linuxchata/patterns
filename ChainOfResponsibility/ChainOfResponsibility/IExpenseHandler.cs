namespace ChainOfResponsibility
{
    public interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport report);

        void SetNext(IExpenseHandler next);
    }
}
