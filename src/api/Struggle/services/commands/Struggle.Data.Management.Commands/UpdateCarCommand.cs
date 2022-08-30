using AutoMapper;
using MediatR;
using Struggle.Data.Abstractions;
using Struggle.Data.Requests.RequestCommands;
using Struggle.Entities;
namespace Struggle.Data.Management.Commands
{
    internal class UpdateCarCommand : IRequestHandler<UpdateCarRequest, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateCarCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<bool> Handle(UpdateCarRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Car>();
            var entity = await repository.Get<Car>(f => f.Id == request.Data.Id, cancellationToken);
            if (entity is null)
            {
                return false;
            }
            var mapped = mapper.Map(request.Data, entity);
            repository.Update(mapped);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;
        }
    }
}
