using AutoMapper;
using Cqrs.Entity;
using Cqrs.Reposatory;
using MediatR;

namespace Cqrs.Services.Students.Comands.CreateStudent
{
    public class CreateStudentCmandsHandler : IRequestHandler<CreateStudentComands, Guid>
    {
        private readonly IReposatory<Student> _studentReposatory;
        private readonly IMapper _mapper;
        public CreateStudentCmandsHandler(IReposatory<Student> studentReposatory, IMapper mapper)
        {
            _studentReposatory = studentReposatory;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateStudentComands request, CancellationToken cancellationToken)
        {
            var student = _mapper.Map<Student>(request);
            var result = await _studentReposatory.AddAsync(student);
            return result.Id;
        }
    }
}
