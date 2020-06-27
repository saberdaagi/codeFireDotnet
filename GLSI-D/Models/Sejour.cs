using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GLSI_D.Models
{
    public class Sejour:Voyage
    {
        public string Type_Sejour { get; set; }
        public string Description_Sejour { get; set; }
        public string Hebergement { get; set; }
        public string Categorie { get; set; }
        public int Id_Accompengateur { get; set; }
        [ForeignKey("Id_Accompengateur")]
        public virtual Accompengateur acompongnateur { get; set; }

    }
}