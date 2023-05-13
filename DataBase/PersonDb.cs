using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbClinic.DataBase
{
    public class PersonDb : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public PersonDb(DbContextOptions opts) : base(opts)
        {
        }
    }
}
