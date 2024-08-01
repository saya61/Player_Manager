using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamP
{
    public partial class PIG1 : Form
    {
        OracleDataAdapter DBAdapter;

        DataSet DS;

        OracleCommandBuilder myCommandBuilder;

        private int rdoselected = 0;

        public string strCommand;
        public string getstrCommand { get { return strCommand; } }

        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from PlayerInGame";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public PIG1()
        {
            DB_Open();
            InitializeComponent();
            rdo_player_id.CheckedChanged += rdo_CheckedChanged;
            rdo_match_id.CheckedChanged += rdo_CheckedChanged;
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;

            if (btn.Name.Equals("rdo_match_id"))
            {
                rdoselected = 1;
            }
            else if (btn.Name.Equals("rdo_player_id"))
            {
                rdoselected = 2;
            }
            else
            {
                rdoselected = 0;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int n;
            if (rdoselected != 0)
            {

                if ((rdoselected == 1 || rdoselected == 2) && string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    string msg = string.Empty;

                    msg = string.Format("값을 입력해주세요.", rdoselected);
                    MessageBox.Show(msg);
                    return;
                }
                else if ((rdoselected == 1 || rdoselected == 2) && !int.TryParse(txtSearch.Text, out n))
                {
                    string msg = string.Empty;

                    msg = string.Format("입력 가능한 값은 숫자입니다", rdoselected);
                    MessageBox.Show(msg);
                    return;
                }
                PIG2 frm2 = new PIG2();
                frm2.Owner = this;
                frm2.ShowDialog();
                frm2.Dispose();
            }
            else
            {
                string msg = string.Empty;

                msg = string.Format("옵션을 선택해주세요.", rdoselected);
                MessageBox.Show(msg);
            }
        }

        private void all_searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();
                DBAdapter.Fill(DS, "playeringame");
                DBGrid.DataSource = DS.Tables["playeringame"].DefaultView;  //****
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
        public String TxtS
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value.ToString(); }
        }

        public int rdoS
        {
            get { return rdoselected; }
        }
        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            strCommand = "추가";
            PIG3 form3 = new PIG3();
            form3.setParent(this);
            form3.ShowDialog();
            form3.Dispose();
            //showDataGridView();
        }

        private void injure_player_Click(object sender, EventArgs e)
        {
            PIG4 form4 = new PIG4();
            form4.ShowDialog();
            form4.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();
                DBAdapter.Fill(DS, "playeringame");
                DBGrid.DataSource = DS.Tables["playeringame"].DefaultView;  //****
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
    }
}
