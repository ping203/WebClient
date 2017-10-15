using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraRichEdit;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private DataTable LoadFromDB()
        {
            SqlConnection conn = new SqlConnection("Data Source=tuyetnhi-pc;Initial Catalog=WebClient;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Question where ClassID = (select ClassID from qclass where ClassNbr = 1) and QuestionNbr = '1' order by newid()", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = LoadFromDB();
            ASPxRichEdit1.Open(dt.Rows[0]["QuestionID"].ToString(), DocumentFormat.Rtf ,() => (byte[])dt.Rows[0]["Question"]);

            ASPxRichEditA.Open(dt.Rows[0]["QuestionID"] + "_A1", DocumentFormat.Rtf, () => (byte[]) dt.Rows[0]["Answer1"]);

            ASPxRichEditB.Open(dt.Rows[0]["QuestionID"] + "_A2", DocumentFormat.Rtf, () => (byte[])dt.Rows[0]["Answer2"]);

            ASPxRichEditC.Open(dt.Rows[0]["QuestionID"] + "_A3", DocumentFormat.Rtf, () => (byte[])dt.Rows[0]["Answer3"]);

            ASPxRichEditD.Open(dt.Rows[0]["QuestionID"] + "_A4", DocumentFormat.Rtf, () => (byte[])dt.Rows[0]["Answer4"]);            
        }
    }
}