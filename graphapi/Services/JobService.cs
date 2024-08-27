namespace graphapi.Services
{
    public class JobService : IJobService
    {
        public void EnqueuJobSendMail(string email)
        {
            Console.WriteLine("Mail Sent");
        }

        public void RecurringJobsSendMail(string email)
        {
            Console.WriteLine("Mail Sent");
        }

        public void ScheduleJobSendMail(string email)
        {
            Console.WriteLine("Mail will be sent ");
        }
    }
}
