﻿namespace ChainOfResponsibility
{
    public interface IExpenseApprover
    {
        ApprovalResponse ApproveExpense(IExpenseReport report);
    }
}