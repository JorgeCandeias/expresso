using Expresso.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Expresso
{
    internal class ProtoExpressionTranslator
    {
        private Stack<Expression> _stack = new Stack<Expression>();

        public Expression Translate(ProtoExpression node)
        {
            _stack.Clear();

            Visit(node);

            return _stack.Pop();
        }

        private ProtoExpression Visit(ProtoExpression node)
        {
            switch (node)
            {
                case ProtoConstantExpression constant:
                    VisitConstant(constant);
                    break;

                default:
                    throw new NotSupportedException();
            }

            return node;
        }

        private ProtoConstantExpression VisitConstant(ProtoConstantExpression node)
        {
            var expression = node switch
            {
                ProtoCharConstantExpression constant => Expression.Constant(constant.Value),
                ProtoSByteConstantExpression constant => Expression.Constant(constant.Value)  ,
                ProtoByteConstantExpression constant => Expression.Constant(constant.Value),
                ProtoInt16ConstantExpression constant => Expression.Constant(constant.Value),
                ProtoUInt16ConstantExpression constant => Expression.Constant(constant.Value),
                ProtoInt32ConstantExpression constant => Expression.Constant(constant.Value),
                ProtoUInt32ConstantExpression constant => Expression.Constant(constant.Value),
                ProtoInt64ConstantExpression constant => Expression.Constant(constant.Value),
                ProtoUInt64ConstantExpression constant => Expression.Constant(constant.Value),
                ProtoSingleConstantExpression constant => Expression.Constant(constant.Value),
                ProtoDoubleConstantExpression constant => Expression.Constant(constant.Value),
                ProtoDecimalConstantExpression constant => Expression.Constant(constant.Value),
                ProtoDateTimeConstantExpression constant => Expression.Constant(constant.Value),
                ProtoStringConstantExpression constant => Expression.Constant(constant.Value),
                _ => throw new NotSupportedException()
            };

            _stack.Push(expression);

            return node;
        }
    }
}