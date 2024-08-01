using DBP_TeamP;
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
    public partial class PIG2 : Form
    {
        new PIG1 Parent;

        private int int_match_code;  //ID 필드 설정
        private int int_player_id;
        private string strCommand;
        //데이터 삭제, 추가, 업데이트 인지를 설정할 문자열 필드
        //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.
        private OracleConnection odpConn = new OracleConnection();
        private int SelectedRowIndex;

        // Data Provider인 DBAdapter 입니다.
        OracleDataAdapter DBAdapter;

        // DataSet 객체입니다.
        DataSet DS;

        // 추가, 수정, 삭제시에 필요한 명령문을 
        // 자동으로 작성해주는 객체입니다.
        OracleCommandBuilder myCommandBuilder;

        // ataTable 객체입니다.
        DataTable Player_In_Game;

        // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드
        private int SelectedKeyValue;
        public int get_int_match_code { get { return int_match_code; } }
        public int get_int_player_id { get { return int_player_id; } }
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
        public PIG2()
        {
            DB_Open();
            InitializeComponent();
        }

        private void ListAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parent = (PIG1)Owner;
            Player_In_Game = DS.Tables["playeringame"];

            if (Parent.rdoS == 1)
            {
                DataRow[] ResultRows = Player_In_Game.Select("MATCH_CODE = '" + Parent.TxtS + "'");
            }

            else if (Parent.rdoS == 2)
            {
                DataRow[] ResultRows = Player_In_Game.Select("PLAYER_ID = '" + Parent.TxtS + "'");
            }

            DataColumn[] PrimaryKey = new DataColumn[2];
            PrimaryKey[0] = Player_In_Game.Columns["MATCH_CODE"];
            PrimaryKey[1] = Player_In_Game.Columns["PLAYER_ID"];
            Player_In_Game.PrimaryKey = PrimaryKey;

            String[] keypart = ListAll.Text.Split(' ');
            object[] keys = { keypart[0], keypart[1] };

            DataRow currRow = Player_In_Game.Rows.Find(keys);

            SelectedKeyValue = Convert.ToInt32(currRow["PLAYER_ID"].ToString());    //수정, 삭제할 때 필요


            match_code.Text = currRow["MATCH_CODE"].ToString();
            player_id.Text = currRow["PLAYER_ID"].ToString();
            position.Text = currRow["POSITION"].ToString();
            goal_scored.Text = currRow["GOAL_SCORED"].ToString();
            assists.Text = currRow["ASSISTS"].ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DS.Clear();
            DBAdapter.Fill(DS, "playeringame");
            Parent = (PIG1)Owner;
            Player_In_Game = DS.Tables["playeringame"];

            if (Parent.rdoS == 1)
            {
                DataRow[] ResultRows = Player_In_Game.Select("MATCH_CODE = '" + Parent.TxtS + "'");

                ListAll.Items.Clear();

                foreach (DataRow currRow in ResultRows)
                {
                    ListAll.Items.Add(currRow["MATCH_CODE"].ToString() + " " + currRow["PLAYER_ID"].ToString());
                }
            }
            else if (Parent.rdoS == 2)
            {
                DataRow[] ResultRows = Player_In_Game.Select("PLAYER_ID = '" + Parent.TxtS + "'");

                ListAll.Items.Clear();

                foreach (DataRow currRow in ResultRows)
                {
                    ListAll.Items.Add(currRow["MATCH_CODE"].ToString() + " " + currRow["PLAYER_ID"].ToString());
                }
            }
        }

        private void showDataGridView()  //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = "User Id=team; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) ); ";
                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("SELECT * from playeringame", odpConn);

                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();
                ListAll.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }

        private void 선택한행업데이트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "업데이트";
            int_match_code = Convert.ToInt32(match_code.Text);
            int_player_id = Convert.ToInt32(player_id.Text);
            PIG3 form3 = new PIG3();
            form3.setParent(this);
            form3.ShowDialog();
            form3.Dispose();

            //showDataGridView();
        }

        private void 새로운데이터추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "추가";
            PIG3 form3 = new PIG3();
            form3.setParent(this);
            form3.ShowDialog();
            form3.Dispose();
            //showDataGridView();
        }

        private void 선택한행삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "삭제";
            int_match_code = Convert.ToInt32(match_code.Text);
            int_player_id = Convert.ToInt32(player_id.Text);
            PIG3 form3 = new PIG3();
            form3.setParent(this);
            form3.ShowDialog();
            form3.Dispose();
            //showDataGridView();
        }
    }
}