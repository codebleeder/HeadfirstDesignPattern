using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter9_1_Iterator
{
    public interface Iterator
    {
        bool HasNext();
        Object Next();
    }
}