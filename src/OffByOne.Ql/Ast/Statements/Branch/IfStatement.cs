﻿namespace OffByOne.Ql.Ast.Statements.Branch
{
    using System.Collections.Generic;

    using OffByOne.Ql.Ast.Expressions;

    public class IfStatement : Statement
    {
        public IfStatement(
            Expression condition,
            IList<Statement> statements,
            ElseStatement elseStatement = null)
        {
            this.Condition = condition;
            this.Statements = statements;
            this.ElseStatement = elseStatement;
        }

        public Expression Condition { get; private set; }

        public IEnumerable<Statement> Statements { get; private set; }

        public Statement ElseStatement { get; private set; }
    }
}