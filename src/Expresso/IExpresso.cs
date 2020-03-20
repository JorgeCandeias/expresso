using System.IO;
using System.Linq.Expressions;

namespace Expresso
{
    public interface IExpresso
    {
        void Serialize(Stream destination, Expression expression);

        Expression Deserialize(Stream source);
    }
}