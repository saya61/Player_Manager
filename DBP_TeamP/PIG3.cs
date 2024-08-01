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
    public partial class PIG3 : Form
    {
        PIG2 _2parent;
        PIG1 _1parent;

        OracleDataAdapter DBAdapter;

        DataSet DS;

        OracleCommandBuilder myCommandBuilder;
        private OracleConnection odpConn = new OracleConnection();

        public PIG3()
        {
            InitializeComponent();
            PIG2 _2parent = null;
            PIG1 _1parent = null;
        }
        public void setParent(PIG1 inform1)
        {
            _1parent = inform1;
        }
        public void setParent(PIG2 inform1)
        {
            _2parent = inform1;
        }

        private void initialTextBoxes()//사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
            odpConn.Open();

            int get_match_code = _2parent.get_int_match_code;   //**
            int get_player_id = _2parent.get_int_player_id;

            string strqry = "SELECT * FROM playeringame WHERE match_code = " + get_match_code + "AND player_id = " + get_player_id;
            //쿼리문 작성:id가 getID(폼1에서 선택한 id)인 튜플 검색
            // "SELECT * FROM phone WHERE  id= getID(변수)“를 수정

            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            OracleDataReader odr = OraCmd.ExecuteReader();

            while (odr.Read())
            {
                txtMatch_code.Text = Convert.ToString(odr.GetValue(0));
                txtPlayer_id.Text = Convert.ToString(odr.GetValue(1));
                txtPosition.Text = Convert.ToString(odr.GetValue(2));
                txtGoal_scored.Text = Convert.ToString(odr.GetValue(3));
                txtAssists.Text = Convert.ToString(odr.GetValue(4));
            }
            odr.Close();
            odpConn.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (_2parent == null && _1parent != null)
            {
                btnOK.Text = _1parent.getstrCommand;
            }
            else
            {
                if (_2parent.getstrCommand == "삭제")
                {
                    btnOK.Text = "삭제";
                    txtMatch_code.Enabled = false;
                    txtPlayer_id.Enabled = false;
                    initialTextBoxes();
                }
                else if (_2parent.getstrCommand == "업데이트")
                {
                    btnOK.Text = "업데이트";
                    txtMatch_code.Enabled = false;
                    txtPlayer_id.Enabled = false;
                    initialTextBoxes();
                }
                else btnOK.Text = "추가";
            }
        }

        private int INSERTRow()//사용자 함수 정의
        {
            OracleCommand OraCmd;
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
            odpConn.Open();

            int incode = Convert.ToInt32(txtMatch_code.Text.Trim()); //**
            int inid = Convert.ToInt32(txtPlayer_id.Text.Trim());
            String inPosition = txtPosition.Text.Trim();   //**
            String inGoal = txtGoal_scored.Text.Trim();  //**
            String inAssists = txtAssists.Text.Trim();   //**

            string strqry1 = "select injury_date, injury_duration from injure where player_id = " + inid;
            OraCmd = new OracleCommand(strqry1, odpConn);

            OracleDataReader dr = OraCmd.ExecuteReader();
            if (dr.Read()) MessageBox.Show("해당 선수는 부상 이력이 있으므로 반드시 확인 바랍니다.");

            string strqry = "INSERT INTO playeringame (MATCH_CODE, PLAYER_ID, POSITION, GOAL_SCORED, ASSISTS, TOTAL_SHOTS, EFFECTIVE_SHOTS, PLAYER_RATING, SUBSTITUTION_TIME, PLAYING_TIME, YELLOW_CARDS, RED_CARD) VALUES (" + incode + ", " + inid + ", '" + inPosition + "', '" + inGoal + "', '" + inAssists + "','','','','','','','')";

            OraCmd = new OracleCommand(strqry, odpConn);
            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환

        }

        private int DELETERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
            odpConn.Open();

            int get_match_code = _2parent.get_int_match_code;   //**
            int get_player_id = _2parent.get_int_player_id;

            string strqry = "DELETE FROM playeringame WHERE match_code = " + get_match_code + " and player_id = " + get_player_id;

            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            return OraCmd.ExecuteNonQuery();

        }

        private int UPDATERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
            odpConn.Open();

            int get_match_code = _2parent.get_int_match_code;   //**
            int get_player_id = _2parent.get_int_player_id;

            String inPosition = txtPosition.Text.Trim();   //**
            String inGoal = txtGoal_scored.Text.Trim();  //**
            String inAssists = txtAssists.Text.Trim();   //**

            string strqry = "UPDATE PlayerInGame SET position = '" + inPosition + "', goal_scored = '" + inGoal + "', assists = '" + inAssists + "' WHERE match_code = " + get_match_code + " and player_id = " + get_player_id;

            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            return OraCmd.ExecuteNonQuery(); //업데이트되는 행수 반환
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (btnOK.Text == "추가")
            {
                if (INSERTRow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터 행이 추가됨.");
                }
                else MessageBox.Show("데이터 행이 추가되지 않음!");
                this.Close();
            }
            else if (btnOK.Text == "삭제")
            {
                if (DELETERow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터 행이 삭제됨!");
                }
                else MessageBox.Show("데이터 행이 삭제되지 않음!");
                this.Close();
            }
            else
            {
                if (UPDATERow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터가 업데이트됨!");
                }
                else MessageBox.Show("데이터 행이 업데이트되지 않음!");
                this.Close();
            }
        }
    }
}
