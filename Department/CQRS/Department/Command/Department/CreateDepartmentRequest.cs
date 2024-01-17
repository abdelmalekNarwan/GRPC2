using DepartmentService.IAppSercive.Department.Dto;
using MediatR;

namespace Department.Command.Department
{
    public class CreateDepartmentRequest : IRequest<CreateOrUpdateDepartmentDto>
    {
        public CreateOrUpdateDepartmentDto CreateOrUpdateDepartmentDto { get; }
        public CreateDepartmentRequest(CreateOrUpdateDepartmentDto createOrUpdateDepartmentDt)
        {
            CreateOrUpdateDepartmentDto = createOrUpdateDepartmentDt;
        }
    }
}
