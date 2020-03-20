using Expresso.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Expresso
{
    internal class ExpressionTranslator : ExpressionVisitor
    {
        private Stack<ProtoExpression> _protos = new Stack<ProtoExpression>();

        public ProtoExpression Translate(Expression expression)
        {
            _protos.Clear();

            Visit(expression);

            return _protos.Pop();
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            throw new NotImplementedException();
        }

        protected override CatchBlock VisitCatchBlock(CatchBlock node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            ProtoExpression proto = node.Value switch
            {
                char value => new ProtoCharConstantExpression(value),
                sbyte value => new ProtoSByteConstantExpression(value),
                byte value => new ProtoByteConstantExpression(value),
                short value => new ProtoInt16ConstantExpression(value),
                ushort value => new ProtoUInt16ConstantExpression(value),
                int value => new ProtoInt32ConstantExpression(value),
                uint value => new ProtoUInt32ConstantExpression(value),
                long value => new ProtoInt64ConstantExpression(value),
                ulong value => new ProtoUInt64ConstantExpression(value),
                float value => new ProtoSingleConstantExpression(value),
                double value => new ProtoDoubleConstantExpression(value),
                decimal value => new ProtoDecimalConstantExpression(value),
                DateTime value => new ProtoDateTimeConstantExpression(value),
                string value => new ProtoStringConstantExpression(value),
                _ => throw new NotImplementedException(),
            };

            _protos.Push(proto);

            return node;
        }

        protected override Expression VisitDebugInfo(DebugInfoExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitDefault(DefaultExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitDynamic(DynamicExpression node)
        {
            throw new NotImplementedException();
        }

        protected override ElementInit VisitElementInit(ElementInit node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitExtension(Expression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitGoto(GotoExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitIndex(IndexExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitLabel(LabelExpression node)
        {
            throw new NotImplementedException();
        }

        protected override LabelTarget VisitLabelTarget(LabelTarget node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitListInit(ListInitExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitLoop(LoopExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            throw new NotImplementedException();
        }

        protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        {
            throw new NotImplementedException();
        }

        protected override MemberBinding VisitMemberBinding(MemberBinding node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            throw new NotImplementedException();
        }

        protected override MemberListBinding VisitMemberListBinding(MemberListBinding node)
        {
            throw new NotImplementedException();
        }

        protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitNew(NewExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitSwitch(SwitchExpression node)
        {
            throw new NotImplementedException();
        }

        protected override SwitchCase VisitSwitchCase(SwitchCase node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitTry(TryExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitTypeBinary(TypeBinaryExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            throw new NotImplementedException();
        }
    }
}