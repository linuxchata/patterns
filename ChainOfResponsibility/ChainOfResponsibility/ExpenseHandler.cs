using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public sealed class ExpenseHandler : IExpenseHandler
    {
        private readonly IExpenseApprover approver;

        private IExpenseHandler nextApprover;

        public ExpenseHandler(IExpenseApprover approver)
        {
            this.approver = approver;
            this.nextApprover = new EndOfChainHandler();
        }

        public ApprovalResponse Approve(IExpenseReport report)
        {
            var response = this.approver.ApproveExpense(report);

            if (response == ApprovalResponse.BeyondApprovalLimit)
            {
                return this.nextApprover.Approve(report);
            }

            Console.WriteLine("    Report was approved by {0}", ((Employee)approver).Name.ToUpper());
            return response;
        }

        public void SetNext(IExpenseHandler next)
        {
            this.nextApprover = next;
        }
    }
}
