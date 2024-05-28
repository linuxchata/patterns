using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public sealed class ExpenseHandler : IExpenseHandler
    {
        private readonly IExpenseApprover _approver;

        private IExpenseHandler _nextApprover;

        public ExpenseHandler(IExpenseApprover approver)
        {
            _approver = approver;
            _nextApprover = new EndOfChainHandler();
        }

        public ApprovalResponse Approve(IExpenseReport report)
        {
            var response = _approver.ApproveExpense(report);

            if (response == ApprovalResponse.BeyondApprovalLimit)
            {
                return _nextApprover.Approve(report);
            }

            Console.WriteLine("    Report was approved by {0}", ((Employee)_approver).Name.ToUpper());
            return response;
        }

        public void SetNext(IExpenseHandler next)
        {
            _nextApprover = next;
        }
    }
}
