using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter9_1_Iterator
{
    public class DinerMenuIterator : IEnumerator
    {
        private MenuItem[] Items;
        private int Position = -1;

        public DinerMenuIterator(MenuItem[] items)
        {
            var count = 0;
            
            for(var i=0; i<items.Length; i++)
            {
                if(items[i] != null)
                {                    
                    count += 1;
                }
            }
            Items = new MenuItem[count];
            for (var i=0; i< count; i++)
            {
                Items[i] = items[i];
            }
        }

        public object Current => Items[Position];

        public bool MoveNext()
        {
            if (Position >= Items.Length-1)
            {
                return false;
            }
            else
            {
                Position += 1;
                return true;
            }
        }

        public void Reset()
        {
            Position = -1;
        }
    }
}
