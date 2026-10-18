using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class Store<T> where T : IHasId
    {
        public Dictionary<int, T> items { get; set; } = new Dictionary<int, T>();

        public void Add(T item)
        {
            items.Add(item.Id,item);
        }

        public T GetById(int id)
        {
            items.TryGetValue(id, out T result);
            return result;
        }

        public Dictionary<int, T> GetAll() => items;

        public void Remove(int id)
        {
            items.Remove(id);
        }


    }
}
