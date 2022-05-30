using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PraktikumWeek14
{
    public partial class FormTeam : Form
    {
        public FormTeam()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        DataTable dtTeam = new DataTable();
        DataTable dtTeamName = new DataTable();
        DataTable dtManager = new DataTable();
        DataTable dtStadium = new DataTable();
        DataTable dtWorstDicipline = new DataTable();
        DataTable dtTopScorer = new DataTable();
        DataTable dtDgv = new DataTable();

        int posisiNow = 0;


        private void FormTeam_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.team_name, concat(m.manager_name, ' (', n.nation, ')'),  concat(t.home_stadium, ', ', t.city, ' (', t.capacity, ')'), concat(p.player_name, ' ', max(j.Jumlah_Goal), '(', a.Goal_penalty, ')') from team t, manager m, nationality n, player p, player p2, dmatch d, (select p.player_id, p.player_name, count(d.`type`) as 'Jumlah_Goal' from dmatch d, player p where p.player_id = d.player_id and(d.`type` = 'GO' or 'GP') group by player_id) as j, (select p.player_id, p.player_name, count(d.`type`) as 'Goal_Penalty' from player p left join dmatch d on p.player_id = d.player_id and(d.`type` = 'GP') group by player_id) as a where n.nationality_id = m.nationality_id and m.manager_id = t.manager_id and p.player_id = d.player_id and j.player_name = p.player_name and(d.`type` = 'GO' or 'GP') and t.team_id = d.team_id and a.player_id = p.player_id group by t.team_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            isiDataTeam(0);


            sqlQuery = "select m.match_date as 'Tanggal Pertandingan',(select t.team_name from team t where t.team_id = m.team_home) as 'Team Home',(select t.team_name from team t where t.team_id = m.team_away) as 'Team Away', if(goal_home is null or goal_away is null, 'Belum Selesai',  concat(goal_home, '-', goal_away)) as 'Hasil Akhir' from `match` m where m.team_home = 'a001' or m.team_away = 'a001' order by m.`match_date`;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDgv);
            dgvTeam.DataSource = dtDgv;
        }

        public  void isiDataTeam(int Posisi)
        {
            ////MessageBox.Show(Posisi.ToString());
            lblTeamNameIsi.Text = dtTeam.Rows[Posisi][0].ToString();
            lblManagerIsi.Text = dtTeam.Rows[Posisi][1].ToString();
            lblStadiumIsi.Text = dtTeam.Rows[Posisi][2].ToString();
            lblTopScorerIsi.Text = dtTeam.Rows[Posisi][3].ToString();
           // lblWorstDiciplineIsi.Text = dtTeam.Rows[Posisi][4].ToString();
           posisiNow = Posisi;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            posisiNow = 0;
            isiDataTeam(posisiNow);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            posisiNow--;
            isiDataTeam(posisiNow);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            posisiNow++;
            isiDataTeam(posisiNow);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            posisiNow = dtTeam.Rows.Count - 1;
            isiDataTeam(posisiNow);
        }

        private void dgvTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            
        }
    }
}
