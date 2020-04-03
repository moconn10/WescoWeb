using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WescoWeb.Models;

namespace WescoWeb.DAL
{
    public class donutinitializer : System.Data.Entity.DropCreateDatabaseAlways<wescocontext>
    {
        protected override void Seed(wescocontext context)
        {
            var employees = new List<employee>
            {
                new employee { employeeID = 000, fname = "Ken", lname = "Butts", hours = 32, deliver = true },
                new employee { employeeID = 001, fname = "Harvey", lname = "Dent", hours = 32, deliver = true },
                new employee { employeeID = 002, fname = "Bruce", lname = "Wayne", hours = 32, deliver = false },
                new employee { employeeID = 003, fname = "Salena", lname = "Kyle", hours = 32, deliver = true },
                new employee { employeeID = 004, fname = "Oswald", lname = "Cobblepot", hours = 32, deliver = true }
            };

            employees.ForEach(s => context.employees.Add(s));
            context.SaveChanges();
            var donuts = new List<donut>
            {
                new donut {donutID = 001, name = "plain cake", price = 1.15f, date=DateTime.Parse("01/18/2020"), ordered = 200, production = 1000, wasted = 100},
                new donut {donutID = 002, name = "longjohn", price = 1.15f, date=DateTime.Parse("01/18/2020"), ordered = 200, production = 1000, wasted = 100},
                new donut {donutID = 003, name = "chocolate cake", price = 1.15f, date=DateTime.Parse("01/18/2020"), ordered = 200, production = 1000, wasted = 100},
                new donut {donutID = 004, name = "fritter", price = 1.15f, date=DateTime.Parse("01/18/2020"), ordered = 300, production = 1000, wasted = 10}
            };
            donuts.ForEach(s => context.donuts.Add(s));
            context.SaveChanges();
            var schedules = new List<schedule>
            {
                new schedule{scheduleID = 001, fname = "Ken", lname = "Butts", hours = 28},
                new schedule{scheduleID = 001, fname = "Harvey", lname = "Dent", hours = 28},
                new schedule{scheduleID = 001, fname = "Bruce", lname = "Wayne", hours = 16}
            };
            schedules.ForEach(s => context.schedules.Add(s));
            context.SaveChanges();
            var wescos = new List<wesco>
            {
                new wesco{wescoID = 12, managerfname = "Clark", managerlname = "Kent", password = "password1"}
            };
            wescos.ForEach(s => context.wescos.Add(s));
            context.SaveChanges();
        }
    }
}