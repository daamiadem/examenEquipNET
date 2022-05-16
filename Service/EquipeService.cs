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
    public class EquipeService : EntityService<Equipe>, IEquipeService
    {
        public EquipeService(IUnitOfWork _utwk, IRepositoryBase<Equipe> _repository) : base(_utwk, _repository)
        {}


        public double Recompence(Equipe E)
        {
            var req = GetMany().Select(eq => eq.Trophes); 
            double somme = 0;
            foreach(Trophe item in req)
            {
                somme += item.Recompense; 

            }
            return somme;
        }

    }
}
