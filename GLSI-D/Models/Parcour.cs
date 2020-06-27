using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GLSI_D.Models
{
    public class Parcour
    {
        [Key]
        public int Id_Parcour { get; set; }
        public virtual ICollection<Parcour> parcours { get; set; }

    }
}