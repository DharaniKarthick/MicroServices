using MeetingServices.Model;

namespace MeetingServices.Repository
{
    public interface IMeetingRepository
    {
        int GetMeetingCount();
        List<Meeting> GetAllMeetings();
    }
}
