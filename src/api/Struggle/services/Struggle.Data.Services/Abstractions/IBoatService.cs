using Struggle.Common;
using Struggle.Data.Requests.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struggle.Data.Services.Abstractions
{
    public interface IBoatService
    {
        Task<BoatDto> GetBoatByColor(Color color, CancellationToken cancellationToken);
        Task<bool> UpdateBoat(BoatDto data, CancellationToken cancellationToken);
        Task<bool> DeleteBoatById(Guid id, CancellationToken cancellationToken);
    }
}
