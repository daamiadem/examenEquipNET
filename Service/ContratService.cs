using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GP.Data;
using GP.Data.Infrastructure;
using GP.Domain.Entities;
using GP.ServicePattern;
using System.Linq;
using System.Collections;

namespace GP.Service
{
    public class ContratService : EntityService<Contrat>, IContratService
    {
        public ContratService(IUnitOfWork _utwk, IRepositoryBase<Contrat> _repository) : base(_utwk, _repository)
        {
        }

        public IEnumerable<Joueur> ListJoueursTrophee(Trophe TR)
        {
            var req = GetMany(c=> c.EquipeIdFK==TR.EquipeIdFK && (TR.DateTrophe - c.DateContrat).Days< c.DureeMois*30)
                .Select(c=>c.Membre).OfType<Joueur>();
            return req; 
        }
        public IEnumerable<Entraineur> ListEntraineurByEquipe(Equipe Equipe)
        {
            return GetMany(c => c.EquipeIdFK == Equipe.EquipeId).Select(c => c.Membre).OfType<Entraineur>();
        }
    }
}
