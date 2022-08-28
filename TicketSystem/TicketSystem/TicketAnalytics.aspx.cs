using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketSystem
{
    public partial class TicketAnalytics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TicketBusiness ticketBusiness = new TicketBusiness();
                DataTable dt = ticketBusiness.ShowTicketAnalytics();
                if (dt != null)
                    if (dt.Rows.Count > 0)
                    {
                        lblassigned.Text = dt.Rows[0][5].ToString();
                        lblinitiated.Text = dt.Rows[0][0].ToString();
                        lblreopened.Text = dt.Rows[0][1].ToString();
                        lblunassigned.Text = dt.Rows[0][4].ToString();
                        lblresolved.Text = dt.Rows[0][2].ToString();
                        lblclosed.Text = dt.Rows[0][3].ToString();
                    }
            }
        }
    }
}