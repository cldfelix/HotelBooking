using Domain.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports
{
    public interface IGuestRepository
    {
        Task<Guest> Get(Guid id);
        Task<List<Guest>> GetAll();
        Task Delete(Guid id);
        Task<Guid> Save(Guest guest);
       
    }
}
