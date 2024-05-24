using MeetingServices.Model;
using MeetingServices.Repository;

namespace MeetingServices.Service
{
    public class MeetingsService:IMeetingService
    {
        private readonly IMeetingRepository _repository;

        public MeetingsService(IMeetingRepository repository)
        {
            _repository = repository;
        }

        public int GetMeetingCount()
        {
            return _repository.GetMeetingCount();
        }

        public List<Meeting> GetAllMeeting()
        {
            return _repository.GetAllMeetings();
        }
    }
}
