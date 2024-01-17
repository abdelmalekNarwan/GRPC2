using AutoMapper;
using DepartmentDAL.Entity;
using DepartmentDAL.Migrations;
using DepartmentDAL.Reposatory;
using DepartmentService.IAppSercive.Department;
using DepartmentService.IAppSercive.Department.Dto;


namespace DepartmentService.AppService.Departments
{
    public class DepartmentAppService : IDepartmentAppService
    {
        private readonly IRepository<Department> _repository;
        private readonly IMapper _mapper;

        public DepartmentAppService(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public async Task<CreateOrUpdateDepartmentDto> Insert(CreateOrUpdateDepartmentDto input)
        {
            var data = _mapper.Map<Department>(input);
            _repository.Insert(data);
            return new CreateOrUpdateDepartmentDto();
        }
        public async Task<CreateOrUpdateDepartmentDto> GetById(int Id)
        {
            var result = _repository.GetById(Id);
            return _mapper.Map<CreateOrUpdateDepartmentDto>(result);
        }
        public async Task<List<DepartmentListDto>> GetDepartment()
        {
            var result = _repository.GetAll().ToList();
            return _mapper.Map<List<DepartmentListDto>>(result);
        }

        public async Task<bool> Delet(int Id)
        {
            _repository.Delete(Id);
            return true;
        }
    }
}
