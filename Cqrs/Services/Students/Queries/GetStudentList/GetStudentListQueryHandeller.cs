using AutoMapper;
using Cqrs.Entity;
using Cqrs.Reposatory;
using MediatR;

namespace Cqrs.Services.Students.Queries.GetStudentList
{
    public class GetStudentListQueryHandeller : IRequestHandler<GetStudentListQuery, List<StudentDto>>
    {
        private readonly IReposatory<Student> _studentReposatory;
        private readonly IMapper _mapper;
        public GetStudentListQueryHandeller(IReposatory<Student> studentReposatory, IMapper mapper)
        {
            _studentReposatory = studentReposatory;
            _mapper = mapper;
        }
        public async Task<List<StudentDto>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentReposatory.GetAllListAsync();
            return _mapper.Map<List<StudentDto>>(students);
        }
    }
}
