using DepartmentService.IAppSercive.Department.Dto;
using MediatR;

namespace Department.Command.Department
{
    public class DeletDepartmentRequest : IRequest<bool>
    {
        public int DepartmentId { get; }
        public DeletDepartmentRequest(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
