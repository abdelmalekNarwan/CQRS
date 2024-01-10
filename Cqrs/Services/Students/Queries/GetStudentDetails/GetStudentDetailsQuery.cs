using AutoMapper;
using Cqrs.Entity;
using Cqrs.Reposatory;
using MediatR;

namespace Cqrs.Services.Students.Queries.GetStudentDetails
{
    public class GetStudentDetailsQuery:IRequest<GetStudentDetailsDto>
    {
       public Guid Id { get; set; }  
    }
}
