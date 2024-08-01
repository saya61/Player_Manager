using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamP
{
    public partial class PIG4 : Form
    {
        private int int_player_id;

        OracleDataAdapter DBAdapter;

        DataSet DS;

        OracleCommandBuilder myCommandBuilder;

        private int rdoselected = 0;

        public string strCommand;
        public string getstrCommand { get { return strCommand; } }

        public int get_int_player_id { get { return int_player_id; } }

        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from Injure";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public PIG4()
        {
            DB_Open();
            InitializeComponent();
            rdo_player_id.CheckedChanged += rdo_CheckedChanged;
            rdo_injure_name.CheckedChanged += rdo_CheckedChanged;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();
                DBAdapter.Fill(DS, "injure");
                DBGrid.DataSource = DS.Tables["injure"].DefaultView;  //****
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

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;

            if (btn.Name.Equals("rdo_player_id"))
            {
                rdoselected = 1;
            }
            else if (btn.Name.Equals("rdo_injure_name"))
            {
                rdoselected = 2;
            }
            else
            {
                rdoselected = 0;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            int n;
            if(rdoselected == 1)
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    string msg = string.Empty;

                    msg = string.Format("값을 입력해주세요.", rdoselected);
                    MessageBox.Show(msg);
                    return;
                }
                else if(!int.TryParse(txtSearch.Text, out n))
                {
                    string msg = string.Empty;

                    msg = string.Format("입력 가능한 값은 숫자입니다", rdoselected);
                    MessageBox.Show(msg);
                    return;
                }
                else
                {
                    string connectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
                    string commandString = "select * from Injure where player_id = " + Convert.ToInt32(txtSearch.Text);
                    DBAdapter = new OracleDataAdapter(commandString, connectionString);
                    myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                    DS = new DataSet();

                    DS.Clear();
                    DBAdapter.Fill(DS, "injure");
                    DBGrid.DataSource = DS.Tables["injure"].DefaultView;  //****
                }
            }
            if (rdoselected == 2)
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    string msg = string.Empty;

                    msg = string.Format("값을 입력해주세요.", rdoselected);
                    MessageBox.Show(msg);
                    return;
                }
                else
                {
                    string connectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
                    string commandString = "select * from Injure where injury_name like '%" + txtSearch.Text + "%'";
                    DBAdapter = new OracleDataAdapter(commandString, connectionString);
                    myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                    DS = new DataSet();

                    DS.Clear();
                    DBAdapter.Fill(DS, "injure");
                    DBGrid.DataSource = DS.Tables["injure"].DefaultView;  //****
                }
            }
            if(rdoselected == 0)
            {
                string msg = string.Empty;

                msg = string.Format("옵션을 선택해주세요.", rdoselected);
                MessageBox.Show(msg);
            }
        }

        private void all_search_btn_Click(object sender, EventArgs e)
        {
            DB_Open();

            DS.Clear();
            DBAdapter.Fill(DS, "injure");
            DBGrid.DataSource = DS.Tables["injure"].DefaultView;  //****
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            strCommand = "추가";
            Form5 form5 = new Form5(this);
            form5.ShowDialog();
            form5.Dispose();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            strCommand = "업데이트";
            Form5 form5 = new Form5(this);
            int_player_id = Convert.ToInt32(DBGrid.SelectedCells[0].Value);
            form5.ShowDialog();
            form5.Dispose();
        }

        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
