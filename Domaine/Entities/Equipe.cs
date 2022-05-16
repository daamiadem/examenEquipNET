using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.Domain.Entities
{
    public class Equipe
    {
        public int EquipeId { get; set; }
        public string AdresseLocal { get; set; }
        public string Logo { get; set; }
        public string NomEquipe { get; set; }
        public int TropheIdFK { get; set; }
        
        public virtual IList<Trophe> Trophes { get; set; }
        public virtual IList<Contrat> Contracts { get; set; }


    }
}
