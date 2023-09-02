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

namespace TournamentSys
{
    public partial class tournament : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = TournamentSystem.accdb");
        public tournament()
        {
            InitializeComponent();
        }
        private static String IDTournamentID = "";
        private DataTable dtLastNo;
        
        private static bool add = true;
        private void Form4_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            try
            {
                DataTable Dt = new DataTable();
                DataRow drow;
                Dt.Columns.Add(new DataColumn("IDTournament"));
                Dt.Columns.Add(new DataColumn("TournamentName"));
                Dt.Columns.Add(new DataColumn("Event_1"));
                Dt.Columns.Add(new DataColumn("Event_2"));
                Dt.Columns.Add(new DataColumn("Event_3"));
                Dt.Columns.Add(new DataColumn("Event_4"));
                Dt.Columns.Add(new DataColumn("Event_5"));


                conn.Open();
                OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                OleDbCommand command = new OleDbCommand("SELECT * from  tblTournament ", conn);
                sqlDA.SelectCommand = command;
                sqlDA.Fill(ds);

                


                DataTable DtTournament = new DataTable();
                DtTournament = ds.Tables[0];
                for (int i = 0; i < DtTournament.Rows.Count; i++)
                {
                    drow = Dt.NewRow();
                    int id = Convert.ToInt32(DtTournament.Rows[i]["IDTournament"].ToString());
                    drow[0] = DtTournament.Rows[i]["IDTournament"].ToString();
                    drow[1] = DtTournament.Rows[i]["TournamentName"].ToString();

                    DataSet dsD = new DataSet();
                    OleDbCommand commandD = new OleDbCommand("SELECT * from  tblTournamentDetails Where IDTournament = CInt('" + id + "') ", conn);
                    sqlDA.SelectCommand = commandD;
                    sqlDA.Fill(dsD);

                    for (int a = 0; a < dsD.Tables[0].Rows.Count; a++)
                    {
                        if (a == 0)
                        {
                            drow[2] = dsD.Tables[0].Rows[a]["Event"].ToString();
                        }
                        else if (a == 1)
                        {
                            drow[3] = dsD.Tables[0].Rows[a]["Event"].ToString();
                        }
                        else if (a == 2)
                        {
                            drow[4] = dsD.Tables[0].Rows[a]["Event"].ToString();
                        }
                        else if (a == 3)
                        {
                            drow[5] = dsD.Tables[0].Rows[a]["Event"].ToString();
                        }
                        else if (a == 4)
                        {
                            drow[6] = dsD.Tables[0].Rows[a]["Event"].ToString();
                        }

                    }
                    Dt.Rows.Add(drow);
                }


                conn.Close();
                gvEventList.DataSource = Dt;
                btnEventReset_Click(null, null);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEventReset_Click(object sender, EventArgs e)
        {
            try
            {
                btnEventAdd.Enabled = true;
                btnEventUpdate.Enabled = false;
                btnEventDelete.Enabled = false;
                txtTitle.Clear();
                txtEvent1.Clear();
                txtEvent2.Clear();
                txtEvent3.Clear();
                txtEvent4.Clear();
                txtEvent5.Clear();
                IDTournamentID = "";
                add = true;
                txtTitle.Enabled = true;
                //DataLoad();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Event Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private int GetLastIDTournament()
        {
            try
            {
                int TournamentNo = 0;
                conn.Open();
                OleDbDataAdapter sqlDA = new OleDbDataAdapter();
                DataSet dsN = new DataSet();
                OleDbCommand command = new OleDbCommand("SELECT Max(tblTournament.IDTournament) AS [No] FROM tblTournament;", conn);
                sqlDA.SelectCommand = command;
                sqlDA.Fill(dsN);
                dtLastNo = dsN.Tables[0];
                conn.Close();
                if (dtLastNo != null && dtLastNo.Rows.Count > 0)
                {
                    if (dtLastNo.Rows[0][0].ToString()=="")
                    {
                        TournamentNo = 1;
                    }
                    else
                    {
                        TournamentNo = Convert.ToInt32(dtLastNo.Rows[0][0].ToString()) + 1;
                    }
                    
                }
                return TournamentNo;
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }
        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtEvent1.Text == "" || txtEvent2.Text == "" || txtEvent3.Text == "" || txtEvent4.Text == "" || txtEvent5.Text == "")
            {
                MessageBox.Show("Please fill information", "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataSave();
            }
        }

        private void DataSave()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTitle.Text))
                {
                    int TournamentNo = GetLastIDTournament();
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    

                    if (add)
                    {
                        
                        cmd.CommandText = "insert into tblTournament(IDTournament,TournamentName)values('" + TournamentNo + "','" + txtTitle.Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        TournamentNo = Convert.ToInt32(IDTournamentID);
                    }
                    
                    if (!string.IsNullOrEmpty(txtEvent1.Text))
                    {
                        cmd.CommandText = "insert into tblTournamentDetails(IDTournament,Event)values('" + TournamentNo + "','" + txtEvent1.Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    if (!string.IsNullOrEmpty(txtEvent2.Text))
                    {
                        cmd.CommandText = "insert into tblTournamentDetails(IDTournament,Event)values('" + TournamentNo + "','" + txtEvent2.Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    if (!string.IsNullOrEmpty(txtEvent3.Text))
                    {
                        cmd.CommandText = "insert into tblTournamentDetails(IDTournament,Event)values('" + TournamentNo + "','" + txtEvent3.Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    if (!string.IsNullOrEmpty(txtEvent4.Text))
                    {
                        cmd.CommandText = "insert into tblTournamentDetails(IDTournament,Event)values('" + TournamentNo + "','" + txtEvent4.Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    if (!string.IsNullOrEmpty(txtEvent5.Text))
                    {
                        cmd.CommandText = "insert into tblTournamentDetails(IDTournament,Event)values('" + TournamentNo + "','" + txtEvent5.Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    MessageBox.Show("Record Save in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataLoad();
                }

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvEventList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvEventList.Rows.Count > -1)
                {
                    btnEventUpdate.Enabled = true;
                    btnEventDelete.Enabled = true;
                    IDTournamentID = gvEventList.Rows[e.RowIndex].Cells["IDTournament"].Value.ToString();
                    txtTitle.Text = gvEventList.Rows[e.RowIndex].Cells["TournamentName"].Value.ToString();
                    txtEvent1.Text = gvEventList.Rows[e.RowIndex].Cells["Event_1"].Value.ToString();
                    txtEvent2.Text = gvEventList.Rows[e.RowIndex].Cells["Event_2"].Value.ToString();
                    txtEvent3.Text = gvEventList.Rows[e.RowIndex].Cells["Event_3"].Value.ToString();
                    txtEvent4.Text = gvEventList.Rows[e.RowIndex].Cells["Event_4"].Value.ToString();
                    txtEvent5.Text = gvEventList.Rows[e.RowIndex].Cells["Event_5"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvEventList_MouseClick(object sender, MouseEventArgs e)
        {
            gvEventList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnEventUpdate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtEvent1.Text == "" || txtEvent2.Text == "" || txtEvent3.Text == "" || txtEvent4.Text == "" || txtEvent5.Text == "")
            {
                MessageBox.Show("Please fill information", "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                try
            {
                if (IDTournamentID != "")
                {
                    add = false;
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Update tblTournament set TournamentName = '" + txtTitle.Text + "' Where IDTournament = CInt('" + Convert.ToInt32(IDTournamentID) + "')";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "Delete from tblTournamentDetails Where IDTournament = CInt('" + Convert.ToInt32(IDTournamentID) + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    DataSave();

                    //MessageBox.Show("Record Update in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IDTournamentID = "";
                    conn.Close();
                    DataLoad();
                    btnEventReset_Click(null,null);
                    add = true;
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

        private void btnEventDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDTournamentID != "")
                {
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from tblTournament Where IDTournament = CInt('" + Convert.ToInt32(IDTournamentID) + "')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Delete from tblTournamentDetails Where IDTournament = CInt('" + Convert.ToInt32(IDTournamentID) + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Delete in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IDTournamentID = "";
                    conn.Close();
                    DataLoad();
                    btnEventReset_Click(null, null);
                }

                else
                {
                    MessageBox.Show("Plesae load the data", "Event Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Event Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printBitMap = new Bitmap(this.gvEventList.Width, this.gvEventList.Height);
            gvEventList.DrawToBitmap(printBitMap, new Rectangle(0, 0, this.gvEventList.Width, this.gvEventList.Height));
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

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length >= 35)
            {
                MessageBox.Show("maximum of 35 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtTitle.MaxLength = 35;
            }
        }

        private void txtEvent1_TextChanged(object sender, EventArgs e)
        {
            if (txtEvent1.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtEvent1.MaxLength = 20;
            }
        }

        private void txtEvent2_TextChanged(object sender, EventArgs e)
        {
            if (txtEvent2.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtEvent2.MaxLength = 20;
            }
        }

        private void txtEvent3_TextChanged(object sender, EventArgs e)
        {
            if (txtEvent3.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtEvent3.MaxLength = 20;
            }
        }

        private void txtEvent4_TextChanged(object sender, EventArgs e)
        {
            if (txtEvent4.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtEvent4.MaxLength = 20;
            }
        }

        private void txtEvent5_TextChanged(object sender, EventArgs e)
        {
            if (txtEvent5.Text.Length >= 20)
            {
                MessageBox.Show("maximum of 20 characters", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtEvent5.MaxLength = 20;
            }
        }
    }
}
