using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamP
{
    public partial class SubFinF : Form
    {
        private OracleConnection odpConn = new OracleConnection();
        FinancialF _parent;

        bool AD; //add인지 del인지 true : add , false : del
        public SubFinF(FinancialF inform1, bool b)
        {
            InitializeComponent();
            _parent = inform1;
            AD = b;
        }

        private void SubFinF_Load(object sender, EventArgs e)
        {
            if (!AD)
            {
                okBtn.Text = "삭제";
                datetxt.Text = _parent.getFlowDate;
                datetxt.Enabled = false;
                reasontxt.Text = _parent.getReason;
                reasontxt.Enabled = false;
                inrdoBtn.Enabled = false;
                outrdoBtn.Enabled = false;
                amounttxt.Text = _parent.getAmount;
                amounttxt.Enabled = false;
                if (_parent.getType == "1")
                {
                    inrdoBtn.Checked = true;
                }
                else { outrdoBtn.Checked = true; }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!AD)
            {
                DELETERow();
                this.Close();
            }
            else
            {
                INSERTRow();
                this.Close();
            }
        }
        private int DELETERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
            odpConn.Open();

            string finno = _parent.getFinno;   //**

            string strqry = "DELETE FROM financial WHERE finno = " + finno;

            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            return OraCmd.ExecuteNonQuery();

        }
        private int INSERTRow()
        {
            OracleCommand OraCmd;
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
            odpConn.Open();

            String flowdate = datetxt.Text.Trim();
            String reason = reasontxt.Text.Trim();
            int type = inrdoBtn.Checked ? 1 : 0;
            int amount = Convert.ToInt32(amounttxt.Text.Trim());

            string strqry = "INSERT INTO Financial(finno, flowdate, reason, ftype, amount) VALUES(FIN_SEQ.NEXTVAL, :flowdate, :reason, :type, :amount)";

            OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("flowdate", OracleDbType.Date).Value = DateTime.ParseExact(flowdate, "yyyy/MM/dd", CultureInfo.InvariantCulture);
            OraCmd.Parameters.Add("reason", OracleDbType.Varchar2).Value = reason;
            OraCmd.Parameters.Add("type", OracleDbType.Int32).Value = type;
            OraCmd.Parameters.Add("amount", OracleDbType.Int32).Value = amount;

            return OraCmd.ExecuteNonQuery(); // 추가되는 행수 반환
        }

        private void SubFinF_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Load_DBGrid();
            odpConn.Close();
        }
    }
}
