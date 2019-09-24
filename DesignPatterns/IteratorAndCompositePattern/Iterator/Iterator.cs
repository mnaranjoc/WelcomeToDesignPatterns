using System;

namespace IteratorAndCompositePattern.Iterator
{
    public interface Iterator
    {
        bool hasNext();
        Object next();
    }
}
