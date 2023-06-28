using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAeroport.Models
{
    public class SumaIncasata
    {
        [Key]
        public string? Destinatie { get; set; }
        public double? Suma { get; set; }
    }
}
