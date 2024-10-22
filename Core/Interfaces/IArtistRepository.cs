using MusicCatalog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Interfaces
{
    internal interface IArtistRepository
    {
       public List<Artist> SearchByName(string name);
       public void Add(Artist artist);
    }
}
