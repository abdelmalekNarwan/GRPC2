using AutoMapper;
using Department.Query;
using DepartmentService.IAppSercive.Department;
using DepartmentService.IAppSercive.Department.Dto;
using MediatR;

namespace Department.Handeller.Department
{
    public class GetDepartmentQueryHandeller : IRequestHandler<GetDepartmentQuery, IEnumerable<DepartmentListDto>>
    {
        private readonly IDepartmentAppService _departmentAppService;
        public GetDepartmentQueryHandeller(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }
        public async Task<IEnumerable<DepartmentListDto>> Handle(GetDepartmentQuery request, CancellationToken cancellationToken)
        {
            var result = _departmentAppService.GetDepartment();
            return (IEnumerable<DepartmentListDto>)result;

        }
    }
}
