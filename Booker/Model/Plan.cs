using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Model
{
    public class Plan
    {
        public Cinema Cinema { get;  }
        public DateTime Month { get;  }
        public PlanTimeFrame PlanTimeFrame { get; }
        public int TimeFramePeriods { get; }
        public Dictionary<int, List<PlanItem>> TimeFramePlan { get; }       //number of PlanTimeFrame and Planned Item
        public Plan()
        {

        }
        public Plan(Cinema cinema, DateTime month, PlanTimeFrame timeframe)
        {
            Cinema = cinema;
            Month = month;
            PlanTimeFrame = timeframe;
            TimeFramePeriods = this.TimeFramesInMonth();
            TimeFramePlan = new Dictionary<int, List<PlanItem>>();
            for (int i = 1; i <= TimeFramePeriods;i++)
            {
                TimeFramePlan.Add(i, new List<PlanItem>());
            }
        }

        public int Capacity()
        {
            //Cinema capacity in mintes for cousen PlanTimeFrame
            switch (PlanTimeFrame)
            {
                case PlanTimeFrame.Day:
                    return Cinema.Capacity;
                    break;
                case PlanTimeFrame.Week:
                    return Cinema.Capacity * 7;
                    break;
                default: return 0;
                    break;
                }                       
        }

        private int TimeFramesInMonth()
        {
            
            int firstThursday = 0;
            int lastThursday = 0;
            int days = DateTime.DaysInMonth(Month.Year, Month.Month);
            for (int day = 1; day <= days; day++)
            {                                
                DateTime dt = new DateTime(Month.Year, Month.Month, day);
                if (dt.DayOfWeek == DayOfWeek.Thursday)
                {
                    lastThursday = day;
                    if (firstThursday == 0)
                        firstThursday = day;
                }
            }
            switch (PlanTimeFrame)
            {
                case PlanTimeFrame.Day:
                    return ((lastThursday - firstThursday) / 7 + 1) * 7;
                    break;
                case PlanTimeFrame.Week:
                    return (lastThursday - firstThursday)/7 + 1;
                    break;
                default:
                    return 0;
                    break;
            }
            
        }

        public int CapacityPlanned()
        {
            //Curentlly planned capacity
            int sum = 0;
            foreach (List<PlanItem> list in TimeFramePlan.Values)            
                foreach (PlanItem item in list)                
                    sum += item.Duration;

            return sum;
        }


    }
    
    public class PlanItem
    {
        private Film film;
        private Dictionary<SessionType, int> sessions;
        PlanItem(Film film, int sessionsNum)
        {
            this.film = film;
            this.sessions = new Dictionary<SessionType, int>();
            this.sessions.Add(SessionType.Day, sessionsNum);
        }

        PlanItem(Film film, int daySessionsNum, int eveningSessionsNum)
        {

            this.film = film;
            this.sessions = new Dictionary<SessionType, int>();
            this.sessions.Add(SessionType.Day, daySessionsNum);
            this.sessions.Add(SessionType.Evening, eveningSessionsNum);
        }
        public int Duration
        {
            get { return film.Duration * sessions.Count(); }
        }

        public Film Film
        {
            get { return film; }
        }
        public Dictionary<SessionType, int> Sessions
        {
            get { return sessions; }
        }
    }

    public enum PlanTimeFrame
    {
        Day, Week
    }
    public enum SessionType
    {
        Day,Evening
    }
}
