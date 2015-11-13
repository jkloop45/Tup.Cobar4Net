/*
* Copyright 1999-2012 Alibaba Group.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System.Collections.Generic;
using Expr = Tup.Cobar.Parser.Ast.Expression.Expression;

namespace Tup.Cobar.Parser.Ast.Expression
{
    /// <summary>
    /// an operator with arity of 3<br/>
    /// left conbine in default
    /// </summary>
    /// <author><a href="mailto:shuo.qius@alibaba-inc.com">QIU Shuo</a></author>
    public abstract class BinaryOperatorExpression : AbstractExpression
    {
        protected internal readonly Expr leftOprand;

        protected internal readonly Expr rightOprand;

        protected internal readonly int precedence;

        protected internal readonly bool leftCombine;

        /// <summary>
        /// <see cref="leftCombine"/>
        /// is true
        /// </summary>
        protected internal BinaryOperatorExpression(Expr leftOprand, Expr rightOprand, int precedence)
        {
            this.leftOprand = leftOprand;
            this.rightOprand = rightOprand;
            this.precedence = precedence;
            this.leftCombine = true;
        }

        protected internal BinaryOperatorExpression(Expr leftOprand, Expr rightOprand, int precedence, bool leftCombine)
        {
            this.leftOprand = leftOprand;
            this.rightOprand = rightOprand;
            this.precedence = precedence;
            this.leftCombine = leftCombine;
        }

        public virtual Expr GetLeftOprand()
        {
            return leftOprand;
        }

        public virtual Expr GetRightOprand()
        {
            return rightOprand;
        }

        public override int GetPrecedence()
        {
            return precedence;
        }

        public virtual bool IsLeftCombine()
        {
            return leftCombine;
        }

        public abstract string GetOperator();

        protected override object EvaluationInternal(IDictionary<object, Expression> parameters)
        {
            return Unevaluatable;
        }
    }
}