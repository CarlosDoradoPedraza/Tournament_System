using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentSys
{
    public partial class ScoreTeams : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = TournamentSystem.accdb");
        private static Int32 IDTournamentID = 0;
        private static Int32 ID = 0;

        public ScoreTeams()
        {
            InitializeComponent();
        }

        private void ScoreTeams_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbDataAdapter sqlDA = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            OleDbCommand command = new OleDbCommand("SELECT * from  tblTournament ", conn);
            sqlDA.SelectCommand = command;
            sqlDA.Fill(ds);
            conn.Close();
            cmbTournament.DisplayMember = "TournamentName";
            cmbTournament.ValueMember = "IDTournament";
            cmbTournament.DataSource = ds.Tables[0];
            

            Dataload();
        }
        private void Dataload()
        {
            conn.Open();
            OleDbDataAdapter sqlDA = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            OleDbCommand command = new OleDbCommand("SELECT * from  tblTeamPlayersScore ", conn);
            sqlDA.SelectCommand = command;
            sqlDA.Fill(ds);
            conn.Close();
            gvTeamScoreList.DataSource = ds.Tables[0];
        }


        private void cmbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTournament.SelectedIndex >= 0)
                {
                    cmbTournament.Text = "";
                    cmbTeam.Enabled = true;
                    cmbScore.Enabled = true;
                    cmbEvent.Enabled = true;
                }
                else
                {
                    cmbTeam.Enabled = false;
                    cmbScore.Enabled = false;
                    cmbEvent.Enabled = false;
                }
                if (cmbTournament.Items.Count > 0)
                {
                    conn.Open();
                    OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                    DataSet dsE = new DataSet();
                    OleDbCommand command = new OleDbCommand("SELECT * from  tblTeams Where IDTournament = CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "')", conn);
                    sqlDA.SelectCommand = command;
                    sqlDA.Fill(dsE);
                    conn.Close();
                    if (dsE.Tables[0].Rows.Count > 0)
                    {
                        cmbTeam.ValueMember = "IDTeam";
                        cmbTeam.DisplayMember = "TeamName";
                        cmbTeam.DataSource = dsE.Tables[0];

                        cmbTeam_SelectedIndexChanged(null, null);
                    }
                    else
                    {
                        cmbTeam.DataSource = null;
                        cmbEvent.DataSource = null;
                    }


                }

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTournament.Items.Count > 0)
                {
                    conn.Open();
                    OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                    DataSet dsE = new DataSet();
                    OleDbCommand command = new OleDbCommand("SELECT * from  tblTournamentDetails Where IDTournament = CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "')", conn);
                    sqlDA.SelectCommand = command;
                    sqlDA.Fill(dsE);
                    conn.Close();
                    
                    if (dsE.Tables[0].Rows.Count > 0)
                    {
                        cmbEvent.ValueMember = "Event";
                        cmbEvent.DisplayMember = "Event";
                        cmbEvent.DataSource = dsE.Tables[0];

                    }
                }

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbTournament.Text == "" || cmbScore.Text == "")
            {
                MessageBox.Show("Please fill information", "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                try
            {
                if (!String.IsNullOrEmpty(cmbScore.Text))
                {
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into tblTeamPlayersScore (IDTournament, IDTeam, Event, Score) values (CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "'), CInt('" + Convert.ToInt32(cmbTeam.SelectedValue.ToString()) + "'),'" + cmbEvent.Text + "',CInt('" + cmbScore.Text + "'))";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Save in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dataload();
                    btnReset_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            cmbScore.Text = " ";
            labTotal.Text = "0";
            cmbTournament.SelectedIndex = 0;
        }

        private void gvTeamScoreList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void gvTeamScoreList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvTeamScoreList.Rows.Count > -1)
                {
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = true;

                    ID = Convert.ToInt32(gvTeamScoreList.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    IDTournamentID = Convert.ToInt32(gvTeamScoreList.Rows[e.RowIndex].Cells["IDTournament"].Value.ToString());
                    cmbTournament.SelectedValue = IDTournamentID;
                    cmbTeam.SelectedValue = Convert.ToInt32(gvTeamScoreList.Rows[e.RowIndex].Cells["IDTeam"].Value.ToString());
                    cmbEvent.Text = gvTeamScoreList.Rows[e.RowIndex].Cells["Event"].Value.ToString();
                    cmbScore.Text = gvTeamScoreList.Rows[e.RowIndex].Cells["Score"].Value.ToString();
                    cmbTournament.SelectedValue = gvTeamScoreList.Rows[e.RowIndex].Cells["IDTournament"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from tblTeamPlayersScore Where ID = CInt('" + ID + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Delete in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    Dataload();
                    btnReset_Click(null, null);
                }

                else
                {
                    MessageBox.Show("Plesae load the data", " Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, " Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            labTotal.Text = GetTeamScore().ToString();
        }
        private int GetTeamScore()
        {
            try
            {
                int IndivScoreTotal = 0;
                DataTable dtLastNo = new DataTable();
                conn.Open();
                OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                DataSet dsN = new DataSet();
           

                OleDbCommand command = new OleDbCommand("SELECT SUM( tblTeamPlayersScore.Score) AS SumOfScore , IDTournament, IDTeam FROM tblTeamPlayersScore GROUP BY IDTournament, IDTeam  HAVING (((IDTeam) = CInt('" + cmbTeam.SelectedValue.ToString() + "')) AND ((IDTournament)= CInt('" + cmbTournament.SelectedValue.ToString() + "')))", conn);
                sqlDA.SelectCommand = command;
                sqlDA.Fill(dsN);
                dtLastNo = dsN.Tables[0];
                conn.Close();
                if (dtLastNo != null && dtLastNo.Rows.Count > 0)
                {
                    if (dtLastNo.Rows[0][0].ToString() == "")
                    {
                        IndivScoreTotal = 0;
                    }
                    else
                    {
                        IndivScoreTotal = Convert.ToInt32(dtLastNo.Rows[0][0].ToString());
                    }

                }
                return IndivScoreTotal;
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }

        private void cmbTeam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbTournament_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
