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
    public partial class ScoreIndiv : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = TournamentSystem.accdb");
        public ScoreIndiv()
        {
            InitializeComponent();
        }
        private static Int32 IDTournamentID = 0;
        private static Int32 ID = 0;


        private void ScoreIndiv_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbDataAdapter sqlDA = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            OleDbCommand command = new OleDbCommand("SELECT * from  tblTournament ", conn);
            sqlDA.SelectCommand = command;
            sqlDA.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbTournament.ValueMember = "IDTournament";
                cmbTournament.DisplayMember = "TournamentName";
                cmbTournament.DataSource = ds.Tables[0];
                Dataload();
            }

            cmbTournament_SelectedIndexChanged(null, null);
            btnReset_Click(null, null);
        }
        private void Dataload()
        {
            conn.Open();
            OleDbDataAdapter sqlDA = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            OleDbCommand command = new OleDbCommand("SELECT * from  tblIndividualScore ", conn);
            sqlDA.SelectCommand = command;
            sqlDA.Fill(ds);
            conn.Close();
            gvIndivScoreList.DataSource = ds.Tables[0];
        }

        private void cmbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmbTournament.SelectedIndex >= 0)
                {
                    cmbTournament.Text = "";
                    cmbTournament.Enabled = true;
                    cmbPlayer.Enabled = true;
                    cmbScore.Enabled = true;
                    cmbEvent.Enabled = true;
                    cmbScore.Enabled = true;
                }
                else
                {
                    cmbTournament.Enabled = false;
                    cmbTournament.Enabled = false;
                    cmbPlayer.Enabled = false;
                    cmbScore.Enabled = false;
                    cmbEvent.Enabled = false;
                }
                if (cmbTournament.Items.Count > 0)
                {
                    conn.Open();
                    OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                    DataSet dsE = new DataSet();
                    OleDbCommand command = new OleDbCommand("SELECT * from  tblIndividuals Where IDTournament = CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "')", conn);
                    sqlDA.SelectCommand = command;
                    sqlDA.Fill(dsE);
                    conn.Close();
                    if (dsE.Tables[0].Rows.Count > 0)
                    {
                        cmbPlayer.ValueMember = "FirstName";
                        cmbPlayer.DisplayMember = "FirstName";
                        cmbPlayer.DataSource = dsE.Tables[0];

                        cmbPlayer_SelectedIndexChanged(null, null);
                    }
                    else
                    {
                        cmbPlayer.DataSource = null;
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

        private void cmbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTournament.Items.Count > 0)
                {
                    conn.Open();
                    OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                    DataSet dsE = new DataSet();
                    OleDbCommand command = new OleDbCommand("SELECT * from  tblIndividuals Where IDTournament = CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "') And FirstName = '" + cmbPlayer.Text + "'", conn);
                    sqlDA.SelectCommand = command;
                    sqlDA.Fill(dsE);
                    conn.Close();
                    if (dsE.Tables[0].Rows.Count > 0)
                    {
                        if(dsE.Tables[0].Rows[0][5].ToString()=="ALL")
                        {
                            conn.Open();
                            OleDbDataAdapter sqlDA1 = new OleDbDataAdapter();
                            DataSet dsE1 = new DataSet();
                            OleDbCommand command1 = new OleDbCommand("SELECT * from  tblTournamentDetails  Where IDTournament = CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "')", conn);
                            sqlDA.SelectCommand = command1;
                            sqlDA.Fill(dsE1);
                            conn.Close();
                            cmbEvent.DataSource = dsE1.Tables[0];
                            cmbEvent.ValueMember = "Event";
                            cmbEvent.DisplayMember = "Event";
                        }
                       else
                        {
                            cmbEvent.DataSource = dsE.Tables[0];
                            cmbEvent.ValueMember = "Event";
                            cmbEvent.DisplayMember = "Event";
                        }
                       

                    }


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
            cmbScore.Text = "";
            labTotal.Text = "0";
            IDTournamentID = 0;
            ID = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                  if (cmbTournament.Text == ""|| cmbScore.Text == "")
            {
                    MessageBox.Show("Please fill information", "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            else
                if (!String.IsNullOrEmpty(cmbScore.Text))
                {
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into tblIndividualScore (IDTournament, Name, Event, Score) values (CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "'), '" + cmbPlayer.Text + "','" + cmbEvent.Text + "',CInt('" + cmbScore.Text + "'))";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Save in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dataload();
                    btnReset_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Please enter the score ...", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvIndivScoreList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void gvIndivScoreList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvIndivScoreList.Rows.Count > -1)
                {
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = true;
                    ID = Convert.ToInt32(gvIndivScoreList.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    IDTournamentID = Convert.ToInt32(gvIndivScoreList.Rows[e.RowIndex].Cells["IDTournament"].Value.ToString());
                    cmbPlayer.Text = gvIndivScoreList.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    cmbEvent.Text = gvIndivScoreList.Rows[e.RowIndex].Cells["Event"].Value.ToString();
                    cmbScore.Text = gvIndivScoreList.Rows[e.RowIndex].Cells["Score"].Value.ToString();
                    cmbTournament.SelectedValue = gvIndivScoreList.Rows[e.RowIndex].Cells["IDTournament"].Value.ToString();

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
                    cmd.CommandText = "Delete from tblIndividualScore Where ID = CInt('" + ID + "')";
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

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                labTotal.Text= GetIndividualScore().ToString();
            }
            catch (Exception ex)
            {

                conn.Close();
                MessageBox.Show(ex.Message, " Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int GetIndividualScore()
        {
            try
            {
                int IndivScoreTotal = 0;
                DataTable dtLastNo = new DataTable();
                conn.Open();
                OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                DataSet dsN = new DataSet();
                OleDbCommand command = new OleDbCommand("SELECT Sum(tblIndividualScore.Score) AS SumOfScore, tblIndividualScore.Name, tblIndividualScore.IDTournament FROM tblIndividualScore GROUP BY tblIndividualScore.Name, tblIndividualScore.IDTournament HAVING (((tblIndividualScore.Name)='" + cmbPlayer.Text + "') AND ((tblIndividualScore.IDTournament)= CInt('" + cmbTournament.SelectedValue.ToString() + "')))", conn);
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

        private void cmbTournament_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
