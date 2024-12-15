﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Statistic
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Type { get; set; }
    }
}
