namespace ChainOfResponsibility
{
    public sealed class Employee : IExpenseApprover
    {
        private readonly decimal approvalLimit;

        public Employee(string name, decimal approvalLimit)
        {
            this.Name = name;
            this.approvalLimit = approvalLimit;
        }

        public string Name { get; private set; }

        public ApprovalResponse ApproveExpense(IExpenseReport report)
        {
            return report.Total > this.approvalLimit
                ? ApprovalResponse.BeyondApprovalLimit
                : ApprovalResponse.Approved;
        }
    }
}
