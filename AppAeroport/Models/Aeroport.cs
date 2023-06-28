using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAeroport.Models
{
    public class Aeroport
    {
        [Key]
        public int CodRuta { get; set; }
        public string? Destinatia { get; set; }
        public int Clasa { get; set; }
        public double Pret { get; set; }

        [ForeignKey("CodPasager")]
        public int CodPasager { get; set; }
        public virtual Pasager? Pasager { get; set; }
    }
}   
