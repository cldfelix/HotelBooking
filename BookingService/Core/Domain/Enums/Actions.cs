using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum Actions
    {
        Pay,
        Finish, // Comprou e usou
        Cancel, // Nunca foi pago
        Refound, // Pago e retornado
        Reopen // Cancelado
    }
}
