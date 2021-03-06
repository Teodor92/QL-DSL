﻿namespace OffByOne.Qls.Common.Visitors.Contracts
{
    using OffByOne.Ql.Common.Visitors.Contracts;

    public interface IVisitableProperty : IVisitable
    {
        TResult Accept<TResult, TEnvironment>(IPropertyVisitor<TResult, TEnvironment> visitor, TEnvironment environment)
            where TEnvironment : IEnvironment;
    }
}
