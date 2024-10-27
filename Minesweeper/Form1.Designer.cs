namespace Minesweeper
{
    partial class frmMinesweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMinesweeper));
            this.pctOfMines = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBegginer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIntermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExpert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBestTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMines = new System.Windows.Forms.Label();
            this.pctHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctOfMines)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHead)).BeginInit();
            this.SuspendLayout();
            // 
            // pctOfMines
            // 
            this.pctOfMines.BackColor = System.Drawing.SystemColors.Control;
            this.pctOfMines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctOfMines.Location = new System.Drawing.Point(11, 18);
            this.pctOfMines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctOfMines.Name = "pctOfMines";
            this.pctOfMines.Size = new System.Drawing.Size(307, 147);
            this.pctOfMines.TabIndex = 1;
            this.pctOfMines.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGame,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuGame
            // 
            this.mnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnu1,
            this.mnuBegginer,
            this.mnuIntermediate,
            this.mnuExpert,
            this.mnuCustom,
            this.mnu2,
            this.mnuBestTime,
            this.mnu4,
            this.mnuExit});
            this.mnuGame.Name = "mnuGame";
            this.mnuGame.Size = new System.Drawing.Size(62, 24);
            this.mnuGame.Text = "Game";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(177, 26);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnu1
            // 
            this.mnu1.Name = "mnu1";
            this.mnu1.Size = new System.Drawing.Size(174, 6);
            // 
            // mnuBegginer
            // 
            this.mnuBegginer.Name = "mnuBegginer";
            this.mnuBegginer.Size = new System.Drawing.Size(177, 26);
            this.mnuBegginer.Text = "Begginer";
            this.mnuBegginer.Click += new System.EventHandler(this.mnuBegginer_Click);
            // 
            // mnuIntermediate
            // 
            this.mnuIntermediate.Name = "mnuIntermediate";
            this.mnuIntermediate.Size = new System.Drawing.Size(177, 26);
            this.mnuIntermediate.Text = "Intermediate";
            this.mnuIntermediate.Click += new System.EventHandler(this.mnuIntermediate_Click);
            // 
            // mnuExpert
            // 
            this.mnuExpert.Name = "mnuExpert";
            this.mnuExpert.Size = new System.Drawing.Size(177, 26);
            this.mnuExpert.Text = "Expert";
            this.mnuExpert.Click += new System.EventHandler(this.mnuExpert_Click);
            // 
            // mnuCustom
            // 
            this.mnuCustom.Name = "mnuCustom";
            this.mnuCustom.Size = new System.Drawing.Size(177, 26);
            this.mnuCustom.Text = "Custom";
            this.mnuCustom.Click += new System.EventHandler(this.mnuCustom_Click);
            // 
            // mnu2
            // 
            this.mnu2.Name = "mnu2";
            this.mnu2.Size = new System.Drawing.Size(174, 6);
            // 
            // mnuBestTime
            // 
            this.mnuBestTime.Name = "mnuBestTime";
            this.mnuBestTime.Size = new System.Drawing.Size(177, 26);
            this.mnuBestTime.Text = "Best time";
            this.mnuBestTime.Click += new System.EventHandler(this.mnuBestTime_Click);
            // 
            // mnu4
            // 
            this.mnu4.Name = "mnu4";
            this.mnu4.Size = new System.Drawing.Size(174, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(177, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.pctOfMines);
            this.groupBox1.Location = new System.Drawing.Point(31, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(331, 175);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.lblMines);
            this.groupBox2.Controls.Add(this.pctHead);
            this.groupBox2.Location = new System.Drawing.Point(31, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(331, 98);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(213, 39);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 29);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "label1";
            // 
            // lblMines
            // 
            this.lblMines.AutoSize = true;
            this.lblMines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMines.ForeColor = System.Drawing.Color.Red;
            this.lblMines.Location = new System.Drawing.Point(41, 39);
            this.lblMines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMines.Name = "lblMines";
            this.lblMines.Size = new System.Drawing.Size(85, 29);
            this.lblMines.TabIndex = 11;
            this.lblMines.Text = "label1";
            // 
            // pctHead
            // 
            this.pctHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pctHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctHead.Location = new System.Drawing.Point(8, 23);
            this.pctHead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctHead.Name = "pctHead";
            this.pctHead.Size = new System.Drawing.Size(307, 61);
            this.pctHead.TabIndex = 10;
            this.pctHead.TabStop = false;
            // 
            // frmMinesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(414, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMinesweeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.frmMinesweeper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctOfMines)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctOfMines;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuGame;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripSeparator mnu1;
        private System.Windows.Forms.ToolStripMenuItem mnuBegginer;
        private System.Windows.Forms.ToolStripMenuItem mnuIntermediate;
        private System.Windows.Forms.ToolStripMenuItem mnuExpert;
        private System.Windows.Forms.ToolStripMenuItem mnuCustom;
        private System.Windows.Forms.ToolStripSeparator mnu2;
        private System.Windows.Forms.ToolStripMenuItem mnuBestTime;
        private System.Windows.Forms.ToolStripSeparator mnu4;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblMines;
        private System.Windows.Forms.PictureBox pctHead;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}