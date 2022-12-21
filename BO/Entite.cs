﻿#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public abstract class Entite
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }
    }
}
