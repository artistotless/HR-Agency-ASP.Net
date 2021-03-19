using System.Collections.Generic;


namespace HR_Agency.Models
{
    public class DataStore
    {
        private DbManager context = new DbManager();

        public IEnumerable<Client> GetClients()
        {
            return context.Clients;
            
               
        }

        public IEnumerable<Vacancy> GetVacancies()
        {
            return context.Vacancies;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return context.Employees;
        }

        public IEnumerable<Candidate> GetCandidates()
        {
            return context.Candidates;
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.Categories;
        }

    }
}