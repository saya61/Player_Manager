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
using System.Xml.Linq;

namespace DBP_TeamP
{
    public partial class LeagueMatchM : Form
    {
        private OracleConnection odpConn = new OracleConnection();
        MatchMain _parent;
        public LeagueMatchM(MatchMain inform3)
        {
            InitializeComponent();
            _parent = inform3;
        }

        public LeagueMatchM()
        {
            InitializeComponent();
        }

        private void showDataGridView2()
        {
            try
            {
                odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
                odpConn.Open();
                OracleDataAdapter odc = new OracleDataAdapter();
                // 명시적인 열 지정 및 WHERE 절 추가
                odc.SelectCommand = new OracleCommand("SELECT MS.match_code AS 경기코드, TO_CHAR(MS.match_date, 'YYYY-MM-DD') AS 경기날짜, MS.match_progress_status AS 경기진행여부 FROM MatchSchedule MS JOIN Match M ON MS.match_code = M.match_code", odpConn);

                DataTable dt = new DataTable();
                odc.Fill(dt);
                odpConn.Close();
                DBGrid.DataSource = dt;
                DBGrid.AutoResizeColumns();
                DBGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DBGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DBGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
                odpConn.Close();
            }
        }
        private void LeagueMatchM_Load(object sender, EventArgs e)
        {
            
        }
        private void MatchScheduleSearch_Click(object sender, EventArgs e)
        {
            showDataGridView2();
        }
    }
}
