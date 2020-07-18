using EJob.Application.JobCQ.Queries.GetJobById;
using EJob.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJob.Application.JobCQ.Command.AddJob
{
    public class DeleteJobCommand: IRequest<JobViewModel>
    {
        public int Id { get; set; }
    }
}
