using MeetingServices.DatabaseContext;
using MeetingServices.Model;

namespace MeetingServices.Repository
{
    public class MeetingRepository:IMeetingRepository
    {
        private readonly MeetingDBContext _context;

        public MeetingRepository(MeetingDBContext context)
        {
            _context = context;
        }

        public int GetMeetingCount()
        {
            return _context.Meetings.Count();
        }

        public List<Meeting> GetAllMeetings()
        {
            return _context.Meetings.ToList();
        }
    }
}
