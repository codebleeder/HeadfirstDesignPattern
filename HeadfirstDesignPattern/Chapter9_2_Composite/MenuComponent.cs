using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_2_Composite
{
    public abstract class MenuComponent
    {
        // Composite methods
        virtual public void Add(MenuComponent menuComponent) => throw new NotSupportedException();

        virtual public void Remove(MenuComponent menuComponent) => throw new NotSupportedException();
        virtual public MenuComponent GetChild(int i) => throw new NotSupportedException();
        

        // Operations
        virtual public string Name => throw new NotSupportedException();
        virtual public string Description => throw new NotSupportedException();
        virtual public double Price => throw new NotSupportedException();
        virtual public bool IsVegetarian => throw new NotSupportedException();
        public abstract void Print();
    }
}
