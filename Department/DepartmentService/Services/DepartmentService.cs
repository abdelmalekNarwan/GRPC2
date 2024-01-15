using DepartmentDomain.Entity;
using DepartmentReposatory.Reposatory;
using DepartmentService.IServices;
using Grpc.Net.Client;
using GrpcEmployeeService.Protos;

namespace DepartmentService.Services
{
    public class DepartmentService : IDepartmentAppService
    {
        private readonly IGenericRepository<Department> _repository;
        public DepartmentService(IGenericRepository<Department> repository)
        {
            _repository = repository;
        }
        public async Task<List<string>> GetEmplyeeByDepartmentId(int id)
        {
           // var Names = _repository.GetAll().Select(a => a.Name).ToList();
            var Names =new  List<string>();
            var channel = GrpcChannel.ForAddress("https://localhost:7057");
            var client = new Employee.EmployeeClient(channel);
           
                var data = client.GetEmplyeeByDepartmentId(new EmployeeInputDto() { DepartmentId = id });

            Names.Add(data?.Name);
            return Names ;
        }
    }
}
