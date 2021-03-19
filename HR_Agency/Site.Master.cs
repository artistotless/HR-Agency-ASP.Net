using HR_Agency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR_Agency
{
    public partial class SiteMaster : MasterPage
    {

        private DataStore repository = new DataStore();

        protected IEnumerable<Category> GetCategories()
        {
            return repository.GetCategories();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }


    }
}