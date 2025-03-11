using MediatR;

namespace TaskManagementSystem.Commands
{
    public class CreateTaskCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
