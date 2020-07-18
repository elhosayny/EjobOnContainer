using EJob.Application.JobCQ.Queries.GetJobById;
using EJob.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJob.Application.JobCQ.Command.AddJob
{
    public class AddJobCommand: IRequest<JobViewModel>
    {
        public JobViewModel Job { get; set; }
    }
}
