using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace MSA_Task_Schedule.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MSA_Task_ScheduleContext(
                serviceProvider.GetRequiredService<DbContextOptions<MSA_Task_ScheduleContext>>()))
            {
                // Look for any movies.
                if (context.TaskItem.Count() > 0)
                {
                    return;   // DB has been seeded
                }

                context.TaskItem.AddRange(
                    new TaskItem
                    {
                        Id = 1,
                        Task_Name = "Complete ROL",
                        Task_Priority = 5,
                        Task_Description = "ROL is just some random stuff",
                        Task_CourseNumber = "ENGGEN403",
                        Task_Deadline = DateTime.Parse("11/01/2018")
                    }


                );
                context.SaveChanges();
            }
        }
    }
}




