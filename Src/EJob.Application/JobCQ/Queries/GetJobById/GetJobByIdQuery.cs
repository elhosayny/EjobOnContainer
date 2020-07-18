using EJob.Application.ViewModels;
using MediatR;

namespace EJob.Application.JobCQ.Queries.GetJobById
{
    public class GetJobByIdQuery : IRequest<JobViewModel>
    {
        public int Id { get; set; }
    }
}
