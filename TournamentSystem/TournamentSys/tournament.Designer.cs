
namespace TournamentSys
{
    partial class tournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tournament));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEventDelete = new System.Windows.Forms.Button();
            this.btnEventUpdate = new System.Windows.Forms.Button();
            this.btnEventReset = new System.Windows.Forms.Button();
            this.btnEventAdd = new System.Windows.Forms.Button();
            this.gvEventList = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtEvent3 = new System.Windows.Forms.TextBox();
            this.lblEvent3 = new System.Windows.Forms.Label();
            this.txtEvent2 = new System.Windows.Forms.TextBox();
            this.lblEvent2 = new System.Windows.Forms.Label();
            this.txtEvent1 = new System.Windows.Forms.TextBox();
            this.lblEvent1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEvent4 = new System.Windows.Forms.Label();
            this.txtEvent4 = new System.Windows.Forms.TextBox();
            this.lblEvent5 = new System.Windows.Forms.Label();
            this.txtEvent5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(555, 394);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 32);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.btnEventDelete.FlatAppearance.BorderSize = 0;
            this.btnEventDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventDelete.ForeColor = System.Drawing.Color.White;
            this.btnEventDelete.Location = new System.Drawing.Point(454, 394);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(95, 32);
            this.btnEventDelete.TabIndex = 26;
            this.btnEventDelete.Text = "Delete";
            this.btnEventDelete.UseVisualStyleBackColor = false;
            this.btnEventDelete.Click += new System.EventHandler(this.btnEventDelete_Click);
            // 
            // btnEventUpdate
            // 
            this.btnEventUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.btnEventUpdate.FlatAppearance.BorderSize = 0;
            this.btnEventUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventUpdate.ForeColor = System.Drawing.Color.White;
            this.btnEventUpdate.Location = new System.Drawing.Point(353, 394);
            this.btnEventUpdate.Name = "btnEventUpdate";
            this.btnEventUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnEventUpdate.TabIndex = 25;
            this.btnEventUpdate.Text = "Update";
            this.btnEventUpdate.UseVisualStyleBackColor = false;
            this.btnEventUpdate.Click += new System.EventHandler(this.btnEventUpdate_Click);
            // 
            // btnEventReset
            // 
            this.btnEventReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.btnEventReset.FlatAppearance.BorderSize = 0;
            this.btnEventReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventReset.ForeColor = System.Drawing.Color.White;
            this.btnEventReset.Location = new System.Drawing.Point(153, 505);
            this.btnEventReset.Name = "btnEventReset";
            this.btnEventReset.Size = new System.Drawing.Size(95, 32);
            this.btnEventReset.TabIndex = 24;
            this.btnEventReset.Text = "Reset";
            this.btnEventReset.UseVisualStyleBackColor = false;
            this.btnEventReset.Click += new System.EventHandler(this.btnEventReset_Click);
            // 
            // btnEventAdd
            // 
            this.btnEventAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(203)))), ((int)(((byte)(174)))));
            this.btnEventAdd.FlatAppearance.BorderSize = 0;
            this.btnEventAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventAdd.ForeColor = System.Drawing.Color.White;
            this.btnEventAdd.Location = new System.Drawing.Point(28, 505);
            this.btnEventAdd.Name = "btnEventAdd";
            this.btnEventAdd.Size = new System.Drawing.Size(95, 32);
            this.btnEventAdd.TabIndex = 23;
            this.btnEventAdd.Text = "Add";
            this.btnEventAdd.UseVisualStyleBackColor = false;
            this.btnEventAdd.Click += new System.EventHandler(this.btnEventAdd_Click);
            // 
            // gvEventList
            // 
            this.gvEventList.AllowUserToAddRows = false;
            this.gvEventList.AllowUserToDeleteRows = false;
            this.gvEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEventList.Location = new System.Drawing.Point(352, 157);
            this.gvEventList.Name = "gvEventList";
            this.gvEventList.ReadOnly = true;
            this.gvEventList.Size = new System.Drawing.Size(543, 231);
            this.gvEventList.TabIndex = 22;
            this.gvEventList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEventList_CellDoubleClick);
            this.gvEventList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvEventList_MouseClick);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(21, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(312, 37);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Create Tournament";
            // 
            // txtEvent3
            // 
            this.txtEvent3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent3.Location = new System.Drawing.Point(28, 329);
            this.txtEvent3.Name = "txtEvent3";
            this.txtEvent3.Size = new System.Drawing.Size(220, 29);
            this.txtEvent3.TabIndex = 34;
            this.txtEvent3.TextChanged += new System.EventHandler(this.txtEvent3_TextChanged);
            // 
            // lblEvent3
            // 
            this.lblEvent3.AutoSize = true;
            this.lblEvent3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent3.ForeColor = System.Drawing.Color.White;
            this.lblEvent3.Location = new System.Drawing.Point(24, 305);
            this.lblEvent3.Name = "lblEvent3";
            this.lblEvent3.Size = new System.Drawing.Size(62, 21);
            this.lblEvent3.TabIndex = 30;
            this.lblEvent3.Text = "Event3";
            // 
            // txtEvent2
            // 
            this.txtEvent2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent2.Location = new System.Drawing.Point(28, 268);
            this.txtEvent2.Name = "txtEvent2";
            this.txtEvent2.Size = new System.Drawing.Size(220, 29);
            this.txtEvent2.TabIndex = 35;
            this.txtEvent2.TextChanged += new System.EventHandler(this.txtEvent2_TextChanged);
            // 
            // lblEvent2
            // 
            this.lblEvent2.AutoSize = true;
            this.lblEvent2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent2.ForeColor = System.Drawing.Color.White;
            this.lblEvent2.Location = new System.Drawing.Point(24, 244);
            this.lblEvent2.Name = "lblEvent2";
            this.lblEvent2.Size = new System.Drawing.Size(62, 21);
            this.lblEvent2.TabIndex = 31;
            this.lblEvent2.Text = "Event2";
            // 
            // txtEvent1
            // 
            this.txtEvent1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent1.Location = new System.Drawing.Point(28, 205);
            this.txtEvent1.Name = "txtEvent1";
            this.txtEvent1.Size = new System.Drawing.Size(220, 29);
            this.txtEvent1.TabIndex = 36;
            this.txtEvent1.TextChanged += new System.EventHandler(this.txtEvent1_TextChanged);
            // 
            // lblEvent1
            // 
            this.lblEvent1.AutoSize = true;
            this.lblEvent1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent1.ForeColor = System.Drawing.Color.White;
            this.lblEvent1.Location = new System.Drawing.Point(24, 181);
            this.lblEvent1.Name = "lblEvent1";
            this.lblEvent1.Size = new System.Drawing.Size(62, 21);
            this.lblEvent1.TabIndex = 32;
            this.lblEvent1.Text = "Event1";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(28, 146);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(220, 29);
            this.txtTitle.TabIndex = 37;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 122);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 21);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Title";
            // 
            // lblEvent4
            // 
            this.lblEvent4.AutoSize = true;
            this.lblEvent4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent4.ForeColor = System.Drawing.Color.White;
            this.lblEvent4.Location = new System.Drawing.Point(24, 367);
            this.lblEvent4.Name = "lblEvent4";
            this.lblEvent4.Size = new System.Drawing.Size(62, 21);
            this.lblEvent4.TabIndex = 30;
            this.lblEvent4.Text = "Event4";
            // 
            // txtEvent4
            // 
            this.txtEvent4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent4.Location = new System.Drawing.Point(28, 391);
            this.txtEvent4.Name = "txtEvent4";
            this.txtEvent4.Size = new System.Drawing.Size(220, 29);
            this.txtEvent4.TabIndex = 34;
            this.txtEvent4.TextChanged += new System.EventHandler(this.txtEvent4_TextChanged);
            // 
            // lblEvent5
            // 
            this.lblEvent5.AutoSize = true;
            this.lblEvent5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent5.ForeColor = System.Drawing.Color.White;
            this.lblEvent5.Location = new System.Drawing.Point(24, 426);
            this.lblEvent5.Name = "lblEvent5";
            this.lblEvent5.Size = new System.Drawing.Size(62, 21);
            this.lblEvent5.TabIndex = 30;
            this.lblEvent5.Text = "Event5";
            // 
            // txtEvent5
            // 
            this.txtEvent5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent5.Location = new System.Drawing.Point(28, 450);
            this.txtEvent5.Name = "txtEvent5";
            this.txtEvent5.Size = new System.Drawing.Size(220, 29);
            this.txtEvent5.TabIndex = 34;
            this.txtEvent5.TextChanged += new System.EventHandler(this.txtEvent5_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, -196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1341, 573);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1042, 635);
            this.Controls.Add(this.txtEvent5);
            this.Controls.Add(this.lblEvent5);
            this.Controls.Add(this.txtEvent4);
            this.Controls.Add(this.lblEvent4);
            this.Controls.Add(this.txtEvent3);
            this.Controls.Add(this.lblEvent3);
            this.Controls.Add(this.txtEvent2);
            this.Controls.Add(this.lblEvent2);
            this.Controls.Add(this.txtEvent1);
            this.Controls.Add(this.lblEvent1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEventDelete);
            this.Controls.Add(this.btnEventUpdate);
            this.Controls.Add(this.btnEventReset);
            this.Controls.Add(this.btnEventAdd);
            this.Controls.Add(this.gvEventList);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tournament";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEventList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEventDelete;
        private System.Windows.Forms.Button btnEventUpdate;
        private System.Windows.Forms.Button btnEventReset;
        private System.Windows.Forms.Button btnEventAdd;
        private System.Windows.Forms.DataGridView gvEventList;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtEvent3;
        private System.Windows.Forms.Label lblEvent3;
        private System.Windows.Forms.TextBox txtEvent2;
        private System.Windows.Forms.Label lblEvent2;
        private System.Windows.Forms.TextBox txtEvent1;
        private System.Windows.Forms.Label lblEvent1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEvent4;
        private System.Windows.Forms.TextBox txtEvent4;
        private System.Windows.Forms.Label lblEvent5;
        private System.Windows.Forms.TextBox txtEvent5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}