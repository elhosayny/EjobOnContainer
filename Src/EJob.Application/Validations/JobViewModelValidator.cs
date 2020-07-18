using EJob.Application.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJob.Application.JobCQ.Queries.GetJobById
{
    public class JobViewModelValidator : AbstractValidator<JobViewModel>
    {
        public JobViewModelValidator()
        {
            RuleFor(v => v.Name).NotEmpty();
        }
    }
}
