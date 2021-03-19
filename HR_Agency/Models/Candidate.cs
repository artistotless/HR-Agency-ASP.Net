

namespace HR_Agency.Models
{
    public class Candidate
    {
        public Candidate(string fio, string login, string pass, string portfolio, string phone, string descr)
        {
            this.fio = fio;
            this.login = login;
            this.pass = pass;
            this.portfolio = portfolio;
            this.phone = phone;
            this.descr = descr;
        }

        public Candidate()
        {
        }

        public int id { get; set; }
        public string fio { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
        public string portfolio { get; set; }
        public string phone { get; set; }
        public string descr { get; set; }
    }
}