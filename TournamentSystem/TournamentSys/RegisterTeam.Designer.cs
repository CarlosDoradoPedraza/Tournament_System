
namespace TournamentSys
{
    partial class RegisterTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterTeam));
            this.lblteamform = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTName = new System.Windows.Forms.Label();
            this.cmbTournament = new System.Windows.Forms.ComboBox();
            this.lblLeader = new System.Windows.Forms.Label();
            this.txtPl1Name = new System.Windows.Forms.TextBox();
            this.txtPl1Surname = new System.Windows.Forms.TextBox();
            this.txtPl1Email = new System.Windows.Forms.TextBox();
            this.txtPl1Phone = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txtPl2Name = new System.Windows.Forms.TextBox();
            this.txtPl2Surname = new System.Windows.Forms.TextBox();
            this.txtPl2Email = new System.Windows.Forms.TextBox();
            this.txtPl2Phone = new System.Windows.Forms.TextBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblSurname2 = new System.Windows.Forms.Label();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPl3Name = new System.Windows.Forms.TextBox();
            this.txtPl3Surname = new System.Windows.Forms.TextBox();
            this.txtPl3Email = new System.Windows.Forms.TextBox();
            this.txtPl3Phone = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.txtPl4Name = new System.Windows.Forms.TextBox();
            this.txtPl4Surname = new System.Windows.Forms.TextBox();
            this.txtPl4Email = new System.Windows.Forms.TextBox();
            this.txtPl4Phone = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.txtPl5Name = new System.Windows.Forms.TextBox();
            this.txtPl5Surname = new System.Windows.Forms.TextBox();
            this.txtPl5Email = new System.Windows.Forms.TextBox();
            this.txtPl5Phone = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gvTeamList = new System.Windows.Forms.DataGridView();
            this.lblSurname1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeamList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblteamform
            // 
            this.lblteamform.AutoSize = true;
            this.lblteamform.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteamform.ForeColor = System.Drawing.Color.White;
            this.lblteamform.Location = new System.Drawing.Point(21, 29);
            this.lblteamform.Name = "lblteamform";
            this.lblteamform.Size = new System.Drawing.Size(402, 37);
            this.lblteamform.TabIndex = 5;
            this.lblteamform.Text = "Teams Registration Form";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Enabled = false;
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.Location = new System.Drawing.Point(156, 200);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(161, 29);
            this.txtTeamName.TabIndex = 12;
            this.txtTeamName.TextChanged += new System.EventHandler(this.txtTeamName_TextChanged);
            this.txtTeamName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeamName_KeyPress);
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTName.ForeColor = System.Drawing.Color.White;
            this.lblTName.Location = new System.Drawing.Point(25, 200);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(115, 25);
            this.lblTName.TabIndex = 11;
            this.lblTName.Text = "Team Name";
            // 
            // cmbTournament
            // 
            this.cmbTournament.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTournament.Enabled = false;
            this.cmbTournament.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTournament.FormattingEnabled = true;
            this.cmbTournament.Location = new System.Drawing.Point(30, 135);
            this.cmbTournament.Name = "cmbTournament";
            this.cmbTournament.Size = new System.Drawing.Size(287, 33);
            this.cmbTournament.TabIndex = 10;
            this.cmbTournament.SelectedIndexChanged += new System.EventHandler(this.cmbTournament_SelectedIndexChanged);
            this.cmbTournament.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTournament_KeyPress);
            // 
            // lblLeader
            // 
            this.lblLeader.AutoSize = true;
            this.lblLeader.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeader.ForeColor = System.Drawing.Color.White;
            this.lblLeader.Location = new System.Drawing.Point(27, 251);
            this.lblLeader.Name = "lblLeader";
            this.lblLeader.Size = new System.Drawing.Size(94, 25);
            this.lblLeader.TabIndex = 11;
            this.lblLeader.Text = "Player #1";
            // 
            // txtPl1Name
            // 
            this.txtPl1Name.Enabled = false;
            this.txtPl1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl1Name.Location = new System.Drawing.Point(156, 248);
            this.txtPl1Name.Name = "txtPl1Name";
            this.txtPl1Name.Size = new System.Drawing.Size(161, 29);
            this.txtPl1Name.TabIndex = 12;
            this.txtPl1Name.TextChanged += new System.EventHandler(this.txtPl1Name_TextChanged);
            this.txtPl1Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl1Name_KeyPress);
            // 
            // txtPl1Surname
            // 
            this.txtPl1Surname.Enabled = false;
            this.txtPl1Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl1Surname.Location = new System.Drawing.Point(336, 248);
            this.txtPl1Surname.Name = "txtPl1Surname";
            this.txtPl1Surname.Size = new System.Drawing.Size(172, 29);
            this.txtPl1Surname.TabIndex = 12;
            this.txtPl1Surname.TextChanged += new System.EventHandler(this.txtPl1Surname_TextChanged);
            this.txtPl1Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl1Surname_KeyPress);
            // 
            // txtPl1Email
            // 
            this.txtPl1Email.Enabled = false;
            this.txtPl1Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl1Email.Location = new System.Drawing.Point(523, 248);
            this.txtPl1Email.Name = "txtPl1Email";
            this.txtPl1Email.Size = new System.Drawing.Size(172, 29);
            this.txtPl1Email.TabIndex = 12;
            this.txtPl1Email.TextChanged += new System.EventHandler(this.txtPl1Email_TextChanged);
            this.txtPl1Email.Leave += new System.EventHandler(this.txtPl1Email_Leave);
            // 
            // txtPl1Phone
            // 
            this.txtPl1Phone.Enabled = false;
            this.txtPl1Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl1Phone.Location = new System.Drawing.Point(712, 248);
            this.txtPl1Phone.Name = "txtPl1Phone";
            this.txtPl1Phone.Size = new System.Drawing.Size(172, 29);
            this.txtPl1Phone.TabIndex = 12;
            this.txtPl1Phone.TextChanged += new System.EventHandler(this.txtPl1Phone_TextChanged);
            this.txtPl1Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl1Phone_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(153, 280);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(333, 280);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(73, 16);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(520, 280);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(709, 280);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 16);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(27, 311);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(94, 25);
            this.lblPlayer1.TabIndex = 11;
            this.lblPlayer1.Text = "Player #2";
            // 
            // txtPl2Name
            // 
            this.txtPl2Name.Enabled = false;
            this.txtPl2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl2Name.Location = new System.Drawing.Point(156, 308);
            this.txtPl2Name.Name = "txtPl2Name";
            this.txtPl2Name.Size = new System.Drawing.Size(161, 29);
            this.txtPl2Name.TabIndex = 12;
            this.txtPl2Name.TextChanged += new System.EventHandler(this.txtPl2Name_TextChanged);
            this.txtPl2Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl2Name_KeyPress);
            // 
            // txtPl2Surname
            // 
            this.txtPl2Surname.Enabled = false;
            this.txtPl2Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl2Surname.Location = new System.Drawing.Point(336, 308);
            this.txtPl2Surname.Name = "txtPl2Surname";
            this.txtPl2Surname.Size = new System.Drawing.Size(172, 29);
            this.txtPl2Surname.TabIndex = 12;
            this.txtPl2Surname.TextChanged += new System.EventHandler(this.txtPl2Surname_TextChanged);
            this.txtPl2Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl2Surname_KeyPress);
            // 
            // txtPl2Email
            // 
            this.txtPl2Email.Enabled = false;
            this.txtPl2Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl2Email.Location = new System.Drawing.Point(523, 308);
            this.txtPl2Email.Name = "txtPl2Email";
            this.txtPl2Email.Size = new System.Drawing.Size(172, 29);
            this.txtPl2Email.TabIndex = 12;
            this.txtPl2Email.TextChanged += new System.EventHandler(this.txtPl2Email_TextChanged);
            this.txtPl2Email.Leave += new System.EventHandler(this.txtPl2Email_Leave);
            // 
            // txtPl2Phone
            // 
            this.txtPl2Phone.Enabled = false;
            this.txtPl2Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl2Phone.Location = new System.Drawing.Point(712, 308);
            this.txtPl2Phone.Name = "txtPl2Phone";
            this.txtPl2Phone.Size = new System.Drawing.Size(172, 29);
            this.txtPl2Phone.TabIndex = 12;
            this.txtPl2Phone.TextChanged += new System.EventHandler(this.txtPl2Phone_TextChanged);
            this.txtPl2Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl2Phone_KeyPress);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.ForeColor = System.Drawing.Color.White;
            this.lblName1.Location = new System.Drawing.Point(153, 340);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(73, 16);
            this.lblName1.TabIndex = 13;
            this.lblName1.Text = "First Name";
            // 
            // lblSurname2
            // 
            this.lblSurname2.AutoSize = true;
            this.lblSurname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname2.ForeColor = System.Drawing.Color.White;
            this.lblSurname2.Location = new System.Drawing.Point(335, 400);
            this.lblSurname2.Name = "lblSurname2";
            this.lblSurname2.Size = new System.Drawing.Size(73, 16);
            this.lblSurname2.TabIndex = 14;
            this.lblSurname2.Text = "Last Name";
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail1.ForeColor = System.Drawing.Color.White;
            this.lblEmail1.Location = new System.Drawing.Point(520, 340);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(42, 16);
            this.lblEmail1.TabIndex = 14;
            this.lblEmail1.Text = "Email";
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone1.ForeColor = System.Drawing.Color.White;
            this.lblPhone1.Location = new System.Drawing.Point(709, 340);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(47, 16);
            this.lblPhone1.TabIndex = 14;
            this.lblPhone1.Text = "Phone";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(27, 371);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(94, 25);
            this.lblPlayer2.TabIndex = 11;
            this.lblPlayer2.Text = "Player #3";
            // 
            // txtPl3Name
            // 
            this.txtPl3Name.Enabled = false;
            this.txtPl3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl3Name.Location = new System.Drawing.Point(156, 368);
            this.txtPl3Name.Name = "txtPl3Name";
            this.txtPl3Name.Size = new System.Drawing.Size(161, 29);
            this.txtPl3Name.TabIndex = 12;
            this.txtPl3Name.TextChanged += new System.EventHandler(this.txtPl3Name_TextChanged);
            this.txtPl3Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl3Name_KeyPress);
            // 
            // txtPl3Surname
            // 
            this.txtPl3Surname.Enabled = false;
            this.txtPl3Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl3Surname.Location = new System.Drawing.Point(336, 368);
            this.txtPl3Surname.Name = "txtPl3Surname";
            this.txtPl3Surname.Size = new System.Drawing.Size(172, 29);
            this.txtPl3Surname.TabIndex = 12;
            this.txtPl3Surname.TextChanged += new System.EventHandler(this.txtPl3Surname_TextChanged);
            this.txtPl3Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl3Surname_KeyPress);
            // 
            // txtPl3Email
            // 
            this.txtPl3Email.Enabled = false;
            this.txtPl3Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl3Email.Location = new System.Drawing.Point(523, 368);
            this.txtPl3Email.Name = "txtPl3Email";
            this.txtPl3Email.Size = new System.Drawing.Size(172, 29);
            this.txtPl3Email.TabIndex = 12;
            this.txtPl3Email.TextChanged += new System.EventHandler(this.txtPl3Email_TextChanged);
            this.txtPl3Email.Leave += new System.EventHandler(this.txtPl3Email_Leave);
            // 
            // txtPl3Phone
            // 
            this.txtPl3Phone.Enabled = false;
            this.txtPl3Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl3Phone.Location = new System.Drawing.Point(712, 368);
            this.txtPl3Phone.Name = "txtPl3Phone";
            this.txtPl3Phone.Size = new System.Drawing.Size(172, 29);
            this.txtPl3Phone.TabIndex = 12;
            this.txtPl3Phone.TextChanged += new System.EventHandler(this.txtPl3Phone_TextChanged);
            this.txtPl3Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl3Phone_KeyPress);
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.ForeColor = System.Drawing.Color.White;
            this.lblName2.Location = new System.Drawing.Point(153, 400);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(73, 16);
            this.lblName2.TabIndex = 13;
            this.lblName2.Text = "First Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(520, 400);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 14;
            this.label17.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(709, 400);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 16);
            this.label18.TabIndex = 14;
            this.label18.Text = "Phone";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer3.ForeColor = System.Drawing.Color.White;
            this.lblPlayer3.Location = new System.Drawing.Point(27, 431);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(94, 25);
            this.lblPlayer3.TabIndex = 11;
            this.lblPlayer3.Text = "Player #4";
            // 
            // txtPl4Name
            // 
            this.txtPl4Name.Enabled = false;
            this.txtPl4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl4Name.Location = new System.Drawing.Point(156, 428);
            this.txtPl4Name.Name = "txtPl4Name";
            this.txtPl4Name.Size = new System.Drawing.Size(161, 29);
            this.txtPl4Name.TabIndex = 12;
            this.txtPl4Name.TextChanged += new System.EventHandler(this.txtPl4Name_TextChanged);
            this.txtPl4Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl4Name_KeyPress);
            // 
            // txtPl4Surname
            // 
            this.txtPl4Surname.Enabled = false;
            this.txtPl4Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl4Surname.Location = new System.Drawing.Point(336, 428);
            this.txtPl4Surname.Name = "txtPl4Surname";
            this.txtPl4Surname.Size = new System.Drawing.Size(172, 29);
            this.txtPl4Surname.TabIndex = 12;
            this.txtPl4Surname.TextChanged += new System.EventHandler(this.txtPl4Surname_TextChanged);
            this.txtPl4Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl4Surname_KeyPress);
            // 
            // txtPl4Email
            // 
            this.txtPl4Email.Enabled = false;
            this.txtPl4Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl4Email.Location = new System.Drawing.Point(523, 428);
            this.txtPl4Email.Name = "txtPl4Email";
            this.txtPl4Email.Size = new System.Drawing.Size(172, 29);
            this.txtPl4Email.TabIndex = 12;
            this.txtPl4Email.TextChanged += new System.EventHandler(this.txtPl4Email_TextChanged);
            this.txtPl4Email.Leave += new System.EventHandler(this.txtPl4Email_Leave);
            // 
            // txtPl4Phone
            // 
            this.txtPl4Phone.Enabled = false;
            this.txtPl4Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl4Phone.Location = new System.Drawing.Point(712, 428);
            this.txtPl4Phone.Name = "txtPl4Phone";
            this.txtPl4Phone.Size = new System.Drawing.Size(172, 29);
            this.txtPl4Phone.TabIndex = 12;
            this.txtPl4Phone.TextChanged += new System.EventHandler(this.txtPl4Phone_TextChanged);
            this.txtPl4Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl4Phone_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(153, 460);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 16);
            this.label20.TabIndex = 13;
            this.label20.Text = "First Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(333, 460);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 16);
            this.label21.TabIndex = 14;
            this.label21.Text = "Last Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(520, 460);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 16);
            this.label22.TabIndex = 14;
            this.label22.Text = "Email";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(709, 460);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 16);
            this.label23.TabIndex = 14;
            this.label23.Text = "Phone";
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer4.ForeColor = System.Drawing.Color.White;
            this.lblPlayer4.Location = new System.Drawing.Point(27, 494);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(94, 25);
            this.lblPlayer4.TabIndex = 11;
            this.lblPlayer4.Text = "Player #5";
            // 
            // txtPl5Name
            // 
            this.txtPl5Name.Enabled = false;
            this.txtPl5Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl5Name.Location = new System.Drawing.Point(156, 491);
            this.txtPl5Name.Name = "txtPl5Name";
            this.txtPl5Name.Size = new System.Drawing.Size(161, 29);
            this.txtPl5Name.TabIndex = 12;
            this.txtPl5Name.TextChanged += new System.EventHandler(this.txtPl5Name_TextChanged);
            this.txtPl5Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl5Name_KeyPress);
            // 
            // txtPl5Surname
            // 
            this.txtPl5Surname.Enabled = false;
            this.txtPl5Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl5Surname.Location = new System.Drawing.Point(336, 491);
            this.txtPl5Surname.Name = "txtPl5Surname";
            this.txtPl5Surname.Size = new System.Drawing.Size(172, 29);
            this.txtPl5Surname.TabIndex = 12;
            this.txtPl5Surname.TextChanged += new System.EventHandler(this.txtPl5Surname_TextChanged);
            this.txtPl5Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl5Surname_KeyPress);
            // 
            // txtPl5Email
            // 
            this.txtPl5Email.Enabled = false;
            this.txtPl5Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl5Email.Location = new System.Drawing.Point(523, 491);
            this.txtPl5Email.Name = "txtPl5Email";
            this.txtPl5Email.Size = new System.Drawing.Size(172, 29);
            this.txtPl5Email.TabIndex = 12;
            this.txtPl5Email.TextChanged += new System.EventHandler(this.txtPl5Email_TextChanged);
            this.txtPl5Email.Leave += new System.EventHandler(this.txtPl5Email_Leave);
            // 
            // txtPl5Phone
            // 
            this.txtPl5Phone.Enabled = false;
            this.txtPl5Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPl5Phone.Location = new System.Drawing.Point(712, 491);
            this.txtPl5Phone.Name = "txtPl5Phone";
            this.txtPl5Phone.Size = new System.Drawing.Size(172, 29);
            this.txtPl5Phone.TabIndex = 12;
            this.txtPl5Phone.TextChanged += new System.EventHandler(this.txtPl5Phone_TextChanged);
            this.txtPl5Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPl5Phone_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(153, 523);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 16);
            this.label25.TabIndex = 13;
            this.label25.Text = "First Name";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(333, 523);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 16);
            this.label26.TabIndex = 14;
            this.label26.Text = "Last Name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(520, 523);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 16);
            this.label27.TabIndex = 14;
            this.label27.Text = "Email";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(709, 523);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 16);
            this.label28.TabIndex = 14;
            this.label28.Text = "Phone";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(138, 568);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 32);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(203)))), ((int)(((byte)(174)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(28, 568);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 32);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(235, 867);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 32);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(134, 867);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 32);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(33, 867);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gvTeamList
            // 
            this.gvTeamList.AllowUserToAddRows = false;
            this.gvTeamList.AllowUserToDeleteRows = false;
            this.gvTeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTeamList.Location = new System.Drawing.Point(29, 619);
            this.gvTeamList.Name = "gvTeamList";
            this.gvTeamList.ReadOnly = true;
            this.gvTeamList.Size = new System.Drawing.Size(649, 231);
            this.gvTeamList.TabIndex = 20;
            this.gvTeamList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTeamList_CellDoubleClick);
            this.gvTeamList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvTeamList_MouseClick);
            // 
            // lblSurname1
            // 
            this.lblSurname1.AutoSize = true;
            this.lblSurname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname1.ForeColor = System.Drawing.Color.White;
            this.lblSurname1.Location = new System.Drawing.Point(335, 340);
            this.lblSurname1.Name = "lblSurname1";
            this.lblSurname1.Size = new System.Drawing.Size(73, 16);
            this.lblSurname1.TabIndex = 14;
            this.lblSurname1.Text = "Last Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 247);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 961);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 10);
            this.panel1.TabIndex = 40;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Select tournament...";
            // 
            // RegisterTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(916, 788);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblteamform);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gvTeamList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblPhone1);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblEmail1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblSurname1);
            this.Controls.Add(this.lblSurname2);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPl5Phone);
            this.Controls.Add(this.txtPl4Phone);
            this.Controls.Add(this.txtPl3Phone);
            this.Controls.Add(this.txtPl2Phone);
            this.Controls.Add(this.txtPl1Phone);
            this.Controls.Add(this.txtPl5Email);
            this.Controls.Add(this.txtPl4Email);
            this.Controls.Add(this.txtPl3Email);
            this.Controls.Add(this.txtPl2Email);
            this.Controls.Add(this.txtPl1Email);
            this.Controls.Add(this.txtPl5Surname);
            this.Controls.Add(this.txtPl5Name);
            this.Controls.Add(this.txtPl4Surname);
            this.Controls.Add(this.txtPl4Name);
            this.Controls.Add(this.txtPl3Surname);
            this.Controls.Add(this.txtPl3Name);
            this.Controls.Add(this.txtPl2Surname);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.txtPl2Name);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.txtPl1Surname);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.txtPl1Name);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblLeader);
            this.Controls.Add(this.lblTName);
            this.Controls.Add(this.cmbTournament);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterTeam";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.RegisterTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTeamList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblteamform;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.ComboBox cmbTournament;
        private System.Windows.Forms.Label lblLeader;
        private System.Windows.Forms.TextBox txtPl1Name;
        private System.Windows.Forms.TextBox txtPl1Surname;
        private System.Windows.Forms.TextBox txtPl1Email;
        private System.Windows.Forms.TextBox txtPl1Phone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox txtPl2Name;
        private System.Windows.Forms.TextBox txtPl2Surname;
        private System.Windows.Forms.TextBox txtPl2Email;
        private System.Windows.Forms.TextBox txtPl2Phone;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblSurname2;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPl3Name;
        private System.Windows.Forms.TextBox txtPl3Surname;
        private System.Windows.Forms.TextBox txtPl3Email;
        private System.Windows.Forms.TextBox txtPl3Phone;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.TextBox txtPl4Name;
        private System.Windows.Forms.TextBox txtPl4Surname;
        private System.Windows.Forms.TextBox txtPl4Email;
        private System.Windows.Forms.TextBox txtPl4Phone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.TextBox txtPl5Name;
        private System.Windows.Forms.TextBox txtPl5Surname;
        private System.Windows.Forms.TextBox txtPl5Email;
        private System.Windows.Forms.TextBox txtPl5Phone;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView gvTeamList;
        private System.Windows.Forms.Label lblSurname1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label6;
    }
}