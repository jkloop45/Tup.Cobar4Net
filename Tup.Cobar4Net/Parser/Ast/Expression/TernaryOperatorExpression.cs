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

namespace Tup.Cobar4Net.Parser.Ast.Expression
{
    /// <summary>an operator with arity of 3</summary>
    /// <author>
    ///     <a href="mailto:shuo.qius@alibaba-inc.com">QIU Shuo</a>
    /// </author>
    public abstract class TernaryOperatorExpression : AbstractExpression
    {
        protected TernaryOperatorExpression(IExpression first, IExpression second, IExpression third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public virtual IExpression First { get; }

        public virtual IExpression Second { get; }

        public virtual IExpression Third { get; }

        protected override object EvaluationInternal(IDictionary<object, object> parameters)
        {
            return ExpressionConstants.Unevaluatable;
        }
    }
}