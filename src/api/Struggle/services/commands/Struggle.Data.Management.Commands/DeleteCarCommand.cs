using AutoMapper;
using MediatR;
using Struggle.Data.Abstractions;
using Struggle.Data.Requests.RequestCommands;
using Struggle.Entities;
namespace Struggle.Data.Management.Commands
{
    internal class DeleteCarCommand : IRequestHandler<DeleteCarByIdRequest, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DeleteCarCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(DeleteCarByIdRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Car>();
            var entity = await repository.Get<Car>(x => !x.IsDeleted && x.Id == request.Id, cancellationToken);
            if (entity == null)
            {
                return false;
            }
            repository.Delete(entity);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;
        }
    }
}
