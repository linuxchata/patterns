namespace ChainOfResponsibility
{
    /// <summary>
    /// The 'Handler' interface
    /// </summary>
    public interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport report);

        void SetNext(IExpenseHandler next);
    }
}
