using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;

namespace DBP_TeamP
{
    public partial class TeamM : Form
    {
        private OracleConnection odpConn = new OracleConnection();
        MatchMain _parent;

        public TeamM(MatchMain inform1)
        {
            InitializeComponent();
            _parent = inform1;
        }
        public TeamM()
        {
            InitializeComponent();
        }

        private void TeamM_Load(object sender, EventArgs e)
        {
            if (_parent.getstrCommand == "팀 제거")
            {
                btnOK.Text = "팀 제거";
                txtName.Enabled = false;
                initialTextBoxes();
            }
            else if (_parent.getstrCommand == "팀 업데이트")
            {
                btnOK.Text = "팀 업데이트";
                txtName.Enabled = false;
                initialTextBoxes();
            }
            else btnOK.Text = "팀 추가";
        }

        private void initialTextBoxes()//사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id = team; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            odpConn.Open();
            string strqry = "select * from League_Team where team_name=:team_name";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("team_name", OracleDbType.Varchar2, 20).Value = _parent.getstrTName;
            OracleDataReader odr = OraCmd.ExecuteReader();

            while (odr.Read())
            {
                txtName.Text = Convert.ToString(odr.GetValue(0));
                txtRank.Text = Convert.ToString(odr.GetValue(1));
                txtPoint.Text = Convert.ToString(odr.GetValue(2));
                txtScore.Text = Convert.ToString(odr.GetValue(3));
                txtConceded.Text = Convert.ToString(odr.GetValue(4));
            }
            odr.Close();
            odpConn.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (btnOK.Text == "팀 추가")
            {
                if (INSERTRow() > 0)
                {
                    MessageBox.Show("정상적으로 팀이 추가됨.");
                }
                else MessageBox.Show("팀이 추가되지 않음!");
                this.Close();
            }
            else if (btnOK.Text == "팀 제거")
            {
                if (DELETERow() > 0)
                {
                    MessageBox.Show("정상적으로 팀이 삭제됨!");
                }
                else MessageBox.Show("팀이 삭제되지 않음!");
                this.Close();
            }
            else
            {
                if (UPDATERow() > 0)
                {
                    MessageBox.Show("정상적으로 팀이 업데이트됨!");
                }
                else MessageBox.Show("팀이 업데이트되지 않음!");
                this.Close();
            }
        }

        private int INSERTRow()//사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id = team; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            odpConn.Open();
            string strqry = "INSERT INTO League_team VALUES (:team_name, :league_ranking, :points_won, :total_goals_scored, :total_goals_conceded)";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("team_name", OracleDbType.Varchar2, 20).Value = txtName.Text.Trim();
            OraCmd.Parameters.Add("league_ranking", OracleDbType.Int32).Value = txtRank.Text.Trim();
            OraCmd.Parameters.Add("points_won", OracleDbType.Int32).Value = txtPoint.Text.Trim();
            OraCmd.Parameters.Add("total_goals_scored", OracleDbType.Int32).Value = txtScore.Text.Trim();
            OraCmd.Parameters.Add("total_goals_conceded", OracleDbType.Int32).Value = txtConceded.Text.Trim();
            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환
        }

        private int DELETERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id = team; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            odpConn.Open();
            string strqry = "DELETE FROM League_team WHERE team_name=:team_name";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("team_name", OracleDbType.Varchar2, 20).Value = _parent.getstrTName;
            return OraCmd.ExecuteNonQuery();
        }

        private int UPDATERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id = team; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            odpConn.Open();
            string strqry = "UPDATE league_team SET league_ranking=:league_ranking, points_won=:points_won, total_goals_scored=:total_goals_scored, total_goals_conceded=:total_goals_conceded WHERE team_name=:team_name";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("league_ranking", OracleDbType.Int32).Value = txtRank.Text.Trim();
            OraCmd.Parameters.Add("points_won", OracleDbType.Int32).Value = txtPoint.Text.Trim();
            OraCmd.Parameters.Add("total_goals_scored", OracleDbType.Int32).Value = txtScore.Text.Trim();
            OraCmd.Parameters.Add("total_goals_conceded", OracleDbType.Int32).Value = txtConceded.Text.Trim();
            OraCmd.Parameters.Add("team_name", OracleDbType.Varchar2, 20).Value = _parent.getstrTName;
            return OraCmd.ExecuteNonQuery(); //업데이트되는 행수 반환
        }
    }
}
