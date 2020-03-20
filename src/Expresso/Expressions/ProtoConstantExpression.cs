using ProtoBuf;
using System;

namespace Expresso.Expressions
{
    [ProtoContract]
    [ProtoInclude(4, typeof(ProtoCharConstantExpression))]
    [ProtoInclude(5, typeof(ProtoSByteConstantExpression))]
    [ProtoInclude(6, typeof(ProtoByteConstantExpression))]
    [ProtoInclude(7, typeof(ProtoInt16ConstantExpression))]
    [ProtoInclude(8, typeof(ProtoUInt16ConstantExpression))]
    [ProtoInclude(9, typeof(ProtoInt32ConstantExpression))]
    [ProtoInclude(10, typeof(ProtoUInt32ConstantExpression))]
    [ProtoInclude(11, typeof(ProtoInt64ConstantExpression))]
    [ProtoInclude(12, typeof(ProtoUInt64ConstantExpression))]
    [ProtoInclude(13, typeof(ProtoSingleConstantExpression))]
    [ProtoInclude(14, typeof(ProtoDoubleConstantExpression))]
    [ProtoInclude(15, typeof(ProtoDecimalConstantExpression))]
    [ProtoInclude(16, typeof(ProtoDateTimeConstantExpression))]
    [ProtoInclude(18, typeof(ProtoStringConstantExpression))]
    internal abstract class ProtoConstantExpression : ProtoExpression
    {
    }

    [ProtoContract]
    internal class ProtoCharConstantExpression : ProtoConstantExpression
    {
        protected ProtoCharConstantExpression()
        {
        }

        public ProtoCharConstantExpression(char value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public char Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoSByteConstantExpression : ProtoConstantExpression
    {
        protected ProtoSByteConstantExpression()
        {
        }

        public ProtoSByteConstantExpression(sbyte value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public sbyte Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoByteConstantExpression : ProtoConstantExpression
    {
        protected ProtoByteConstantExpression()
        {
        }

        public ProtoByteConstantExpression(byte value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public byte Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoInt16ConstantExpression : ProtoConstantExpression
    {
        protected ProtoInt16ConstantExpression()
        {
        }

        public ProtoInt16ConstantExpression(short value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public short Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoUInt16ConstantExpression : ProtoConstantExpression
    {
        protected ProtoUInt16ConstantExpression()
        {
        }

        public ProtoUInt16ConstantExpression(ushort value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public ushort Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoInt32ConstantExpression : ProtoConstantExpression
    {
        protected ProtoInt32ConstantExpression()
        {
        }

        public ProtoInt32ConstantExpression(int value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public int Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoUInt32ConstantExpression : ProtoConstantExpression
    {
        protected ProtoUInt32ConstantExpression()
        {
        }

        public ProtoUInt32ConstantExpression(uint value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public uint Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoInt64ConstantExpression : ProtoConstantExpression
    {
        protected ProtoInt64ConstantExpression()
        {
        }

        public ProtoInt64ConstantExpression(long value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public long Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoUInt64ConstantExpression : ProtoConstantExpression
    {
        protected ProtoUInt64ConstantExpression()
        {
        }

        public ProtoUInt64ConstantExpression(ulong value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public ulong Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoSingleConstantExpression : ProtoConstantExpression
    {
        protected ProtoSingleConstantExpression()
        {
        }

        public ProtoSingleConstantExpression(float value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public float Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoDoubleConstantExpression : ProtoConstantExpression
    {
        protected ProtoDoubleConstantExpression()
        {
        }

        public ProtoDoubleConstantExpression(double value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public double Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoDecimalConstantExpression : ProtoConstantExpression
    {
        protected ProtoDecimalConstantExpression()
        {
        }

        public ProtoDecimalConstantExpression(decimal value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public decimal Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoDateTimeConstantExpression : ProtoConstantExpression
    {
        protected ProtoDateTimeConstantExpression()
        {
        }

        public ProtoDateTimeConstantExpression(DateTime value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public DateTime Value { get; protected set; }
    }

    [ProtoContract]
    internal class ProtoStringConstantExpression : ProtoConstantExpression
    {
        protected ProtoStringConstantExpression()
        {
        }

        public ProtoStringConstantExpression(string? value)
        {
            Value = value;
        }

        [ProtoMember(1)]
        public string? Value { get; protected set; }
    }
}