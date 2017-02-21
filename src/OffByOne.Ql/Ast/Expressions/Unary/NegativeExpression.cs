﻿namespace OffByOne.Ql.Ast.Expressions.Unary
{
    using OffByOne.LanguageCore.Ast.Expressions.Base;
    using OffByOne.Ql.Ast.Expressions.Unary.Base;
    using OffByOne.Ql.Visitors.Contracts;

    public class NegativeExpression : UnaryExpression
    {
        public NegativeExpression(Expression expression)
            : base(expression)
        {
        }

        public override TResult Accept<TResult>(IExpressionVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
