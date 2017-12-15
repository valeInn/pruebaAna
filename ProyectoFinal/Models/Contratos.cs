using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Contratos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDContrat { get; set;  }
        public string Fi { get; set; }
        public string Ff { get; set; }
        public Propiedades Propiedades { get; set; }
        public Locatario Locatario { get; set; }
        public Garante Garante { get; set; }
        public Locador Locador { get; set;  }
    }
}