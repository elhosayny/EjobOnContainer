using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJob.Application.JobServices.Queries.GetJobById
{
    public class GetJobByIdValidator : AbstractValidator<GetJobByIdQuery>
    {
        public GetJobByIdValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
