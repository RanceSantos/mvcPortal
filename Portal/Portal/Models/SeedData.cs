using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Portal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PortalContext(serviceProvider.GetRequiredService<DbContextOptions<PortalContext>>()))
            {
                if (context.Admin.Any())
                {
                    //if contains any data --- then we return --- we do not seed
                    return;
                }
                context.Admin.AddRange(
                new Admin
                {
                    StudentID = "1079-18",
                    Last_Name = "Santos",
                    First_Name = "Lean Andrew",
                    Birthdate = DateTime.Parse("2020-1-11"),
                    Age = 21,
                    Address = "Paranaque City",
                }

            );
                context.SaveChanges();

            }
        }
    }
}
