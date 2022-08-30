using MediatR;
namespace Struggle.Data.Requests.RequestCommands
{
    public class DeleteBoatByIdRequest:IRequest<bool>
    {
        public DeleteBoatByIdRequest(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }

    }
}
