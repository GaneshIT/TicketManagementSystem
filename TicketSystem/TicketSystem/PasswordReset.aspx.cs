using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketSystem
{
    public partial class PasswordReset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Session["custId"] = 1;
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=AZ-5CG1394FS0\SQLEXPRESS;Initial Catalog=TicketMgmtDb;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("USP_PasswordReset", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Session["custId"].ToString();
            sqlDataAdapter.SelectCommand.Parameters.Add("@question", SqlDbType.NVarChar).Value = ddlquestion.SelectedItem.Text;
            sqlDataAdapter.SelectCommand.Parameters.Add("@answer", SqlDbType.NVarChar).Value = txtanswer.Text;
            sqlDataAdapter.SelectCommand.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = txtmobile.Text;
            sqlDataAdapter.SelectCommand.Parameters.Add("@newpassword", SqlDbType.NVarChar).Value = txtpwd.Text;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
                if (dt.Rows[0][0].ToString() == "Updated")
                    lblResult.Text = "Password reset done";
                else
                    lblResult.Text = dt.Rows[0][0].ToString();

        }
    }
}