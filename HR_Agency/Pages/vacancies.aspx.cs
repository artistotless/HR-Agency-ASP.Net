using HR_Agency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR_Agency.Pages
{
    public partial class vacancies : System.Web.UI.Page
    {
        private DataStore repository = new DataStore();
        public int idCat = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            idCat = int.TryParse(Request.QueryString["cat"], out idCat) ? idCat : 1;
        }

        protected IEnumerable<Vacancy> GetVacancies()
        {
            if (idCat == 0)
            {
                idCat = int.TryParse(Request.QueryString["cat"], out idCat) ? idCat : 0;
            }
            if (idCat == 0)
            {
                return null;
            }
            return repository.GetVacancies()
                .Where(v => v.idCategory == idCat);

        }
    }
}