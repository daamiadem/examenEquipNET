using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GP.Data.Infrastructure;
using GP.Domain.Entities;
using GP.ServicePattern;

namespace GP.Service
{
    public class TropheService : EntityService<Trophe>, ITropheService
    {
        public TropheService(IUnitOfWork _utwk, IRepositoryBase<Trophe> _repository) : base(_utwk, _repository)
        {

        }

        public DateTime DatePRemierTrophe(Equipe Equipe)
        {
           return  GetMany(t => t.TypeTrophee == "Championnat" && t.EquipeIdFK == Equipe.EquipeId).OrderBy(t => t.DateTrophe)
               .Select(t => t.DateTrophe).First();
        }
    }
}
