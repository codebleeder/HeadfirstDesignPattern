using System.Collections;
using System.Collections.Generic;

namespace HeadfirstDesignPattern.Chapter9_2_Composite
{
    public class CompositeEnumerator : IEnumerator
    {
        
        private Stack<IEnumerator> stack = new Stack<IEnumerator>();
        private int CurrentIndex = -1;
        public CompositeEnumerator(IEnumerator<MenuComponent> enumerator)
        {
            stack.Push(enumerator);
        }

        public MenuComponent Current
        {
            get
            {
                var iterator = stack.Peek();
                var menuComponent = iterator.Current;
                if (menuComponent is Menu)
                {
                    var menu = (Menu)menuComponent;
                    stack.Push(menu.GetCompositeEnumerator());
                    return menu;
                }
                return (MenuComponent)menuComponent;
            }
        }
        object IEnumerator.Current => Current;
        public bool MoveNext()
        {
            if (stack.Count == 0) return false;
            var iterator = stack.Peek();
            if (!iterator.MoveNext())
            {
                stack.Pop();
                return MoveNext();
            }
            return true;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}