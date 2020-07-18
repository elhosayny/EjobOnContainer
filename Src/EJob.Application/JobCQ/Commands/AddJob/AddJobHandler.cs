using AutoMapper;
using EJob.Application.JobCQ.Queries.GetJobById;
using EJob.Application.ViewModels;
using EJob.Domain.Entities;
using EJob.Domain.RepositoryContacts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EJob.Application.JobCQ.Command.AddJob
{
    public class AddJobHandler : IRequestHandler<AddJobCommand, JobViewModel>
    {
        private IJobRepository _jobRepository;
        private IMapper _mapper;

        public AddJobHandler(IJobRepository jobRepository,IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<JobViewModel> Handle(AddJobCommand request, CancellationToken cancellationToken)
        {
            var job = _mapper.Map<Job>(request.Job);
            job = _jobRepository.Add(job);
            await _jobRepository.UnitOfWork.SaveChangesAsync();

            return _mapper.Map<JobViewModel>(job);
        }
    }
}
