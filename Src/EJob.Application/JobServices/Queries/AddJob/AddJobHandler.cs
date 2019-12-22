using AutoMapper;
using EJob.Application.JobServices.Queries.GetJobById;
using EJob.Domain.Entities;
using EJob.Domain.RepositoryContacts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EJob.Application.JobServices.Queries.AddJob
{
    public class AddJobHandler : IRequestHandler<AddJobQuery, JobViewModel>
    {
        private IJobRepository _jobRepository;
        private IMapper _mapper;

        public AddJobHandler(IJobRepository jobRepository,IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<JobViewModel> Handle(AddJobQuery request, CancellationToken cancellationToken)
        {
            var job = _mapper.Map<Job>(request.Job);
            job = _jobRepository.Add(job);
            await _jobRepository.UnitOfWork.SaveChangesAsync();

            return _mapper.Map<JobViewModel>(job);
        }
    }
}
