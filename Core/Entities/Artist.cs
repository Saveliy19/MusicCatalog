using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Core.Entities
{
    internal class Artist
    {
        public string Nickname { get; set; }
        public DateTime RegistrationDate { get; set; }

        public List<Album> Albums { get; set; }
    }
}
