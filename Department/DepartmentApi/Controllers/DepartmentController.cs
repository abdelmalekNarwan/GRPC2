using DepartmentService.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase, IDepartmentAppService
    {
        private readonly IDepartmentAppService _appService;
        public DepartmentController(IDepartmentAppService appService)
        {
            _appService = appService;
        }
        [HttpGet]
        public async Task<List<string>> GetEmplyeeByDepartmentId(int id)
        {
            var names = await _appService.GetEmplyeeByDepartmentId(id);
            return names;
        }


    }
}
