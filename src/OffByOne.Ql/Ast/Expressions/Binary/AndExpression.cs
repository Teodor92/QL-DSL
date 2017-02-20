﻿namespace OffByOne.Ql.Ast.Expressions.Binary
{
    using OffByOne.LanguageCore.Ast.Expressions.Base;
    using OffByOne.Ql.Ast.Expressions.Binary.Base;

    public class AndExpression : BinaryExpression
    {
        public AndExpression(
            Expression leftExpression,
            Expression rightExpression)
            : base(leftExpression, rightExpression)
        {
        }
    }
}
