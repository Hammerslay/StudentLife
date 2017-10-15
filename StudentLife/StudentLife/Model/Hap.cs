using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLife.Model
{
    class Hap
    {
        private int id;
        private string name;
        private DateTime hapDate; //Might only need two of these three DateTimes, one for start and one for end?
        private DateTime startTime;
        private DateTime endTime;
        private string hapDescription;
        private int cost;
        private Organization orgName;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime HapDate { get => hapDate; set => hapDate = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public string HapDescription { get => hapDescription; set => hapDescription = value; }
        public int Cost { get => cost; set => cost = value; }
        public Organization OrgName { get => orgName; set => orgName = value; }
    }
}
