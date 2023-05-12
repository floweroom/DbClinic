using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DbClinic.DataBase
{

    internal class PersonDbFactory : IDesignTimeDbContextFactory<PersonDb>
    {
        public PersonDb CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<PersonDb>()
                .UseSqlServer("Server=(localDB)\\MSSQLLOCALDB;DATABASE=TestDB1")
                .Options;
            return new PersonDb(options);
        }
    }
}

