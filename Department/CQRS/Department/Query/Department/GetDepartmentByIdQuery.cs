using DepartmentService.IAppSercive.Department.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Department.Query
{
    public class GetDepartmentByIdQuery : IRequest<CreateOrUpdateDepartmentDto>
    {
        public int DepartmentId { get; }
        public GetDepartmentByIdQuery(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
