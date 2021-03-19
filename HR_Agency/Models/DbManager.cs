using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HR_Agency.Models
{
    public class DbManager : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}