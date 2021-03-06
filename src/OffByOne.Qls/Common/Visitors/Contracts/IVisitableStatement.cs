﻿namespace OffByOne.Qls.Common.Visitors.Contracts
{
    using OffByOne.Ql.Common.Visitors.Contracts;

    public interface IVisitableStatement : IVisitable
    {
        TResult Accept<TResult, TEnvironment>(IStatementVisitor<TResult, TEnvironment> visitor, TEnvironment environment)
            where TEnvironment : IEnvironment;
    }
}
