using HR_Agency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR_Agency.Pages
{
    public partial class candidates : System.Web.UI.Page
    {

        private DataStore repository = new DataStore();

        protected IEnumerable<Candidate> GetCandidates()
        {
            return repository.GetCandidates();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}