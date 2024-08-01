using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DBP_TeamP
{
    public partial class MatchMain : Form
    {
        private string strTName;        // 팀 이름 필드 설정
        private string strCommand;
        private int IntMC;              //  MatchAdd Form을 위한 필드
        private OracleConnection odpConn = new OracleConnection();
        
        public string getstrTName
        {
            get { return strTName; }
        }
        public string getstrCommand
        {
            get { return strCommand; } 
        }
        public int getIntMC
        {
            get { return IntMC; }
        }
        private void showDataGridView()
        {
            try
            {
                odpConn.ConnectionString = "User Id=team; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)));";
                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("SELECT * from League_Team", odpConn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
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
        public MatchMain()
        {
            InitializeComponent();
        }

        private void MatchMain_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }

        private void list_search(string sortBy, string sortOrder, string searchColumn, string searchText)    //정렬을 위한 함수.
        {
            try
            {
                odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
                odpConn.Open();

                string query = $"SELECT * FROM League_Team ORDER BY {sortBy} {sortOrder}";
                OracleDataAdapter odb = new OracleDataAdapter();
                odb.SelectCommand = new OracleCommand(query, odpConn);
                DataTable dtt = new DataTable();
                odb.Fill(dtt);
                odpConn.Close();

                // 부분 일치 검색
                DataView dv = new DataView(dtt);
                if (teamName.Checked)   // 팀 이름 검색일시
                {
                    dv.RowFilter = $"{searchColumn} LIKE '%{searchText}%'";
                }               
                DataTable filteredDt = dv.ToTable();
                DBGrid.DataSource = filteredDt;
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
        private void teamSearch_Click(object sender, EventArgs e)
        {
            if (teamName.Checked)
            {
                list_search("team_name", "ASC", "team_name", txtTeam.Text);
                txtTeam.Text = "";      // 검색어 삭제.
            }
            else if (teamRank.Checked)
            {
                list_search("league_ranking", "ASC", "league_ranking", "");
                txtTeam.Text = "";
            }
            else
            {
                MessageBox.Show("정렬방식이 선택되지 않았습니다.");
                DBGrid.DataSource = null;
            }
                
            teamName.Checked = false;       // RatioButton 체크 해제.
            teamRank.Checked = false;  
        }

        private void teamAdd_Click(object sender, EventArgs e)
        {
            strCommand = "팀 추가";
            TeamM TM = new TeamM(this);
            TM.ShowDialog();
            TM.Dispose();
            showDataGridView();
        }

        private void teamRemove_Click(object sender, EventArgs e)
        {
            strCommand = "팀 제거";
            strTName = Convert.ToString(DBGrid.SelectedCells[0].Value);
            TeamM TM = new TeamM(this);
            TM.ShowDialog();
            TM.Dispose();
            showDataGridView();
        }

        private void TeamUpdate_Click(object sender, EventArgs e)
        {
            strCommand = "팀 업데이트";
            strTName = Convert.ToString(DBGrid.SelectedCells[0].Value);
            TeamM TM = new TeamM(this);
            TM.ShowDialog();
            TM.Dispose();
            showDataGridView();
        }

        private void matchAdd_Click(object sender, EventArgs e)
        {
            strCommand = "경기 기록 추가";
            MatchAdd MA = new MatchAdd(this);
            MA.ShowDialog();
            MA.Dispose();
        }

        private void leagueMatchM_Click(object sender, EventArgs e)
        {
            strCommand = "리그 경기 관리";
            LeagueMatchM LMM = new LeagueMatchM(this);
            LMM.ShowDialog();
            LMM.Dispose();
        }

        private void matchSearch_Click(object sender, EventArgs e)
        {
            strCommand = "경기 전체 기록 관리";
            MatchSAU sAU = new MatchSAU(this);
            sAU.ShowDialog();
            sAU.Dispose();
        }

        private void finBtn_Click(object sender, EventArgs e)
        {
            FinancialF FF = new FinancialF();
            FF.ShowDialog();
            FF.Dispose();
        }
    }
}
