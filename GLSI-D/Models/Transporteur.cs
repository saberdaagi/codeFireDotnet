using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GLSI_D.Models
{
    public class Transporteur
    {
        [Key]
        public int Id_Transporteur { get; set; }
        public int Numero_Transporteur { get; set; }
        public string Nom_Transporteur { get; set; }
        public string Type_Transporteur { get; set; }


    }
}