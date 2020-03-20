using ProtoBuf;

namespace Expresso.Expressions
{
    [ProtoContract]
    [ProtoInclude(1, typeof(ProtoConstantExpression))]
    internal abstract class ProtoExpression
    {
    }
}