﻿namespace OffByOne.Qls.Ast.Style.Rules.Base
{
    using System;
    using System.Collections.Generic;

    using OffByOne.Ql.Ast;
    using OffByOne.Ql.Common.Visitors.Contracts;
    using OffByOne.Qls.Ast.Style.Properties.Base;
    using OffByOne.Qls.Ast.Style.Widgets.Base;
    using OffByOne.Qls.Common.Visitors.Contracts;

    public abstract class Rule : AstNode, IVisitibleRule
    {
        protected Rule(
            Widget widget,
            IEnumerable<Property> properties)
        {
            this.Widget = widget;
            this.Properties = properties;
        }

        public Widget Widget { get; }

        public IEnumerable<Property> Properties { get; }

        public abstract TResult Accept<TResult, TContext>(IRuleVisitor<TResult, TContext> visitor, TContext environment)
            where TContext : IEnvironment;
    }
}
