using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GP.Domain.Entities
{
    public class Contrat
    {
        public DateTime DateContrat { get; set; }
        [Range(0, 24, ErrorMessage = "DureeMois entier positif qui ne dépasse pas la valeur 24")]

        public int DureeMois { get; set; }    
        public double Salaire { get; set; }
        public int EquipeIdFK { get; set; }
        public int IdentifiantFK { get; set; }
        [ForeignKey("EquipeIdFK")]
        public virtual Equipe Equipe { get; set; }
        [ForeignKey("IdentifiantFK")]

        public virtual Membre Membre { get; set; }

    }
}
