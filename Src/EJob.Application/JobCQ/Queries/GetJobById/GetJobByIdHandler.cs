using AutoMapper;
using EJob.Application.ViewModels;
using EJob.Domain.RepositoryContacts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EJob.Application.JobCQ.Queries.GetJobById
{
    public class GetJobByIdHandler : IRequestHandler<GetJobByIdQuery, JobViewModel>
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public GetJobByIdHandler(IJobRepository jobRepository,IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<JobViewModel> Handle(GetJobByIdQuery request, CancellationToken cancellationToken)
        {
            var job = await _jobRepository.GetAsync(request.Id);
            return _mapper.Map<JobViewModel>(job);
        }
    }
}
