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
    public partial class Form5 : Form
    {
        PIG4 _parent;

        OracleDataAdapter DBAdapter;

        DataSet DS;

        OracleCommandBuilder myCommandBuilder;
        private OracleConnection odpConn = new OracleConnection();

        public Form5(PIG4 inform1)
        {
            InitializeComponent();
            _parent = inform1;
        }

        private void initialTextBoxes()//사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
            odpConn.Open();

            int get_player_id = _parent.get_int_player_id;

            string strqry = "SELECT * FROM injure WHERE player_id = " + get_player_id;

            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            OracleDataReader odr = OraCmd.ExecuteReader();

            while (odr.Read())
            {
                txtPlayer_id.Text = Convert.ToString(odr.GetValue(0));
                txtInjury_name.Text = Convert.ToString(odr.GetValue(1));
                txtInjury_date.Text = Convert.ToDateTime(odr.GetValue(2)).ToString("yyyy-MM-dd");
                txtInjury_duration.Text = Convert.ToDateTime(odr.GetValue(3)).ToString("yyyy-MM-dd");
            }
            odr.Close();
            odpConn.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (_parent.getstrCommand == "업데이트")
            {
                btn_ok.Text = "업데이트";
                txtPlayer_id.Enabled = false;
                initialTextBoxes();
            }
            else btn_ok.Text = "추가";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (btn_ok.Text == "추가")
            {
                if (INSERTRow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터 행이 추가됨.");
                }
                else MessageBox.Show("데이터 행이 추가되지 않음!");
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

        private int INSERTRow()//사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
            odpConn.Open();

            int inid = Convert.ToInt32(txtPlayer_id.Text.Trim());
            String injuryname = txtInjury_name.Text.Trim();   //**
            //String injurydate = txtInjury_date.Text.Trim();  //**
            DateTime injurydate = DateTime.ParseExact(txtInjury_date.Text.Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture);  //**
            DateTime injuryduration = DateTime.ParseExact(txtInjury_duration.Text.Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture);   //**


            string strqry = "INSERT INTO injure (player_id, injury_name, injury_date, injury_duration) VALUES (:inid, :injuryname, :injurydate, :injuryduration)";
            //"INSERT INTO phone VALUES (id, pname, phone, email)"을 수정

            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("inid", OracleDbType.Int32).Value = inid;
            OraCmd.Parameters.Add("injuryname", OracleDbType.Varchar2).Value = injuryname;
            OraCmd.Parameters.Add("injurydate", OracleDbType.Date).Value = injurydate;
            OraCmd.Parameters.Add("injuryduration", OracleDbType.Date).Value = injuryduration;
            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환

        }

        private int UPDATERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
            odpConn.Open();

            int get_player_id = _parent.get_int_player_id;

            String injuryname = txtInjury_name.Text.Trim();   //**
            DateTime injurydate = DateTime.ParseExact(txtInjury_date.Text.Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture);  //**
            DateTime injuryduration = DateTime.ParseExact(txtInjury_duration.Text.Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture);   //**

            string strqry = "UPDATE injure SET injury_name = :injuryname, injury_date = TO_CHAR(:injurydate, 'yyyy-MM-dd'), injury_duration = TO_CHAR(:injuryduration, 'yyyy-MM-dd') WHERE player_id = " + get_player_id;

            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("injuryname", OracleDbType.Varchar2).Value = injuryname;
            OraCmd.Parameters.Add("injurydate", OracleDbType.Date).Value = injurydate;
            OraCmd.Parameters.Add("injuryduration", OracleDbType.Date).Value = injuryduration;

            return OraCmd.ExecuteNonQuery(); //업데이트되는 행수 반환
        }
    }
}
