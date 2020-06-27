using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GLSI_D.Models
{
    public class Trajet
    {
        [Key]
        public int Id_Trajet { get; set; }
        public int Id_Transporteur { get; set; }
        [ForeignKey("Id_Transporteur")]
        public virtual Transporteur transporteur { get; set; }
        public DateTime datedepart { get; set; }
        public int Duree { get; set; }

        public int Id_Parcour { get; set; }
        [ForeignKey("Id_Parcour")]
        public virtual Parcour parcour { get; set; }

    }
}