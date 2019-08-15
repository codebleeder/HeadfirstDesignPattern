using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_2_Composite
{
    public class MenuIterator : IEnumerator
    {
        private List<MenuComponent> MenuComponents;
        private int CurrentIndex = -1;
        public MenuIterator(List<MenuComponent> menuComponents)
        {
            MenuComponents = menuComponents;
        }
        public object Current => CurrentIndex > -1 ?  MenuComponents[CurrentIndex] : null;

        public bool MoveNext() {
            if (CurrentIndex < MenuComponents.Count)
            {
                CurrentIndex += 1;
                return true;
            }
            return false;            
        }

        public void Reset() => CurrentIndex = -1;
        
    }
}
