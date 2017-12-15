using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class Propiedades
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDPropiedad { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Contratos> Contratos { get; set; }

    }
}