using MediatR;

namespace Cqrs.Services.Students.Comands.CreateStudent
{
    public class CreateStudentComands :IRequest<Guid>
    {
        public string Name { get; set; }
        public string Adress { get; set; }
    }
}
