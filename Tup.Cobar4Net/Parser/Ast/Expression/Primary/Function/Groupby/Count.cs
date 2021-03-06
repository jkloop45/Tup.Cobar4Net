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
using Tup.Cobar4Net.Parser.Visitor;

namespace Tup.Cobar4Net.Parser.Ast.Expression.Primary.Function.Groupby
{
    /// <author>
    ///     <a href="mailto:shuo.qius@alibaba-inc.com">QIU Shuo</a>
    /// </author>
    public class Count : FunctionExpression
    {
        /// <summary>
        ///     either
        ///     <see cref="distinct" />
        ///     or
        ///     <see cref="wildcard" />
        ///     is false. if both are false,
        ///     expressionList must be size 1
        /// </summary>
        private readonly bool distinct;

        public Count(IList<IExpression> arguments)
            : base("COUNT", arguments)
        {
            distinct = true;
        }

        public Count(IExpression arg)
            : base("COUNT", WrapList(arg))
        {
            distinct = false;
        }

        public virtual bool IsDistinct
        {
            get { return distinct; }
        }

        public override FunctionExpression ConstructFunction(IList<IExpression> arguments)
        {
            return new Count(arguments);
        }

        public override void Accept(ISqlAstVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}