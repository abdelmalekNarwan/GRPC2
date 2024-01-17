using DepartmentService.IAppSercive.Department.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentService.IAppSercive.Department
{
    public interface IDepartmentAppService
    {
        Task<List<DepartmentListDto>> GetDepartment();
        Task<CreateOrUpdateDepartmentDto> GetById(int Id);
        Task<CreateOrUpdateDepartmentDto> Insert(CreateOrUpdateDepartmentDto input);
        Task<bool> Delet(int Id);

    }
}
