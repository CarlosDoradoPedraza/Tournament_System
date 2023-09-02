using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace TournamentSys
{
    public partial class RegisterIndiv : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = TournamentSystem.accdb");
        public RegisterIndiv()
        {
            InitializeComponent();
        }
        private static String IDIndividual = "";
        private void Form2_Load(object sender, EventArgs e)
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
            cmbTournament_SelectedIndexChanged(null, null);
            btnReset_Click(null,null);


        }

        private void Dataload()
        {
            conn.Open();
            OleDbDataAdapter sqlDA = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            OleDbCommand command = new OleDbCommand("SELECT * from  tblIndividuals ", conn);
            sqlDA.SelectCommand = command;
            sqlDA.Fill(ds);
            conn.Close();
            gvIndividuals.DataSource = ds.Tables[0];
        }


        private void cmbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbTournament.SelectedIndex>=0)  //Inputs disabled if no one selects a tournament
                {
                    cmbTournament.Text = "";
                    cmbTournament.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtLastName.Enabled = true;
                    txtPhone.Enabled = true;
                    txtEmail.Enabled = true;
                }
                else
                {
                    cmbTournament.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtPhone.Enabled = false;
                    txtEmail.Enabled = false;
                }
                if (cmbTournament.Items.Count > 0) //Display event data from a selected tournament
                {
                    conn.Open();
                    OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                    DataSet dsE = new DataSet();
                    OleDbCommand command = new OleDbCommand("SELECT * from  tblTournamentDetails Where IDTournament = CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "')", conn);
                    sqlDA.SelectCommand = command;
                    sqlDA.Fill(dsE);
                    conn.Close();
                    DataTable dt = dsE.Tables[0];
                    dt.Rows.Add(1000, 1, "ALL");
                    cmbEvent.DataSource = dt;
                    cmbEvent.DisplayMember = "Event";
                    cmbEvent.ValueMember = "id";

                }

            }
            catch (Exception)
            {
                conn.Close();
                // throw;
            }
        }
        //Clear all inputs
        private void btnReset_Click(object sender, EventArgs e)
        {
        
    
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                //cmbTournament.SelectedIndex = 0;
            
            cmbTournament_SelectedIndexChanged(null,null);

        }

        private void gvIndividuals_MouseClick(object sender, MouseEventArgs e)
        {
            gvIndividuals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void gvIndividuals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvIndividuals.Rows.Count > -1)
                {
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    IDIndividual = gvIndividuals.Rows[e.RowIndex].Cells["IDIndividual"].Value.ToString();
                    txtFirstName.Text = gvIndividuals.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                    txtLastName.Text = gvIndividuals.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                    txtEmail.Text = gvIndividuals.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    txtPhone.Text = gvIndividuals.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                    cmbTournament.SelectedValue = gvIndividuals.Rows[e.RowIndex].Cells["IDTournament"].Value.ToString();
                    cmbEvent.Text = gvIndividuals.Rows[e.RowIndex].Cells["Event"].Value.ToString();


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
                if (IDIndividual != "")
                {
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from tblIndividuals Where IDIndividual = CInt('" + Convert.ToInt32(IDIndividual) + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IDIndividual = "";
                    conn.Close();
                    Dataload();
                    btnReset_Click(null, null);
                }

                else
                {
                    MessageBox.Show("Plesae load the data", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Event ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbTournament.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || cmbEvent.Text == "")
            {
                MessageBox.Show("Please fill information", "Access connect", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
                try
            {
                if (IDIndividual != "")
                {
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Update tblIndividuals set FirstName = '" + txtFirstName.Text + "',LastName = '" + txtLastName.Text + "',Email = '" + txtEmail.Text + "',Phone = '" + txtPhone.Text + "',Event = '" + cmbEvent.Text + "',IDTournament = CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "') Where IDIndividual = CInt('" + Convert.ToInt32(IDIndividual) + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record updated in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IDIndividual = "";
                    conn.Close();
                    Dataload();
                    btnReset_Click(null, null);
                }
                else
                {

                    MessageBox.Show("Plesae load the data", "Event Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Event Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printBitMap = new Bitmap(this.gvIndividuals.Width, this.gvIndividuals.Height);
            gvIndividuals.DrawToBitmap(printBitMap, new Rectangle(0, 0, this.gvIndividuals.Width, this.gvIndividuals.Height));
            e.Graphics.DrawImage(printBitMap, 0, 0);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtFirstName.MaxLength = 15;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtLastName.MaxLength = 15;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //Improve validation rule to include "."
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains('@'))
            {
                MessageBox.Show("Please Add valid Email");
                txtEmail.Focus();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtEmail.MaxLength = 20;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length >= 15)
            {
                MessageBox.Show("maximum of 15 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPhone.MaxLength = 15;
            }
        }
        //Improve validation number for UK number
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "System",MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void cmbTournament_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbTournament.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || cmbEvent.Text == "")
            {
                MessageBox.Show("Please fill information", "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                try
                {
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into tblIndividuals(FirstName,LastName,Email,Phone,Event,IDTournament)values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmail.Text + "','" + txtEmail.Text + "','" + cmbEvent.Text + "',CInt('" + Convert.ToInt32(cmbTournament.SelectedValue.ToString()) + "'))";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Save in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dataload();
                    btnReset_Click(null, null);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDataGridViewDocumentPrintDialog = new PrintDialog();
            printDataGridViewDocumentPrintDialog.Document = printDocument1;
            printDataGridViewDocumentPrintDialog.UseEXDialog = true;

            DialogResult printDataGridViewDocumentDialogResult = printDataGridViewDocumentPrintDialog.ShowDialog();

            if (printDataGridViewDocumentDialogResult == DialogResult.OK)
            {
                printDocument1.DocumentName = "To Print DataGridView";
                printDocument1.Print();
            }
        }

        private void cmbEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEvent.Text = "";
        }
    }
}
