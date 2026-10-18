using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class Store<T> where T : IHasId
    {
        public List<T> items { get; set; } = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T GetById(int id)
        {
            foreach (T item in items)
            {
                if (id == item.Id)
                    return item;
            }

            return default;
        }

        public List<T> GetAll() => items;

        public void Remove(int id)
        {
            T item = GetById(id);
            if (item != null)
            {
                items.Remove(item);
            }
        }
    }
}
