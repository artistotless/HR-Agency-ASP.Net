

namespace HR_Agency.Models
{
    public class Vacancy
    {
        public int id { get; set; }
        public int idCategory { get; set; }
        public string title { get; set; }
        public int clientId { get; set; }
        public string status { get; set; }
        public string descr { get; set; }
    }
}