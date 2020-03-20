using Expresso.Expressions;
using ProtoBuf;
using System;
using System.IO;
using System.Linq.Expressions;

namespace Expresso
{
    public class Expresso : IExpresso
    {
        public void Serialize(Stream destination, Expression expression)
        {
            if (destination is null) throw new ArgumentNullException(nameof(destination));
            if (expression is null) throw new ArgumentNullException(nameof(expression));

            var translator = new ExpressionTranslator();
            var result = translator.Translate(expression);

            Serializer.Serialize(destination, result);
        }

        public Expression Deserialize(Stream source)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));

            var result = Serializer.Deserialize<ProtoExpression>(source);
            var translator = new ProtoExpressionTranslator();

            return translator.Translate(result);
        }
    }
}