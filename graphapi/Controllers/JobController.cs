using graphapi.Services;
using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace graphapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
            
        }
        [HttpGet]
        public void RecurringJobsSendMail()
        {
            RecurringJob.AddOrUpdate(
                "myrecurringjob",
                () => _jobService.RecurringJobsSendMail("rachida44@gmail.com"),
                Cron.Minutely);
        }

        [HttpGet("ScheduledJob")]
        public void SchedulJobsSendMail()
        {
            BackgroundJob.Schedule(
            () => _jobService.ScheduleJobSendMail("SheduleJob@gmail.com"),
                TimeSpan.FromMinutes(1));
        }


        [HttpGet("EnqueuJob")]
        public void EnqueuJobsSendMail()
        {
            BackgroundJob.Enqueue(
             () => _jobService.EnqueuJobSendMail("Enqueu@gmail.com"));
        }

    }
}
