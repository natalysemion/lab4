namespace lab_4
{
    partial class lab4MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAnsSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Add = new System.Windows.Forms.Button();
            this.checkGender = new System.Windows.Forms.CheckBox();
            this.txtCheckGender = new System.Windows.Forms.TextBox();
            this.checkCountry = new System.Windows.Forms.CheckBox();
            this.checkPenaltyLaps = new System.Windows.Forms.CheckBox();
            this.txtCheckCountry = new System.Windows.Forms.TextBox();
            this.txtCheckPenaltyLaps = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(638, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.createNewAnsSaveToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // createNewAnsSaveToolStripMenuItem
            // 
            this.createNewAnsSaveToolStripMenuItem.Name = "createNewAnsSaveToolStripMenuItem";
            this.createNewAnsSaveToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.createNewAnsSaveToolStripMenuItem.Text = "Create new ans save";
            this.createNewAnsSaveToolStripMenuItem.Click += new System.EventHandler(this.createNewAnsSaveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(676, 55);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 29);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // checkGender
            // 
            this.checkGender.AutoSize = true;
            this.checkGender.Location = new System.Drawing.Point(28, 370);
            this.checkGender.Name = "checkGender";
            this.checkGender.Size = new System.Drawing.Size(79, 24);
            this.checkGender.TabIndex = 3;
            this.checkGender.Text = "Gender";
            this.checkGender.UseVisualStyleBackColor = true;
            // 
            // txtCheckGender
            // 
            this.txtCheckGender.Location = new System.Drawing.Point(28, 398);
            this.txtCheckGender.Name = "txtCheckGender";
            this.txtCheckGender.Size = new System.Drawing.Size(125, 27);
            this.txtCheckGender.TabIndex = 4;
            // 
            // checkCountry
            // 
            this.checkCountry.AutoSize = true;
            this.checkCountry.Location = new System.Drawing.Point(204, 370);
            this.checkCountry.Name = "checkCountry";
            this.checkCountry.Size = new System.Drawing.Size(82, 24);
            this.checkCountry.TabIndex = 5;
            this.checkCountry.Text = "Country";
            this.checkCountry.UseVisualStyleBackColor = true;
            // 
            // checkPenaltyLaps
            // 
            this.checkPenaltyLaps.AutoSize = true;
            this.checkPenaltyLaps.Location = new System.Drawing.Point(388, 370);
            this.checkPenaltyLaps.Name = "checkPenaltyLaps";
            this.checkPenaltyLaps.Size = new System.Drawing.Size(112, 24);
            this.checkPenaltyLaps.TabIndex = 6;
            this.checkPenaltyLaps.Text = "Penalty Laps";
            this.checkPenaltyLaps.UseVisualStyleBackColor = true;
            // 
            // txtCheckCountry
            // 
            this.txtCheckCountry.Location = new System.Drawing.Point(204, 398);
            this.txtCheckCountry.Name = "txtCheckCountry";
            this.txtCheckCountry.Size = new System.Drawing.Size(125, 27);
            this.txtCheckCountry.TabIndex = 7;
            // 
            // txtCheckPenaltyLaps
            // 
            this.txtCheckPenaltyLaps.Location = new System.Drawing.Point(388, 398);
            this.txtCheckPenaltyLaps.Name = "txtCheckPenaltyLaps";
            this.txtCheckPenaltyLaps.Size = new System.Drawing.Size(125, 27);
            this.txtCheckPenaltyLaps.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(546, 379);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 46);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(676, 289);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(94, 29);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "About ";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(676, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(676, 133);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(94, 29);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lab4MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCheckPenaltyLaps);
            this.Controls.Add(this.txtCheckCountry);
            this.Controls.Add(this.checkPenaltyLaps);
            this.Controls.Add(this.checkCountry);
            this.Controls.Add(this.txtCheckGender);
            this.Controls.Add(this.checkGender);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "lab4MainForm";
            this.Text = "lab4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        //private ToolStripMenuItem fileToolStripMenuItem;
       // private ToolStripMenuItem saveToolStripMenuItem;
       // private ToolStripMenuItem createNewAndSaveToolStripMenuItem;
        //private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btn_Add;
        private CheckBox checkGender;
        private TextBox txtCheckGender;
        private CheckBox checkCountry;
        private CheckBox checkPenaltyLaps;
        private TextBox txtCheckCountry;
        private TextBox txtCheckPenaltyLaps;
        private Button btnSearch;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem createNewAnsSaveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btnAbout;
        private Button btnDelete;
        private Button btnChange;
    }
}