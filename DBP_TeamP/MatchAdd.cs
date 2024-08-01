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
using System.Xml.Linq;

namespace DBP_TeamP
{
    public partial class MatchAdd : Form
    {
        private OracleConnection odpConn = new OracleConnection();
        MatchMain _parent;
        MatchSAU _parentSAU;    // 업데이트를 위한 부모

        public MatchAdd(MatchMain inform2)
        {
            InitializeComponent();
            _parent = inform2;
        }
        public MatchAdd(MatchSAU inform6)
        {
            InitializeComponent();
            _parentSAU = inform6;
        }
        private void MatchAdd_Load(object sender, EventArgs e)
        {
            if (_parent != null && _parent.getstrCommand == "경기 기록 추가")
            {
                btnOK.Text = "경기 기록 추가";
                initialTextBoxes();
            }
            else if (_parentSAU != null && _parentSAU.getstrcomm == "경기 전체 기록 관리")
            {
                btnOK.Text = "경기 기록 업데이트";
                txtID.Enabled = false;
                initialTextBoxes2();
            }
        }
        public class UpdateResult
        {
            public int MatchUpdateResult { get; set; }
            public int ScheduleUpdateResult { get; set; }
        }

        public MatchAdd()
        {
            InitializeComponent();
        }

        private void initialTextBoxes()
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
            odpConn.Open();

            string strqry = "select * from Match where match_code=:match_code";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("match_code", OracleDbType.Int32).Value = _parent.getIntMC;
            OracleDataReader odr = OraCmd.ExecuteReader();

            while (odr.Read())
            {
                txtID.Text = Convert.ToString(odr.GetValue(0));
                txtName.Text = Convert.ToString(odr.GetValue(1));
                txtDict.Text = Convert.ToString(odr.GetValue(2));
                txtScore.Text = Convert.ToString(odr.GetValue(3));
                txtConceded.Text = Convert.ToString(odr.GetValue(4));
                txtEffShot.Text = Convert.ToString(odr.GetValue(5));
                txtYC.Text = Convert.ToString(odr.GetValue(6));
                txtRC.Text = Convert.ToString(odr.GetValue(7));
                txtTW.Text = Convert.ToString(odr.GetValue(8));

                string scheduleQuery = "SELECT * FROM MatchSchedule WHERE match_code = :match_code";
                OracleCommand scheduleCmd = new OracleCommand(scheduleQuery, odpConn);
                scheduleCmd.Parameters.Add("match_code", OracleDbType.Int32).Value = _parent.getIntMC;
                OracleDataReader schReader = scheduleCmd.ExecuteReader();

                while (schReader.Read())
                {
                    txtID.Text = Convert.ToString(schReader.GetValue(0));
                    txtDate.Text = Convert.ToDateTime(schReader.GetValue(1)).ToString("yyyy-MM-dd");    // 형식을 yyyy-MM-dd 형태로 받음(아니면 이상해짐)
                    txtPrg.Text = Convert.ToString(schReader.GetValue(2));
                }
                schReader.Close();

            }
            odr.Close();
            odpConn.Close();
        }
        private void initialTextBoxes2()        // 다른 폼에서 받아오는거라 다른 메소드 선언
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
            odpConn.Open();

            string strqry = "select * from Match where match_code=:match_code";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("match_code", OracleDbType.Int32).Value = _parentSAU.getIntID;    //부모 MatchSAU로부터 받아옴.
            OracleDataReader odr = OraCmd.ExecuteReader();

