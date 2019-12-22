using FluentValidation;

namespace EJob.Application.JobServices.Queries.AddJob
{
    public class AddJobValidator: AbstractValidator<AddJobQuery>
    {
        public AddJobValidator()
        {
            RuleFor(v => v.Job.Name).NotEmpty();
            RuleFor(v => v.Job.PageCount).NotEmpty();
            RuleFor(v => v.Job.SheetCount).NotEmpty();
            RuleFor(v => v.Job.CustomerCount).NotEmpty();
        }
    }
}
