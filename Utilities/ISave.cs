using System;
using System.Collections;

namespace Utilities
{
    public interface ISave<T>
    {
        void Save(T instance);
        T Load();
    }
}
