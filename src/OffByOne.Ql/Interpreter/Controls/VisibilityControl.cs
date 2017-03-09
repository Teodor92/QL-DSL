﻿namespace OffByOne.Ql.Interpreter.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows;

    using OffByOne.Ql.Ast.Statements;
    using OffByOne.Ql.Evaluator;
    using OffByOne.Ql.Interpreter.Controls.Base;
    using OffByOne.Ql.Values;

    using Windows = System.Windows.Controls;

    public class VisibilityControl : Control, IObserver<GuiChange>
    {
        public VisibilityControl(IfStatement statement, GuiEnvironment guiEnvironment, IList<Control> ifControls, IList<Control> elseControls)
            : base(guiEnvironment)
        {
            this.Statement = statement;
            this.IfControls = ifControls;
            this.ElseControls = elseControls;
            this.AddToControls(ifControls);
            this.AddToControls(elseControls);

            this.Dependencies.UnionWith(statement.GetDependencies());
            this.EvaluateVisibility();
        }

        public IList<Control> IfControls { get; private set; }

        public IList<Control> ElseControls { get; private set; }

        public IfStatement Statement { get; }

        public override void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public override void OnNext(GuiChange value)
        {
            if (!this.Statement.IsComputable(value.Identifier))
            {
                return;
            }

            this.EvaluateVisibility();
        }

        private void EvaluateVisibility()
        {
            var evaluator = new Evaluator();
            var condition = (BooleanValue)evaluator.Evaluate(
                this.Statement.Condition,
                this.Environment.Evaluations);
            this.UpdateControlVisibility(condition.Value);
        }

        private void AddToControls(IEnumerable<Control> controls)
        {
            foreach (var control in controls)
            {
                this.Controls = this.Controls.Concat(control.Controls).ToList();
            }
        }

        private void UpdateControlVisibility(bool conditionMet)
        {
            if (conditionMet)
            {
                foreach (var control in this.IfControls)
                {
                    control.Show();
                }

                foreach (var control in this.ElseControls)
                {
                    control.Hide();
                }
            }
            else
            {
                foreach (var control in this.IfControls)
                {
                    control.Hide();
                }

                foreach (var control in this.ElseControls)
                {
                    control.Show();
                }
            }
        }
    }
}
