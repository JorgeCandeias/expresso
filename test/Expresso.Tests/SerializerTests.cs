using System;
using System.IO;
using System.Linq.Expressions;
using Xunit;

namespace Expresso.Tests
{
    public class SerializerTests
    {
        [Fact]
        public void HandlesConstantCharExpression()
        {
            // arrange
            var value = char.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<char>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantSByteExpression()
        {
            // arrange
            var value = sbyte.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<sbyte>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantByteExpression()
        {
            // arrange
            var value = byte.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<byte>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantInt16Expression()
        {
            // arrange
            var value = short.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<short>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantUInt16Expression()
        {
            // arrange
            var value = ushort.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<ushort>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantInt32Expression()
        {
            // arrange
            var value = int.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<int>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantUInt32Expression()
        {
            // arrange
            var value = uint.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<uint>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantInt64Expression()
        {
            // arrange
            var value = long.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<long>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantUInt64Expression()
        {
            // arrange
            var value = ulong.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<ulong>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantSingleExpression()
        {
            // arrange
            var value = float.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<float>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantDoubleExpression()
        {
            // arrange
            var value = double.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<double>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantDecimalExpression()
        {
            // arrange
            var value = decimal.MaxValue;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<decimal>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantDateTimeExpression()
        {
            // arrange
            var value = DateTime.UtcNow;
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<DateTime>(constant.Value);
            Assert.Equal(value, result);
        }

        [Fact]
        public void HandlesConstantStringExpression()
        {
            // arrange
            var value = "SomeValue";
            var input = Expression.Constant(value);
            var serializer = new Expresso();

            // act
            using var stream = new MemoryStream();
            serializer.Serialize(stream, input);
            stream.Position = 0;
            var output = serializer.Deserialize(stream);

            // assert
            Assert.NotNull(output);
            var constant = Assert.IsType<ConstantExpression>(output);
            var result = Assert.IsType<string>(constant.Value);
            Assert.Equal(value, result);
        }
    }
}