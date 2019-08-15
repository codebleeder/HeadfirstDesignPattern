using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_2_Composite
{
    public class Menu : MenuComponent, IEnumerable
    {
        public List<MenuComponent> MenuComponents;

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
            MenuComponents = new List<MenuComponent>();
        }
        public override void Add(MenuComponent menuComponent)
        {
            MenuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            MenuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return MenuComponents[i];
        }
        public override string Name { get; }
        public override string Description { get; }
        public override void Print()
        {
            Console.WriteLine($"{Name} {Description}");
            Console.WriteLine("------------------------");
            // print children
            var iterator = MenuComponents.GetEnumerator();
            // start with index 0 
            while(iterator.MoveNext())
            {
                var current = (MenuComponent)iterator.Current;
                current.Print();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new MenuIterator(MenuComponents);
        }
    }
}
