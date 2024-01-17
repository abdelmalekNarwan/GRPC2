using Department.Query;
using DepartmentService.IAppSercive.Department;
using DepartmentService.IAppSercive.Department.Dto;
using MediatR;

namespace Department.Handeller.Department
{
    public class GetDepartmentByIdQueryHandeler : IRequestHandler<GetDepartmentByIdQuery, CreateOrUpdateDepartmentDto>
    {
        private readonly IDepartmentAppService _departmentAppService;

        public GetDepartmentByIdQueryHandeler(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }

        public Task<CreateOrUpdateDepartmentDto> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _departmentAppService.GetById(request.DepartmentId);
            return result;
        }
    }
}
