using AutoMapper;
using MediatR;
using Struggle.Data.Abstractions;
using Struggle.Data.Requests.Contracts;
using Struggle.Data.Requests.RequestQueries;
using Struggle.Entities;
namespace Struggle.Data.Management.Queries
{
    internal class GetCarByColorQuery : IRequestHandler<GetCarByColorRequest, CarDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetCarByColorQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<CarDto> Handle(GetCarByColorRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Car>();
            return await repository.Get<CarDto>(f => f.Color == request.Color, cancellationToken);
        }
    }
}
