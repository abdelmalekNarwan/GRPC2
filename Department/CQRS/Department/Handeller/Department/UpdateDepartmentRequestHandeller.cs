using DepartmentService.IAppSercive.Department.Dto;
using DepartmentService.IAppSercive.Department;
using MediatR;
using Department.Command.Department;

namespace Department.Handeller.Department
{
    public class UpdateDepartmentRequestHandeller : IRequestHandler<CreateDepartmentRequest, CreateOrUpdateDepartmentDto>
    {
        private readonly IDepartmentAppService _departmentAppService;

        public UpdateDepartmentRequestHandeller(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }
        public Task<CreateOrUpdateDepartmentDto> Handle(CreateDepartmentRequest request, CancellationToken cancellationToken)
        {
            var result = _departmentAppService.Insert(request.CreateOrUpdateDepartmentDto);
            return result;
        }
    }
}
