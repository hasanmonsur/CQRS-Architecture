using MediatR;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Queries
{
    public class GetAllTasksQuery : IRequest<List<TaskModel>> { }
}
