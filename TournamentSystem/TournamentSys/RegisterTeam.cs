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
    public partial class RegisterTeam : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = TournamentSystem.accdb");
        public RegisterTeam()
        {
            InitializeComponent();
        }
        private DataTable dtLastNo;
        private static int TournamentNo = 0;
        private static int TeamNo = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbTournament.Text == "" || txtTeamName.Text == "" || txtPl1Name.Text == "" || txtPl2Name.Text == "" || txtPl3Name.Text == "" || txtPl4Name.Text == "" || txtPl5Name.Text == "" ||
             txtPl1Surname.Text == "" || txtPl2Surname.Text == "" || txtPl3Surname.Text == "" || txtPl4Surname.Text == "" || txtPl5Surname.Text == "" ||
             txtPl1Email.Text == "" || txtPl2Email.Text == "" || txtPl3Email.Text == "" || txtPl4Email.Text == "" || txtPl5Email.Text == "" ||
             txtPl1Phone.Text == "" || txtPl2Phone.Text == "" || txtPl3Phone.Text == "" || txtPl4Phone.Text == "" || txtPl5Phone.Text == "")
            {
                MessageBox.Show("Please fill information", "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                try
            {
                int TeamNoNew = GetLastTeamID();

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tblTeams (IDTeam,IDTournament,TeamName) values (CInt('" + TeamNoNew + "'), CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "'),'" + txtTeamName.Text + "')";
                cmd.ExecuteNonQuery();
                if (!string.IsNullOrEmpty(txtPl1Name.Text))
                {
                    cmd.CommandText = "insert into tblTeamPlayers(IDTeam,Name,Surname,Email,Phone,PlayerNo) values (CInt('" + TeamNoNew + "'),'" + txtPl1Name.Text + "','" + txtPl1Surname.Text + "','" + txtPl1Email.Text + "','" + txtPl1Phone.Text + "',1)";
                    cmd.ExecuteNonQuery();
                }
                if (!string.IsNullOrEmpty(txtPl2Name.Text))
                {
                    cmd.CommandText = "insert into tblTeamPlayers(IDTeam,Name,Surname,Email,Phone,PlayerNo)values(CInt('" + TeamNoNew + "'),'" + txtPl2Name.Text + "','" + txtPl2Surname.Text + "','" + txtPl2Email.Text + "','" + txtPl2Phone.Text + "',2)";
                    cmd.ExecuteNonQuery();
                }
                if (!string.IsNullOrEmpty(txtPl3Name.Text))
                {
                    cmd.CommandText = "insert into tblTeamPlayers(IDTeam,Name,Surname,Email,Phone,PlayerNo)values(CInt('" + TeamNoNew + "'),'" + txtPl3Name.Text + "','" + txtPl3Surname.Text + "','" + txtPl3Email.Text + "','" + txtPl3Phone.Text + "',3)";
                    cmd.ExecuteNonQuery();
                }
                if (!string.IsNullOrEmpty(txtPl4Name.Text))
                {
                    cmd.CommandText = "insert into tblTeamPlayers(IDTeam,Name,Surname,Email,Phone,PlayerNo)values(CInt('" + TeamNoNew + "'),'" + txtPl4Name.Text + "','" + txtPl4Surname.Text + "','" + txtPl4Email.Text + "','" + txtPl4Phone.Text + "',4)";
                    cmd.ExecuteNonQuery();
                }
                if (!string.IsNullOrEmpty(txtPl5Name.Text))
                {
                    cmd.CommandText = "insert into tblTeamPlayers(IDTeam,Name,Surname,Email,Phone,PlayerNo)values(CInt('" + TeamNoNew + "'),'" + txtPl5Name.Text + "','" + txtPl5Surname.Text + "','" + txtPl5Email.Text + "','" + txtPl5Phone.Text + "',5)";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Record Save in Databaseeee", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                Dataload();
                btnReset_Click(null, null);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTeamName.Text = "";
            txtPl1Name.Text = "";
            txtPl1Surname.Text = "";
            txtPl1Email.Text = "";
            txtPl1Phone.Text = "";

            txtPl2Name.Text = "";
            txtPl2Surname.Text = "";
            txtPl2Email.Text = "";
            txtPl2Phone.Text = "";

            txtPl3Name.Text = "";
            txtPl3Surname.Text = "";
            txtPl3Email.Text = "";
            txtPl3Phone.Text = "";

            txtPl4Name.Text = "";
            txtPl4Surname.Text = "";
            txtPl4Email.Text = "";
            txtPl4Phone.Text = "";

            txtPl5Name.Text = "";
            txtPl5Surname.Text = "";
            txtPl5Email.Text = "";
            txtPl5Phone.Text = "";

            TournamentNo = 0;
            TeamNo = 0;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            cmbTournament.SelectedIndex = 0;
            Dataload();
        }
        private int GetLastTeamID()
        {
            try
            {
                int TeamNo = 0;
                conn.Open();
                OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                DataSet dsN = new DataSet();
                OleDbCommand command = new OleDbCommand("SELECT Max(tblTeams.IDTeam) AS [No] FROM tblTeams;", conn);
                sqlDA.SelectCommand = command;
                sqlDA.Fill(dsN);
                dtLastNo = dsN.Tables[0];
                conn.Close();
                if (dtLastNo != null && dtLastNo.Rows.Count > 0)
                {
                    if (dtLastNo.Rows[0][0].ToString() == "")
                    {
                        TeamNo = 1;
                    }
                    else
                    {
                        TeamNo = Convert.ToInt32(dtLastNo.Rows[0][0].ToString()) + 1;
                    }

                }
                return TeamNo;
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }
        private void RegisterTeam_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbDataAdapter sqlDA = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            OleDbCommand command = new OleDbCommand("SELECT * from  tblTournament ", conn);
            sqlDA.SelectCommand = command;
            sqlDA.Fill(ds);
            conn.Close();
            cmbTournament.DataSource = ds.Tables[0];
            cmbTournament.DisplayMember = "TournamentName";
            cmbTournament.ValueMember = "IDTournament";
            Dataload();
        }

        private void Dataload()
        {
            try
            {
                conn.Open();
                OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                DataSet dsD = new DataSet();
                OleDbCommand commandD = new OleDbCommand("Select * from tblTeams", conn);
                sqlDA.SelectCommand = commandD;
                sqlDA.Fill(dsD);
                conn.Close();
                gvTeamList.DataSource = dsD.Tables[0];
            }
            catch (Exception)
            {

                //throw;
            }


        }

        private void gvTeamList_MouseClick(object sender, MouseEventArgs e)
        {
            gvTeamList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void gvTeamList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvTeamList.Rows.Count > -1)
                {
                    btnReset_Click(null, null);
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;

                    cmbTournament.SelectedValue = gvTeamList.Rows[e.RowIndex].Cells["IDTournament"].Value.ToString();
                    txtTeamName.Text = gvTeamList.Rows[e.RowIndex].Cells["TeamName"].Value.ToString();

                    int IDTeam = Convert.ToInt32(gvTeamList.Rows[e.RowIndex].Cells["IDTeam"].Value.ToString());
                    TournamentNo = Convert.ToInt32(gvTeamList.Rows[e.RowIndex].Cells["IDTournament"].Value.ToString());
                    TeamNo = IDTeam;

                    conn.Open();
                    OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                    DataSet dsD = new DataSet();
                    OleDbCommand commandD = new OleDbCommand("Select * from tblTeamPlayers Where IDTeam = CInt('" + IDTeam + "')", conn);
                    sqlDA.SelectCommand = commandD;
                    sqlDA.Fill(dsD);
                    conn.Close();

                    for (int i = 0; i < dsD.Tables[0].Rows.Count; i++)
                    {
                        if (dsD.Tables[0].Rows[i]["PlayerNo"].ToString() == "1")
                        {
                            txtPl1Name.Text = dsD.Tables[0].Rows[i]["Name"].ToString();
                            txtPl1Surname.Text = dsD.Tables[0].Rows[i]["Surname"].ToString();
                            txtPl1Email.Text = dsD.Tables[0].Rows[i]["Email"].ToString();
                            txtPl1Phone.Text = dsD.Tables[0].Rows[i]["Phone"].ToString();
                        }
                        if (dsD.Tables[0].Rows[i]["PlayerNo"].ToString() == "2")
                        {
                            txtPl2Name.Text = dsD.Tables[0].Rows[i]["Name"].ToString();
                            txtPl2Surname.Text = dsD.Tables[0].Rows[i]["Surname"].ToString();
                            txtPl2Email.Text = dsD.Tables[0].Rows[i]["Email"].ToString();
                            txtPl2Phone.Text = dsD.Tables[0].Rows[i]["Phone"].ToString();
                        }
                        if (dsD.Tables[0].Rows[i]["PlayerNo"].ToString() == "3")
                        {
                            txtPl3Name.Text = dsD.Tables[0].Rows[i]["Name"].ToString();
                            txtPl3Surname.Text = dsD.Tables[0].Rows[i]["Surname"].ToString();
                            txtPl3Email.Text = dsD.Tables[0].Rows[i]["Email"].ToString();
                            txtPl3Phone.Text = dsD.Tables[0].Rows[i]["Phone"].ToString();
                        }
                        if (dsD.Tables[0].Rows[i]["PlayerNo"].ToString() == "4")
                        {
                            txtPl4Name.Text = dsD.Tables[0].Rows[i]["Name"].ToString();
                            txtPl4Surname.Text = dsD.Tables[0].Rows[i]["Surname"].ToString();
                            txtPl4Email.Text = dsD.Tables[0].Rows[i]["Email"].ToString();
                            txtPl4Phone.Text = dsD.Tables[0].Rows[i]["Phone"].ToString();
                        }
                        if (dsD.Tables[0].Rows[i]["PlayerNo"].ToString() == "5")
                        {
                            txtPl5Name.Text = dsD.Tables[0].Rows[i]["Name"].ToString();
                            txtPl5Surname.Text = dsD.Tables[0].Rows[i]["Surname"].ToString();
                            txtPl5Email.Text = dsD.Tables[0].Rows[i]["Email"].ToString();
                            txtPl5Phone.Text = dsD.Tables[0].Rows[i]["Phone"].ToString();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbTournament.Text == "" || txtTeamName.Text == "" || txtPl1Name.Text == "" || txtPl2Name.Text == "" || txtPl3Name.Text == "" || txtPl4Name.Text == "" || txtPl5Name.Text == "" ||
             txtPl1Surname.Text == "" || txtPl2Surname.Text == "" || txtPl3Surname.Text == "" || txtPl4Surname.Text == "" || txtPl5Surname.Text == "" ||
             txtPl1Email.Text == "" || txtPl2Email.Text == "" || txtPl3Email.Text == "" || txtPl4Email.Text == "" || txtPl5Email.Text == "" ||
             txtPl1Phone.Text == "" || txtPl2Phone.Text == "" || txtPl3Phone.Text == "" || txtPl4Phone.Text == "" || txtPl5Phone.Text == "")
            {
                MessageBox.Show("Please fill information", "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                try
            {

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update tblTeams  set IDTournament = CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "'), TeamName = '" + txtTeamName.Text + "' Where IDTeam = CInt('" + TeamNo + "')";
                cmd.ExecuteNonQuery();
                if (!string.IsNullOrEmpty(txtPl1Name.Text))
                {
                    cmd.CommandText = "Delete from tblTeamPlayers Where IDTeam = CInt('" + TeamNo + "') AND PlayerNo = 1 ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into tblTeamPlayers(IDTeam,Name,Surname,Email,Phone,PlayerNo) values (CInt('" + TeamNo + "'),'" + txtPl1Name.Text + "','" + txtPl1Surname.Text + "','" + txtPl1Email.Text + "','" + txtPl1Phone.Text + "',1)";
                    cmd.ExecuteNonQuery();
                }
                if (!string.IsNullOrEmpty(txtPl2Name.Text))
                {
                    cmd.CommandText = "Delete from tblTeamPlayers Where IDTeam = CInt('" + TeamNo + "') AND PlayerNo = 2 ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into tblTeamPlayers(IDTeam,Name,Surname,Email,Phone,PlayerNo)values(CInt('" + TeamNo + "'),'" + txtPl2Name.Text + "','" + txtPl2Surname.Text + "','" + txtPl2Email.Text + "','" + txtPl2Phone.Text + "',2)";
                    cmd.ExecuteNonQuery();
                }
                if (!string.IsNullOrEmpty(txtPl3Name.Text))
                {
                    cmd.CommandText = "Delete from tblTeamPlayers Where IDTeam = CInt('" + TeamNo + "') AND PlayerNo = 3 ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into tblTeamPlayers(IDTeam,Name,Surname,Email,Phone,PlayerNo)values(CInt('" + TeamNo + "'),'" + txtPl3Name.Text + "','" + txtPl3Surname.Text + "','" + txtPl3Email.Text + "','" + txtPl3Phone.Text + "',3)";
                    cmd.ExecuteNonQuery();
                }
                if (!string.IsNullOrEmpty(txtPl4Name.Text))
                {
                    cmd.CommandText = "Delete from tblTeamPlayers Where IDTeam = CInt('" + TeamNo + "') AND PlayerNo = 4 ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into tblTeamPlayers(IDTeam,Name,Surname,Email,Phone,PlayerNo)values(CInt('" + TeamNo + "'),'" + txtPl4Name.Text + "','" + txtPl4Surname.Text + "','" + txtPl4Email.Text + "','" + txtPl4Phone.Text + "',4)";
                    cmd.ExecuteNonQuery();
                }
                if (!string.IsNullOrEmpty(txtPl5Name.Text))
                {
                    cmd.CommandText = "Delete from tblTeamPlayers Where IDTeam = CInt('" + TeamNo + "') AND PlayerNo = 5 ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into tblTeamPlayers(IDTeam,Name,Surname,Email,Phone,PlayerNo)values(CInt('" + TeamNo + "'),'" + txtPl5Name.Text + "','" + txtPl5Surname.Text + "','" + txtPl5Email.Text + "','" + txtPl5Phone.Text + "',5)";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Record Save in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                Dataload();
                btnReset_Click(null, null);

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Event Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from tblTeams Where IDTeam = CInt('" + TeamNo + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Delete from tblTeamPlayers Where IDTeam = CInt('" + TeamNo + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Are you sure do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                conn.Close();
                Dataload();
                btnReset_Click(null, null);
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Event Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printBitMap = new Bitmap(this.gvTeamList.Width, this.gvTeamList.Height);
            gvTeamList.DrawToBitmap(printBitMap, new Rectangle(0, 0, this.gvTeamList.Width, this.gvTeamList.Height));
            e.Graphics.DrawImage(printBitMap, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDataGridViewDocumentPrintDialog = new PrintDialog();
            printDataGridViewDocumentPrintDialog.Document = printDocument1;
            printDataGridViewDocumentPrintDialog.UseEXDialog = true;

            DialogResult printDataGridViewDocumentDialogResult = printDataGridViewDocumentPrintDialog.ShowDialog();

            //If Print is clicked
            if (printDataGridViewDocumentDialogResult == DialogResult.OK)
            {
                printDocument1.DocumentName = "To Print DataGridView";
                printDocument1.Print();
            }
        }

        private void cmbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTournament.SelectedIndex >= 0)
            {
                cmbTournament.Text = "";
                cmbTournament.Enabled = true;
                txtTeamName.Enabled = true;
                txtPl1Name.Enabled = true;
                txtPl2Name.Enabled = true;
                txtPl3Name.Enabled = true;
                txtPl4Name.Enabled = true;
                txtPl5Name.Enabled = true;
                txtPl1Surname.Enabled = true;
                txtPl2Surname.Enabled = true;
                txtPl3Surname.Enabled = true;
                txtPl4Surname.Enabled = true;
                txtPl5Surname.Enabled = true;
                txtPl1Phone.Enabled = true;
                txtPl2Phone.Enabled = true;
                txtPl3Phone.Enabled = true;
                txtPl4Phone.Enabled = true;
                txtPl5Phone.Enabled = true;
                txtPl1Email.Enabled = true;
                txtPl2Email.Enabled = true;
                txtPl3Email.Enabled = true;
                txtPl4Email.Enabled = true;
                txtPl5Email.Enabled = true;
            }
            else
            {
                txtTeamName.Enabled = false;
                txtPl1Name.Enabled = false;
                txtPl2Name.Enabled = false;
                txtPl3Name.Enabled = false;
                txtPl4Name.Enabled = false;
                txtPl5Name.Enabled = false;
                txtPl1Surname.Enabled = false;
                txtPl2Surname.Enabled = false;
                txtPl3Surname.Enabled = false;
                txtPl4Surname.Enabled = false;
                txtPl5Surname.Enabled = false;
                txtPl1Phone.Enabled = false;
                txtPl2Phone.Enabled = false;
                txtPl3Phone.Enabled = false;
                txtPl4Phone.Enabled = false;
                txtPl5Phone.Enabled = false;
                txtPl1Email.Enabled = false;
                txtPl2Email.Enabled = false;
                txtPl3Email.Enabled = false;
                txtPl4Email.Enabled = false;
                txtPl5Email.Enabled = false;
            }
        }

        private void txtPl1Name_TextChanged(object sender, EventArgs e)
        {
            if (txtPl1Name.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl1Name.MaxLength = 15;
            }
        }

        private void txtPl2Name_TextChanged(object sender, EventArgs e)
        {
            if (txtPl2Name.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl2Name.MaxLength = 15;
            }
        }

        private void txtPl3Name_TextChanged(object sender, EventArgs e)
        {
            if (txtPl3Name.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl3Name.MaxLength = 15;
            }
        }

        private void txtPl4Name_TextChanged(object sender, EventArgs e)
        {
            if (txtPl3Name.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl4Name.MaxLength = 15;
            }
        }

        private void txtPl5Name_TextChanged(object sender, EventArgs e)
        {
            if (txtPl5Name.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl5Name.MaxLength = 15;
            }
        }

        private void txtTeamName_TextChanged(object sender, EventArgs e)
        {
            if (txtTeamName.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtTeamName.MaxLength = 20;
            }
        }

        private void txtPl1Surname_TextChanged(object sender, EventArgs e)
        {
            if (txtPl1Surname.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl1Surname.MaxLength = 15;
            }
        }

        private void txtPl2Surname_TextChanged(object sender, EventArgs e)
        {
            if (txtPl2Surname.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl2Surname.MaxLength = 15;
            }
        }

        private void txtPl3Surname_TextChanged(object sender, EventArgs e)
        {
            if (txtPl3Surname.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl3Surname.MaxLength = 15;
            }
        }

        private void txtPl4Surname_TextChanged(object sender, EventArgs e)
        {
            if (txtPl4Surname.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl4Surname.MaxLength = 15;
            }
        }

        private void txtPl5Surname_TextChanged(object sender, EventArgs e)
        {
            if (txtPl4Surname.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl4Surname.MaxLength = 15;
            }
        }

        private void txtPl1Email_TextChanged(object sender, EventArgs e)
        {
            if (txtPl1Email.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl1Email.MaxLength = 20;
            }
        }

        private void txtPl2Email_TextChanged(object sender, EventArgs e)
        {
            if (txtPl2Email.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl2Email.MaxLength = 20;
            }
        }

        private void txtPl3Email_TextChanged(object sender, EventArgs e)
        {
            if (txtPl3Email.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl3Email.MaxLength = 20;
            }
        }

        private void txtPl4Email_TextChanged(object sender, EventArgs e)
        {
            if (txtPl4Email.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl4Email.MaxLength = 20;
            }
        }

        private void txtPl5Email_TextChanged(object sender, EventArgs e)
        {
            if (txtPl5Email.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl5Email.MaxLength = 20;
            }
        }

        private void txtPl1Phone_TextChanged(object sender, EventArgs e)
        {
            if (txtPl1Phone.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl1Phone.MaxLength = 15;
            }
        }

        private void txtPl2Phone_TextChanged(object sender, EventArgs e)
        {
            if (txtPl2Phone.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl2Phone.MaxLength = 15;
            }
        }

        private void txtPl3Phone_TextChanged(object sender, EventArgs e)
        {
            if (txtPl3Phone.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl3Phone.MaxLength = 15;
            }
        }

        private void txtPl4Phone_TextChanged(object sender, EventArgs e)
        {
            if (txtPl4Phone.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl4Phone.MaxLength = 15;
            }
        }

        private void txtPl5Phone_TextChanged(object sender, EventArgs e)
        {
            if (txtPl5Phone.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPl5Phone.MaxLength = 15;
            }
        }

        private void txtPl1Email_Leave(object sender, EventArgs e)
        {
            if (!txtPl1Email.Text.Contains('@'))
            {
                MessageBox.Show("Please Add valid Email");
                txtPl1Email.Focus();
            }
        }

        private void txtPl2Email_Leave(object sender, EventArgs e)
        {
            if (!txtPl2Email.Text.Contains('@'))
            {
                MessageBox.Show("Please Add valid Email");
                txtPl2Email.Focus();
            }
        }

        private void txtPl3Email_Leave(object sender, EventArgs e)
        {
            if (!txtPl3Email.Text.Contains('@'))
            {
                MessageBox.Show("Please Add valid Email");
                txtPl3Email.Focus();
            }
        }

        private void txtPl4Email_Leave(object sender, EventArgs e)
        {
            if (!txtPl4Email.Text.Contains('@'))
            {
                MessageBox.Show("Please Add valid Email");
                txtPl4Email.Focus();
            }
        }

        private void txtPl5Email_Leave(object sender, EventArgs e)
        {
            if (!txtPl5Email.Text.Contains('@'))
            {
                MessageBox.Show("Please Add valid Email");
                txtPl5Email.Focus();
            }
        }

        private void txtPl1Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPl2Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPl3Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPl4Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPl5Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPl1Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPl2Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPl3Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPl4Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPl5Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPl1Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "System", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void txtPl2Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "System", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void txtPl3Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "System", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void txtPl4Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "System", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void txtPl5Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "System", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void txtTeamName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbTournament_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}