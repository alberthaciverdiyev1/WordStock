using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public double Point { get; set; }
        public int UserId { get; set; }
        public Statistic Statistic { get; set; } 
    }
}
