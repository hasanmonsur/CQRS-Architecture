using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Data;
using TaskManagementSystem.Models;
using TaskManagementSystem.Queries;

namespace TaskManagementSystem.Handlers
{
    public class GetAllTasksQueryHandler : IRequestHandler<GetAllTasksQuery, List<TaskModel>>
    {
        private readonly TaskContext _context;

        public GetAllTasksQueryHandler(TaskContext context)
        {
            _context = context;
        }

        public async Task<List<TaskModel>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
        {
            return await _context.Tasks.ToListAsync(cancellationToken);
        }
    }
}
