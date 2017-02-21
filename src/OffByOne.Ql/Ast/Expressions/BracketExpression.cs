﻿namespace OffByOne.Ql.Ast.Expressions
{
    using OffByOne.Ql.Visitors.Contracts;

    public class BracketExpression : Expression
    {
        public BracketExpression(Expression expression)
        {
            this.Expression = expression;
        }

        public Expression Expression { get; private set; }

        public override TResult Accept<TResult>(IExpressionVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
