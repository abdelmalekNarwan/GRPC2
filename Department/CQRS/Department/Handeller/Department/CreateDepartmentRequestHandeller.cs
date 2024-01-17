using Department.Command.Department;
using Department.Query;
using DepartmentService.IAppSercive.Department;
using DepartmentService.IAppSercive.Department.Dto;
using MediatR;

namespace Department.Handeller.Department
{
    public class CreateDepartmentRequestHandeller : IRequestHandler<CreateDepartmentRequest, CreateOrUpdateDepartmentDto>
    {
        private readonly IDepartmentAppService _departmentAppService;

        public CreateDepartmentRequestHandeller(IDepartmentAppService departmentAppService)
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
