using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_1_Iterator
{
    public class PancakeHouseIterator : Iterator
    {
        private List<MenuItem> Items;
        private int Position = 0;
        public PancakeHouseIterator(List<MenuItem> items)
        {
            Items = items;
        }
        public bool HasNext()
        {
            if (Position >= Items.Count || Items[Position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            var item = Items[Position];
            Position += 1;
            return item;
        }
    }
}
