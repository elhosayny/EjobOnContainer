using EJob.Application.JobServices.Queries.GetJobById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJob.Application.JobServices.Queries.AddJob
{
    public class AddJobQuery: IRequest<JobViewModel>
    {
        public JobViewModel Job { get; set; }
    }
}
