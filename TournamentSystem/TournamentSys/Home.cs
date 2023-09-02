using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentSys
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public void loadform(object Form) //Form should be responsibe and users should be able to move it
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnTournament_Click(object sender, EventArgs e)
        {
            loadform(new tournament());
        }

        private void btnIndiv_Click(object sender, EventArgs e)
        {
            loadform(new RegisterIndiv());
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            loadform(new RegisterTeam());
        }

        private void btnVSplayer_Click(object sender, EventArgs e)
        {
            loadform(new ScoreIndiv());
        }

        private void btnVSteams_Click(object sender, EventArgs e)
        {
            loadform(new ScoreTeams());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
