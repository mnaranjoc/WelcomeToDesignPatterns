using System;

namespace IteratorAndCompositePattern
{
    public interface Iterator
    {
        bool hasNext();
        Object next();
    }
}
