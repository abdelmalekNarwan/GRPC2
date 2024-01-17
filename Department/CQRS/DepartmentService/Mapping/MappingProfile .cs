using AutoMapper;
using DepartmentDAL.Entity;
using DepartmentService.IAppSercive.Department.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentService.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentListDto>().ReverseMap();
        }
    }
}
