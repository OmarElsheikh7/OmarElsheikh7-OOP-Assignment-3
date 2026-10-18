using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
        {
            if (pageNumber < 1 || pageSize < 1)
            {
                throw new ArgumentOutOfRangeException("Page number and size must be greater than 0.");
            }

            int skipCount = (pageNumber - 1) * pageSize;
            int currentIndex = 0;
            int yieldedCount = 0;

            foreach (T item in source)
            {
                if (currentIndex >= skipCount)
                {
                    yield return item;
                    yieldedCount++;

                    if (yieldedCount == pageSize)
                    {
                        yield break;
                    }
                }
                currentIndex++;
            }
        }

        public static T FindById<T>(this IEnumerable<T> source , int id) where T : IHasId
        {
            foreach (var item in source)
            {
                if(item.Id == id)
                {
                     return item;
                }
            }
            return default;
        }

        public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
        {
            Dictionary<int, T> dict = new Dictionary<int, T>();
            foreach (var item in source)
            {
                dict.Add(item.Id, item);
            }

            return dict;
        }


    }
}
