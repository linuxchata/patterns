using System;

namespace ChainOfResponsibility
{
    public class EndOfChain : IExpenseHandler
    {
        public ApprovalResponse Approve(IExpenseReport report)
        {
            return ApprovalResponse.Denied;
        }

        public void SetNext(IExpenseHandler next)
        {
            throw new ArgumentException("Cannot have next approver");
        }
    }
}
