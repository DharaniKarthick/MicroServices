using MeetingServices.Model;

namespace MeetingServices.Service
{
    public interface IMeetingService
    {
        int GetMeetingCount();
        List<Meeting> GetAllMeeting();
    }
}
