using Struggle.Data.Requests.Contracts;
using MediatR;
using Struggle.Common;

namespace Struggle.Data.Requests.RequestQueries
{
    public class GetCarByColorRequest:IRequest<CarDto>
    {
        public GetCarByColorRequest(Color color)
        {
            Color= color;
        }
    public Color Color { get; }
    }
}
