using AutoMapper;
using EJob.Application.ViewModels;
using EJob.Domain.Entities;
using EJob.Domain.RepositoryContacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EJob.Application.JobCQ.Queries.GetAllJobs
{
    class GetAllJobsHandler : IRequestHandler<GetAllJobsQuery, IEnumerable<JobViewModel>>
    {
        private IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public GetAllJobsHandler(IJobRepository jobRepository,IMapper mapper)
        {
            _jobRepository = jobRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<JobViewModel>> Handle(GetAllJobsQuery request, CancellationToken cancellationToken)
        {
            var jobs = await _jobRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<JobViewModel>>(jobs);
        }
    }
}
