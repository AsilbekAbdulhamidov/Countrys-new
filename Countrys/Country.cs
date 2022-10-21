using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countrys
{
    public class Country
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ShortTitle { get; set; }
        public string? Code { get; set; }
        public string? ImageURl { get; set; }
        public virtual IList<Region>? Regions { get; set; }
    }
}
