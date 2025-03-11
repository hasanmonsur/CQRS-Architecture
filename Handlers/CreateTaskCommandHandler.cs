using MediatR;
using TaskManagementSystem.Commands;
using TaskManagementSystem.Data;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Handlers
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, int>
    {
        private readonly TaskContext _context;

        public CreateTaskCommandHandler(TaskContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new TaskModel
            {
                Title = request.Title,
                Description = request.Description,
                IsCompleted = false
            };

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync(cancellationToken);
            return task.Id;
        }
    }
}
