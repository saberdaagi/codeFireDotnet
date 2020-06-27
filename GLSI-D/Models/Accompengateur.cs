using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GLSI_D.Models
{
    public class Accompengateur
    {
        [Key]
        public int Id_Accompengateur { get; set; }
        public int Numero { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }

    }
}