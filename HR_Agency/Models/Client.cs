

namespace HR_Agency.Models
{
    public class Client
    {
        public Client()
        {
        }

        public Client(string fioAgent, string login, string pass, string companyName, int employeeId, string phone, string descr)
        {
            
            this.fioAgent = fioAgent;
            this.login = login;
            this.pass = pass;
            this.companyName = companyName;
            this.employeeId = employeeId;
            this.phone = phone;
            this.descr = descr;
        }

        public int id { get; set; }
        public string fioAgent { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
        public string companyName { get; set; }
        public int employeeId { get; set; }
        public string phone { get; set; }
        public string descr { get; set; }
    }
}