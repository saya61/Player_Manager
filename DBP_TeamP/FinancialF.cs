using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamP
{
    public partial class FinancialF : Form
    {
        private string finnoValue;
        public string getFinno { get { return finnoValue; } }

        private string flowDateValue;
        public string getFlowDate { get { return flowDateValue; } }

        private string reasonValue;
        public string getReason { get { return reasonValue; } }

        private string typeValue;
        public string getType { get { return typeValue; } }

        private string amountValue;
        public string getAmount { get {  return amountValue; } }
        OracleDataAdapter DBAdapter;

        DataSet DS;

        OracleCommandBuilder myCommandBuilder;
        DataTable finTable;
        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from Financial";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public FinancialF()
        {
            InitializeComponent();
            DB_Open();
        }

        private void FinancialF_Load(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();
                DBAdapter.Fill(DS, "financial");
                DBGrid.DataSource = DS.Tables["financial"].DefaultView;  //****
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
                //MessageBox.Show("1번");
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
                //MessageBox.Show("2번");
            }
            Load_Sum();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SubFinF sub = new SubFinF(this, true);
            sub.ShowDialog();
            sub.Dispose();
        }
        public void Load_DBGrid()
        {
            try
            {
                string connectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from Financial";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
                DS.Clear();
                DBAdapter.Fill(DS, "financial");
                DBGrid.DataSource = DS.Tables["financial"].DefaultView;
                Load_Sum();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
                //MessageBox.Show("1번");
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
                //MessageBox.Show("2번");
            }
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            SubFinF sub = new SubFinF(this, false);
            sub.ShowDialog();
            sub.Dispose();
        }

        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = DBGrid.Rows[rowIndex];
            DataGridViewCellCollection cells = selectedRow.Cells;

            finnoValue = cells["finno"].Value.ToString();
            flowDateValue = cells["flowdate"].Value.ToString();
            reasonValue = cells["reason"].Value.ToString();
            typeValue = cells["ftype"].Value.ToString();
            amountValue = cells["amount"].Value.ToString();
        }
        private void Load_Sum()
        {
            int inAmount = 0;
            int outAmount = 0;
            string ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
            string commandString = "SELECT SUM(amount) FROM Financial";
            OracleConnection odpConn = new OracleConnection(ConnectionString);
            odpConn.Open();

            commandString = "SELECT SUM(amount) FROM Financial WHERE FTYPE = 1";
            OracleCommand OraCmd = new OracleCommand(commandString, odpConn);
            object result = OraCmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                inAmount = Convert.ToInt32(result);
                incometxt.Text = inAmount.ToString();
            }
            else
            {
                incometxt.Text = "error";
            }
            commandString = "SELECT SUM(amount) FROM Financial WHERE FTYPE = 0";
            OraCmd = new OracleCommand(commandString, odpConn);
            result = OraCmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                outAmount = Convert.ToInt32(result);
                outcometxt.Text = outAmount.ToString();
            }
            else
            {
                outcometxt.Text = "error";
            }
            totaltxt.Text = (inAmount-outAmount).ToString();
        }
    }
}
