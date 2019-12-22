using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EJob.Application.JobServices.Queries.GetJobById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EJob.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class JobController : Controller
    {
        private readonly IMediator _mediator;

        public JobController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> GetJobById(int id)
        {
            var query = new GetJobByIdQuery { Id = id };
            var job = await _mediator.Send(query);
            if (job == null) return BadRequest();
            return Ok(job);
        }

        [HttpPost]
        public async Task<ActionResult> AddJob(JobViewModel job)
        {

            return Ok("ok");
        }
    }
}