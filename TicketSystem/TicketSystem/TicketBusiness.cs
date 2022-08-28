using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TicketSystem
{
    public class TicketBusiness
    {
        public DataTable ShowTicketHistory(string status)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=AZ-5CG1394FS0\SQLEXPRESS;Initial Catalog=TicketMgmtDb;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("USP_TicketHistory", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.Add("@status", SqlDbType.NVarChar).Value =status;           
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        public DataTable ShowTicketDetail(int ticketId)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=AZ-5CG1394FS0\SQLEXPRESS;Initial Catalog=TicketMgmtDb;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("USP_TicketDetail", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = ticketId;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        public DataTable ShowTicketAnalytics()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=AZ-5CG1394FS0\SQLEXPRESS;Initial Catalog=TicketMgmtDb;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("USP_TicketAnalytics", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
    }
}