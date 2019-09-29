using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace SalariesDll
{
    interface ICollectionMetier
    {
        void Save(ISave<Salaries> save);
        void Load(ISave<Salaries> load);
    }
}
