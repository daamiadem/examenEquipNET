using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.Domain.Entities
{
    public class Membre
    {
        [Key]
        public int Identifiant { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }
        [Required( ErrorMessage ="Le Nom est obligatoire") ]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le Prenom est obligatoire")]

        public string Prenom { get; set; }
        public virtual ICollection<Contrat> Contracts { get; set; }
    }
}
