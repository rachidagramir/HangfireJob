namespace graphapi.Services
{
    public interface IJobService
    {
        void RecurringJobsSendMail(string email);
        void ScheduleJobSendMail(string email);
        void EnqueuJobSendMail(string email);
    }
}
