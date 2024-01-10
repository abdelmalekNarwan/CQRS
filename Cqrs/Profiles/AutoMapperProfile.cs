using AutoMapper;
using Cqrs.Entity;
using Cqrs.Services.Students.Comands.CreateStudent;
using Cqrs.Services.Students.Queries.GetStudentDetails;
using Cqrs.Services.Students.Queries.GetStudentList;

namespace Cqrs.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, GetStudentDetailsDto>().ReverseMap();
            CreateMap<Student, CreateStudentComands>().ReverseMap();
        }
    }
}
