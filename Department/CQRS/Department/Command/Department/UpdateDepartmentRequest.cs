using DepartmentService.IAppSercive.Department.Dto;
using MediatR;

namespace Department.Command.Department
{
    public class UpdateDepartmentRequest : IRequest<CreateOrUpdateDepartmentDto>
    {
        public CreateOrUpdateDepartmentDto CreateOrUpdateDepartmentDto { get; }
        public UpdateDepartmentRequest(CreateOrUpdateDepartmentDto createOrUpdateDepartmentDt)
        {
            CreateOrUpdateDepartmentDto = createOrUpdateDepartmentDt;
        }
    }
}

