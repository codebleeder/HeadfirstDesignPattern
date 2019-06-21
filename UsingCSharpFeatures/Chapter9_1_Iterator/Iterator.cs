using System;
using System.Collections.Generic;
using System.Text;

namespace UsingCSharpFeatures.Chapter9_1_Iterator
{
    public interface Iterator
    {
        bool HasNext();
        Object Next();
    }
}