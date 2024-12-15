using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Dictionary
    {
        [Key]
        public int Id { get; set; }
        public string EngWord { get; set; }
        public string AzeWord { get; set; }
        public string AlternativeAzeWords { get; set; }
        public string AlternativeEngWords { get; set; }
    }
}
