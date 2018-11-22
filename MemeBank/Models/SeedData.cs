using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MemeBank.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MemeBankContext(
                serviceProvider.GetRequiredService<DbContextOptions<MemeBankContext>>()))
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
