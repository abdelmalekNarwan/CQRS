using MediatR;

namespace Cqrs.Services.Students.Queries.GetStudentList
{
    public class GetStudentListQuery:IRequest<List<StudentDto>>
    {

    }
}
