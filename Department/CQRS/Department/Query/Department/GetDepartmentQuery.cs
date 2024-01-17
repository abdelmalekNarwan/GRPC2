using DepartmentService.IAppSercive.Department.Dto;
using MediatR;

namespace Department.Query
{
    public class GetDepartmentQuery :IRequest<IEnumerable<DepartmentListDto>>
    {
    }
}
