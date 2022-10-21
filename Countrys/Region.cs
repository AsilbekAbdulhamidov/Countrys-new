using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countrys
{
    public class Region
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Code { get; set; }
        public virtual Country? Country { get; set; }
        public int CountryId { get; set; }

    }
}
