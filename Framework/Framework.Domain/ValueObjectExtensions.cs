using System.Collections.Generic;
using System.Linq;

namespace Framework.Domain
{
    public static class ValueObjectExtensions
    {
        public static IList<T> Update<T>(this IList<T> source, List<T> target) where T : ValueObjectBase
        {
            var added = target.Except(source).ToList();
            var removed = source.Except(target).ToList();
            added.ForEach(a => source.Add(a));
            removed.ForEach(a => source.Remove(a));
            return source;
        }
    }
}
