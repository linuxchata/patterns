using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public sealed class EndOfChainHandler : IExpenseHandler
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
