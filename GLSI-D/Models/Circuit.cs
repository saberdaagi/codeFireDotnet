using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GLSI_D.Models
{
    public class Circuit: Voyage
    {
        public string Theme_Circuit { get; set; }
        public string Description_Circuit { get; set; }
        public string MoyenTransport_Circuit { get; set; }

        public int Id_Parcour { get; set; }
        [ForeignKey("Id_Parcour")]
        public   Parcour parcour;

    }
}