            while (odr.Read())
            {
                txtID.Text = Convert.ToString(odr.GetValue(0));
                txtName.Text = Convert.ToString(odr.GetValue(1));
                txtDict.Text = Convert.ToString(odr.GetValue(2));
                txtScore.Text = Convert.ToString(odr.GetValue(3));
                txtConceded.Text = Convert.ToString(odr.GetValue(4));
                txtEffShot.Text = Convert.ToString(odr.GetValue(5));
                txtYC.Text = Convert.ToString(odr.GetValue(6));
                txtRC.Text = Convert.ToString(odr.GetValue(7));
                txtTW.Text = Convert.ToString(odr.GetValue(8));

                string scheduleQuery = "SELECT * FROM MatchSchedule WHERE match_code =:match_code";
                OracleCommand scheduleCmd = new OracleCommand(scheduleQuery, odpConn);
                scheduleCmd.Parameters.Add("match_code", OracleDbType.Int32).Value = _parentSAU.getIntID;
                OracleDataReader schReader = scheduleCmd.ExecuteReader();

                while (schReader.Read())
                {
                    txtID.Text = Convert.ToString(schReader.GetValue(0));
                    txtDate.Text = Convert.ToDateTime(schReader.GetValue(1)).ToString("yyyy-MM-dd");  
                    txtPrg.Text = Convert.ToString(schReader.GetValue(2));
                }
                schReader.Close();
            }
            odr.Close();
            odpConn.Close();
        }

        private UpdateResult INSERTRow()
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
            odpConn.Open();

            string strqry = "INSERT INTO Match VALUES (:match_code, :opponent_team_name, :manager_id, :goals_scored_in_the_match, :goals_conceded_in_the_match, :total_effective_shots, :total_number_of_yellow_cards, :total_number_of_red_cards, :weather_on_the_match_day)";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            //string scheduleQuery = "INSERT INTO MatchSchedule VALUES (:match_code, TO_DATE(:match_date, 'yyyy-MM-dd'), :match_progress_status)";
            string scheduleQuery = "INSERT INTO MatchSchedule VALUES (:match_code, :match_date, :match_progress_status)";
            OracleCommand scheduleCmd = new OracleCommand(scheduleQuery, odpConn);

            OraCmd.Parameters.Add("match_code", OracleDbType.Int32).Value = txtID.Text.Trim();
            OraCmd.Parameters.Add("opponent_team_name", OracleDbType.Varchar2, 20).Value = txtName.Text.Trim();
            OraCmd.Parameters.Add("manager_id", OracleDbType.Int32).Value = txtDict.Text.Trim();
            OraCmd.Parameters.Add("goals_scored_in_the_match", OracleDbType.Int32).Value = txtScore.Text.Trim();
            OraCmd.Parameters.Add("goals_conceded_in_the_match", OracleDbType.Int32).Value = txtConceded.Text.Trim();
            OraCmd.Parameters.Add("total_effective_shots", OracleDbType.Int32).Value = txtEffShot.Text.Trim();
            OraCmd.Parameters.Add("total_number_of_yellow_cards", OracleDbType.Int32).Value = txtYC.Text.Trim();
            OraCmd.Parameters.Add("total_number_of_red_cards", OracleDbType.Int32).Value = txtRC.Text.Trim();
            OraCmd.Parameters.Add("weather_on_the_match_day", OracleDbType.Varchar2, 10).Value = txtTW.Text.Trim();

            scheduleCmd.Parameters.Add("match_code", OracleDbType.Int32).Value = txtID.Text.Trim();
            DateTime matchDate = DateTime.ParseExact(txtDate.Text.Trim(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            scheduleCmd.Parameters.Add("match_date", OracleDbType.Date).Value = matchDate;
            scheduleCmd.Parameters.Add("match_progress_status", OracleDbType.Int32).Value = txtPrg.Text.Trim();

            return new UpdateResult
            {
                MatchUpdateResult = OraCmd.ExecuteNonQuery(),
                ScheduleUpdateResult = scheduleCmd.ExecuteNonQuery()
            };
        }
        private UpdateResult UPDATERow()
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
            odpConn.Open();

            string strqry = "UPDATE Match SET opponent_team_name=:opponent_team_name, manager_id=:manager_id, goals_scored_in_the_match=:goals_scored_in_the_match, goals_conceded_in_the_match=:goals_conceded_in_the_match, total_effective_shots=:total_effective_shots, total_number_of_yellow_cards=:total_number_of_yellow_cards, total_number_of_red_cards=:total_number_of_red_cards, weather_on_the_match_day=:weather_on_the_match_day WHERE match_code=:match_code";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            string scheduleQuery = "UPDATE MatchSchedule SET match_date=TO_CHAR(:match_date, 'YYYY-MM-DD'), match_progress_status=:match_progress_status WHERE match_code=:match_code";
            OracleCommand scheduleCmd = new OracleCommand(scheduleQuery, odpConn);

            
            OraCmd.Parameters.Add("opponent_team_name", OracleDbType.Varchar2, 20).Value = txtName.Text.Trim();
            OraCmd.Parameters.Add("manager_id", OracleDbType.Int32).Value = txtDict.Text.Trim();
            OraCmd.Parameters.Add("goals_scored_in_the_match", OracleDbType.Int32).Value = txtScore.Text.Trim();
            OraCmd.Parameters.Add("goals_conceded_in_the_match", OracleDbType.Int32).Value = txtConceded.Text.Trim();
            OraCmd.Parameters.Add("total_effective_shots", OracleDbType.Int32).Value = txtEffShot.Text.Trim();
            OraCmd.Parameters.Add("total_number_of_yellow_cards", OracleDbType.Int32).Value = txtYC.Text.Trim();
            OraCmd.Parameters.Add("total_number_of_red_cards", OracleDbType.Int32).Value = txtRC.Text.Trim();
            OraCmd.Parameters.Add("weather_on_the_match_day", OracleDbType.Varchar2, 10).Value = txtTW.Text.Trim();
            OraCmd.Parameters.Add("match_code", OracleDbType.Int32).Value = txtID.Text.Trim();

            DateTime matchDate = DateTime.ParseExact(txtDate.Text.Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            scheduleCmd.Parameters.Add("match_date", OracleDbType.Date).Value = matchDate;
            scheduleCmd.Parameters.Add("match_progress_status", OracleDbType.Int32).Value = txtPrg.Text.Trim();
            scheduleCmd.Parameters.Add("match_code", OracleDbType.Int32).Value = txtID.Text.Trim();

            return new UpdateResult
            {
                MatchUpdateResult = OraCmd.ExecuteNonQuery(),
                ScheduleUpdateResult = scheduleCmd.ExecuteNonQuery()
            };
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (btnOK.Text == "경기 기록 추가")
            {
                UpdateResult result = INSERTRow();
                if (result.MatchUpdateResult > 0 && result.ScheduleUpdateResult > 0)
                {
                    MessageBox.Show("정상적으로 경기결과가 추가됨.");
                }
                else
                {
                    MessageBox.Show("경기결과가 추가되지 않음!");
                }
                this.Close();
            }
            else if (btnOK.Text == "경기 기록 업데이트")
            {
                UpdateResult result1 = UPDATERow();
                if (result1.MatchUpdateResult > 0 && result1.ScheduleUpdateResult > 0)
                {
                    MessageBox.Show("정상적으로 경기결과가 업데이트됨.");
                    if (_parentSAU != null)     // MatchAdd가 matchsau에 의해 열렸는가?
                    {
                        _parentSAU.RefreshDataGridView();
                    }

                }
                else
                {
                    MessageBox.Show("경기결과가 업데이트되지 않음!");
                }
                this.Close();
            }
        }
    }
}