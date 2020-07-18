using EJob.Application.ViewModels;
using EJob.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJob.Application.JobCQ.Queries.GetAllJobs
{
    public class GetAllJobsQuery : IRequest<IEnumerable<JobViewModel>>
    {
    }
}
