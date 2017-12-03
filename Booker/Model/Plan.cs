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
        public DateTime Month { get;  }                                     //TODO: Create set method, update TimeFramePlan,Base&AllPeriods
        public PlanTimeFrame PlanTimeFrame { get; }                         //TODO: Create Set method, update TimeFramePlan and re-calc AllPeriods
        public List<DateTime> BaseTimeFramePeriods { get; }
        public List<DateTime> AllTimeFramePeriods { get; }
        public Dictionary<int, List<PlanItem>> TimeFramePlan { get; }       //number of PlanTimeFrame and Planned Item
        public Plan()
        {
            TimeFramePlan = new Dictionary<int, List<PlanItem>>();
        }
        public Plan(Cinema cinema, DateTime month, PlanTimeFrame timeframe):this()
        {
            Cinema = cinema;
            Month = month;
            PlanTimeFrame = timeframe;
            var t= TimeFramesInMonth();
            BaseTimeFramePeriods = t.Item1;
            AllTimeFramePeriods = t.Item2;
            TimeFramePlan = new Dictionary<int, List<PlanItem>>();
            for (int i = 1; i <= BaseTimeFramePeriods.Count;i++)
            {
                TimeFramePlan.Add(i, new List<PlanItem>());
            }
        }

        private Tuple<List<DateTime>,List<DateTime>> TimeFramesInMonth()
        {

            List<DateTime> baseList = new List<DateTime>();
            List<DateTime> allList = new List<DateTime>();
            int firstThursday = 0;
            int lastThursday = 0;                       
            int days = DateTime.DaysInMonth(Month.Year, Month.Month);
            for (int day = 1; day <= days; day++)
            {
                DateTime dt = new DateTime(Month.Year, Month.Month, day);
                if (dt.DayOfWeek == DayOfWeek.Thursday)
                {
                    baseList.Add(dt);
                    lastThursday = day;
                    if (firstThursday == 0)
                        firstThursday = day;
                }
            }
            switch (PlanTimeFrame)
            {
                case PlanTimeFrame.Week:
                    allList = baseList;
                    break;
                case PlanTimeFrame.Day:
                    int num = ((lastThursday - firstThursday)/7 + 1)*7;
                    DateTime dt=new DateTime(Month.Year, Month.Month, firstThursday);
                    for (int i = 1; i <= num; i++)
                    {
                        allList.Add(dt);
                        dt = dt.AddDays(1);
                    }
                        
                    break;
            }
            return Tuple.Create(baseList, allList);
        }

        public int Capacity()
        {
            //Cinema capacity in mintes for chosen PlanTimeFrame
            switch (PlanTimeFrame)
            {
                case PlanTimeFrame.Day:
                    return Cinema.Capacity;
                    break;
                case PlanTimeFrame.Week:
                    return Cinema.Capacity * 7;
                    break;
                default:
                    throw new NotImplementedException();
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
