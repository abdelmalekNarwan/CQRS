using AutoMapper;
using Cqrs.Entity;
using Cqrs.Reposatory;
 using MediatR;

namespace Cqrs.Services.Students.Queries.GetStudentDetails
{
    public class GetstudentDetailsQueryHandeler : IRequestHandler<GetStudentDetailsQuery, GetStudentDetailsDto>
    {
        private readonly IReposatory<Student> _studentReposatory;
        private readonly IMapper _mapper;
        public GetstudentDetailsQueryHandeler(IReposatory<Student> studentReposatory, IMapper mapper)
        {
            _studentReposatory = studentReposatory;
            _mapper = mapper;
        }
        public async Task<GetStudentDetailsDto> Handle(GetStudentDetailsQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentReposatory.GetbyIdAsync(request.Id);
            return _mapper.Map<GetStudentDetailsDto>(student);
        }
    }
}
