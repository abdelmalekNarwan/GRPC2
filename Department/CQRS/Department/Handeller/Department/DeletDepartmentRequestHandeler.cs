using Department.Command.Department;
using Department.Query;
using DepartmentService.IAppSercive.Department;
using DepartmentService.IAppSercive.Department.Dto;
using MediatR;

namespace Department.Handeller.Department
{
    public class DeletDepartmentRequestHandeler : IRequestHandler<DeletDepartmentRequest, bool>
    {
        private readonly IDepartmentAppService _departmentAppService;

        public DeletDepartmentRequestHandeler(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }
        public Task<bool> Handle(DeletDepartmentRequest request, CancellationToken cancellationToken)
        {
            var result = _departmentAppService.Delet(request.DepartmentId);
            return result;
        }
    }
}
