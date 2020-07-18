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
    public class DeleteJobHandler : IRequestHandler<DeleteJobCommand,JobViewModel>
    {
        private IJobRepository _jobRepository;
        private IMapper _mapper;

        public DeleteJobHandler(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<JobViewModel> Handle(DeleteJobCommand request, CancellationToken cancellationToken)
        {
            var job = await _jobRepository.DeleteAsync(request.Id);
            await _jobRepository.UnitOfWork.SaveChangesAsync();

            return _mapper.Map<JobViewModel>(job);
        }
    }
}
