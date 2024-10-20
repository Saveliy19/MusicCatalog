using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Interfaces
{
    internal interface Ibuilder<T>
    {
        T Build();
    }
}
