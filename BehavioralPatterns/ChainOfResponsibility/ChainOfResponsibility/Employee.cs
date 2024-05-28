namespace ChainOfResponsibility
{
    public sealed class Employee : IExpenseApprover
    {
        private readonly decimal _approvalLimit;

        public Employee(string name, decimal approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }

        public string Name { get; private set; }

        public ApprovalResponse ApproveExpense(IExpenseReport report)
        {
            return report.Total > _approvalLimit
                ? ApprovalResponse.BeyondApprovalLimit
                : ApprovalResponse.Approved;
        }
    }
}
