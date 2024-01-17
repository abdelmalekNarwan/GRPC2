using Department.Command.Department;
using Department.Query;
using DepartmentService.IAppSercive.Department.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Department.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class DepartmentController : Controller
    {
        private readonly IMediator _mediator;
        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(Name = "GetAllDepartment")]
        public async Task<IActionResult> GetAllDepartment()
        {
            var query = new GetDepartmentQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet("{id}", Name = "GetDepartmentById")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var query = new GetDepartmentByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpPost(Name = "Create")]
        public async Task<IActionResult> Create([FromQuery] CreateOrUpdateDepartmentDto input)
        {
            var Comand = new CreateDepartmentRequest(input);
            var result = await _mediator.Send(Comand);
            return Ok(result);
        }
        [HttpPost(Name = "Update")]
        public async Task<IActionResult> Update([FromQuery] CreateOrUpdateDepartmentDto input)
        {
            var Comand = new CreateDepartmentRequest(input);
            var result = await _mediator.Send(Comand);
            return Ok(result);
        }
        [HttpPost(Name = "Delet")]
        public async Task<IActionResult> Delet(int id)
        {
            var Comand = new DeletDepartmentRequest(id);
            var result = await _mediator.Send(Comand);
            return Ok(result);
        }
    }
}
