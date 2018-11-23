using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MSA_Task_Schedule.Models;

namespace MSA_Task_Schedule.Models
{
    public class MSA_Task_ScheduleContext : DbContext
    {
        public MSA_Task_ScheduleContext (DbContextOptions<MSA_Task_ScheduleContext> options)
            : base(options)
        {
        }

        public DbSet<MSA_Task_Schedule.Models.MeetingItem> MeetingItem { get; set; }

        public DbSet<MSA_Task_Schedule.Models.TaskItem> TaskItem { get; set; }
    }
}
