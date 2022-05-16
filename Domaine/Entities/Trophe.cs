using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.Domain.Entities
{
    public class Trophe
    {
        [DataType(DataType.Date)]
        public DateTime DateTrophe { get; set; }
        [DataType(DataType.Currency)]

        public double Recompense { get; set; }
        [Key]
        public int TropheeId { get; set; }
        public string TypeTrophee { get; set; }
        public int EquipeIdFK { get; set; }
        [ForeignKey("EquipeIdFK")]
        public virtual Equipe Equipe { get; set; }

    }
}
