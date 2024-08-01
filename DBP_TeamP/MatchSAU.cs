using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamP
{
    public partial class MatchSAU : Form
    {
        private string strcomm;
        private int IntID;
        private OracleConnection odpConn = new OracleConnection();
        MatchMain _parent;
        public string getstrcomm
        {
            get { return strcomm; }
        }
        public int getIntID
        {
            get { return IntID; }
        }
        public void RefreshDataGridView()
        {
            showDataGridView(); // MatchAdd폼에서 업데이트시 현재 폼의 데이터 그리드 뷰를 업데이트하는 메서드 호출
        }

        public MatchSAU(MatchMain inform4)
        {
            InitializeComponent();
            _parent = inform4;
        }
        public MatchSAU()
        {
            InitializeComponent();
        }

        private void MatchSAU_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }
        private void showDataGridView()
        {
            try
            {
                odpConn.ConnectionString = "User Id=team; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)));";
                odpConn.Open();
                OracleDataAdapter odd = new OracleDataAdapter();
                odd.SelectCommand = new OracleCommand("SELECT M.match_code AS 경기코드, M.opponent_team_name AS 상대팀이름, M.manager_id AS 감독코드, M.goals_scored_in_the_match AS 경기득점, M.goals_conceded_in_the_match AS 경기실점, M.total_effective_shots AS 유효슈팅수," +
                    " M.total_number_of_yellow_cards AS 경고카드수, M.total_number_of_red_cards AS 퇴장카드수, M.weather_on_the_match_day AS 경기당일날씨, TO_CHAR(MS.match_date, 'YYYY-MM-DD') AS 경기날짜, MS.match_progress_status AS 경기진행여부 FROM Match M INNER JOIN MatchSchedule MS ON M.match_code = MS.match_code", odpConn);
                DataTable dt = new DataTable();
                odd.Fill(dt);
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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            strcomm = "경기 전체 기록 관리";
            IntID = Convert.ToInt32(DBGrid.SelectedCells[0].Value);
            MatchAdd MA2 = new MatchAdd(this);  // matchadd폼 생성
            MA2.ShowDialog();
            MA2.Dispose();
        }

        private void btnPlayerSearch_Click(object sender, EventArgs e)
        {
            PIG1 form1 = new PIG1();
            form1.ShowDialog();
            form1.Dispose();
        }
    }
}
