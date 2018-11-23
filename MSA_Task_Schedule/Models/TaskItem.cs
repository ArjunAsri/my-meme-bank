using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSA_Task_Schedule.Models
{
   
    public class TaskItem
    {
        public int Id { get; set; }
        public string Task_Name { get; set; }
        public int Task_Priority { get; set; }
        public string Task_Description { get; set; }
        public string Task_CourseNumber { get; set; }
        public DateTime Task_Deadline { get; set; }
    }

    public class MeetingItem
    {
        public int Id { get; set; }
        public string Meeting_Agenda { get; set; }
        public string Meeting_Description { get; set; }
        public int Meeting_Time { get; set; }

    }
}
