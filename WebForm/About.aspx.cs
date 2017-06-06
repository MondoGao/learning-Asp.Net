using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebForm
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sqlCon = new SqlConnection("Server=DESKTOPHW\\SQLEXPRESS;User id=sa;Pwd=testtesttest;Database=test");
            sqlCon.Open();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));

            dt.Rows.Add(new object[] { 1 });
        }
    }
}