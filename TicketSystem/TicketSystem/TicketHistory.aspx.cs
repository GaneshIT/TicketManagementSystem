using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketSystem
{
    public partial class TicketHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void ChangeTabColor(string status)
        {
            if (status == "Initiated")
            {
                lbtnInitiated.BackColor = System.Drawing.Color.Aquamarine;
                lbntRe_opned.BackColor = System.Drawing.Color.AliceBlue;
                lbtnClosed.BackColor = System.Drawing.Color.AliceBlue;
                lbtnResolved.BackColor = System.Drawing.Color.AliceBlue;
                lbtnUnassigned.BackColor = System.Drawing.Color.AliceBlue;
                lbtnAssigned.BackColor = System.Drawing.Color.AliceBlue;
            }
            else if (status == "Unassigned")
            {
                lbtnInitiated.BackColor = System.Drawing.Color.AliceBlue;
                lbntRe_opned.BackColor = System.Drawing.Color.AliceBlue;
                lbtnClosed.BackColor = System.Drawing.Color.AliceBlue;
                lbtnResolved.BackColor = System.Drawing.Color.AliceBlue;
                lbtnUnassigned.BackColor = System.Drawing.Color.Aquamarine;
                lbtnAssigned.BackColor = System.Drawing.Color.AliceBlue;
            }
            else if (status == "Assigned")
            {
                lbtnInitiated.BackColor = System.Drawing.Color.AliceBlue;
                lbntRe_opned.BackColor = System.Drawing.Color.AliceBlue;
                lbtnClosed.BackColor = System.Drawing.Color.AliceBlue;
                lbtnResolved.BackColor = System.Drawing.Color.AliceBlue;
                lbtnUnassigned.BackColor = System.Drawing.Color.AliceBlue;
                lbtnAssigned.BackColor = System.Drawing.Color.Aquamarine;
            }
            else if (status == "Re_opned")
            {
                lbtnInitiated.BackColor = System.Drawing.Color.AliceBlue;
                lbntRe_opned.BackColor = System.Drawing.Color.Aquamarine;
                lbtnClosed.BackColor = System.Drawing.Color.AliceBlue;
                lbtnResolved.BackColor = System.Drawing.Color.AliceBlue;
                lbtnUnassigned.BackColor = System.Drawing.Color.AliceBlue;
                lbtnAssigned.BackColor = System.Drawing.Color.AliceBlue;
            }
            else if (status == "Closed")
            {
                lbtnInitiated.BackColor = System.Drawing.Color.AliceBlue;
                lbntRe_opned.BackColor = System.Drawing.Color.AliceBlue;
                lbtnClosed.BackColor = System.Drawing.Color.Aquamarine;
                lbtnResolved.BackColor = System.Drawing.Color.AliceBlue;
                lbtnUnassigned.BackColor = System.Drawing.Color.AliceBlue;
                lbtnAssigned.BackColor = System.Drawing.Color.AliceBlue;
            }
            else if (status == "Resolved")
            {
                lbtnInitiated.BackColor = System.Drawing.Color.AliceBlue;
                lbntRe_opned.BackColor = System.Drawing.Color.AliceBlue;
                lbtnClosed.BackColor = System.Drawing.Color.AliceBlue;
                lbtnResolved.BackColor = System.Drawing.Color.Aquamarine;
                lbtnUnassigned.BackColor = System.Drawing.Color.AliceBlue;
                lbtnAssigned.BackColor = System.Drawing.Color.AliceBlue;
            }

        }
        protected void lbtnInitiated_Click(object sender, EventArgs e)
        {
            ChangeTabColor("Initiated");
            TicketBusiness ticketBusiness = new TicketBusiness();
            DataTable dt = ticketBusiness.ShowTicketHistory("Initiated");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    gvTicketHistory.DataSource = dt;
                    gvTicketHistory.DataBind();
                }
            }
        }

        protected void lbtnUnassigned_Click(object sender, EventArgs e)
        {
            ChangeTabColor("Unassigned");
            TicketBusiness ticketBusiness = new TicketBusiness();
            DataTable dt = ticketBusiness.ShowTicketHistory("Unassigned");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    gvTicketHistory.DataSource = dt;
                    gvTicketHistory.DataBind();
                }
            }
        }

        protected void lbtnAssigned_Click(object sender, EventArgs e)
        {
            ChangeTabColor("Assigned");
            TicketBusiness ticketBusiness = new TicketBusiness();
            DataTable dt = ticketBusiness.ShowTicketHistory("Assigned");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    gvTicketHistory.DataSource = dt;
                    gvTicketHistory.DataBind();
                }
            }
        }

        protected void lbtnResolved_Click(object sender, EventArgs e)
        {
            ChangeTabColor("Resolved");
            TicketBusiness ticketBusiness = new TicketBusiness();
            DataTable dt = ticketBusiness.ShowTicketHistory("Resolved");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    gvTicketHistory.DataSource = dt;
                    gvTicketHistory.DataBind();
                }
            }
        }

        protected void lbtnClosed_Click(object sender, EventArgs e)
        {
            ChangeTabColor("Closed");
            TicketBusiness ticketBusiness = new TicketBusiness();
            DataTable dt = ticketBusiness.ShowTicketHistory("Closed");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    gvTicketHistory.DataSource = dt;
                    gvTicketHistory.DataBind();
                }
            }
        }

        protected void lbntRe_opned_Click(object sender, EventArgs e)
        {
            ChangeTabColor("Re_opned");
            TicketBusiness ticketBusiness = new TicketBusiness();
            DataTable dt = ticketBusiness.ShowTicketHistory("Re_opned");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    gvTicketHistory.DataSource = dt;
                    gvTicketHistory.DataBind();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
        }

        protected void lbtnView_Click(object sender, EventArgs e)
        {
        }

        protected void gvTicketHistory_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id =Convert.ToInt32(e.CommandArgument.ToString());
            TicketBusiness ticketBusiness = new TicketBusiness();
            DataTable dt = ticketBusiness.ShowTicketDetail(id);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    txtId.Text = dt.Rows[0][0].ToString();
                    txtproblem.Text = dt.Rows[0][4].ToString();
                    txtresolution.Text=dt.Rows[0][11].ToString();
                    txtStatus.Text = dt.Rows[0][6].ToString();
                    txtticket.Text = "";
                }
            }
        }

        protected void gvTicketHistory_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}