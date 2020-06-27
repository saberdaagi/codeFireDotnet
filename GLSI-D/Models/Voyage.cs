using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GLSI_D.Models
{
    [Table("Voyage")]
    public abstract class Voyage
    {
        [Key]
        public int Id_Voyage { get; set; }
        public int Num_Voyage { get; set; }

        public int Duree_Voyage { get; set; }

    }
}