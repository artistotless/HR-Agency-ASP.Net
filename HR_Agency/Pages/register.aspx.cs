using HR_Agency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR_Agency.Pages
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                var login = Request.Form["login"];
                var fioAgent = Request.Form["fio"];
                var pass = Request.Form["pass"];
                var companyName = CName.Text;
                var employeeId = 1;
                var phone = Request.Form["phone"];
                var descr = Request.Form["descr"];
                var portfolio = Portfolio.Text;


                var manager = new DbManager();
                if (!string.IsNullOrEmpty(portfolio) && string.IsNullOrEmpty(companyName))
                {
                    Candidate selectedCandidate = new DataStore().GetCandidates().Where(c => c.login == login).FirstOrDefault();
                    if (selectedCandidate == null)
                    {
                        var newCandidate = new Candidate(fioAgent, login, pass, portfolio, phone, descr);
                        manager.Candidates.Add(newCandidate);
                    }
                    else
                    {
                        Response.Redirect("/Pages/alert.aspx?msg='Ошибка, такой кандидат уже существует!'");
                        // Ошибка, такой кандидат уже существует!
                    }
                }
                else
                {
                    Client selectedClient = new DataStore().GetClients().Where(c => c.login == login).FirstOrDefault();
                    if (selectedClient == null)
                    {
                        var newClient = new Client(fioAgent, login, pass, companyName, employeeId, phone, descr);
                        manager.Clients.Add(newClient);
                    }
                    else
                    {
                        Response.Redirect("/Pages/alert.aspx?msg='Ошибка, такой клиент уже существует!'");

                        // Ошибка, такой клиент уже существует!
                    }
                }
                Response.Redirect("/Pages/alert.aspx?msg='Вы успешно зарегистровались!'");

                manager.SaveChanges();
            }
        }
    }

}
