using MediatR;
namespace Struggle.Data.Requests.RequestCommands
{
    public class DeleteCarByIdRequest : IRequest<bool>
    {
        public DeleteCarByIdRequest(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }

    }
}
