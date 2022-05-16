using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GP.Domain.Entities;
using GP.ServicePattern;

namespace GP.Service
{
    public interface ITropheService : IEntityService<Trophe>
    {
        DateTime DatePRemierTrophe(Equipe Equipe); 
    }
}
