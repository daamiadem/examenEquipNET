using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GP.Domain.Entities;
using GP.ServicePattern;
namespace GP.Service
{
    public interface IContratService : IEntityService<Contrat>
    {
        IEnumerable<Joueur> ListJoueursTrophee(Trophe TR);
        IEnumerable<Entraineur> ListEntraineurByEquipe(Equipe Equipe); 
    }
}
