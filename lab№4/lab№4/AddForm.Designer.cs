namespace lab_4
{
    partial class AddForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblShooting = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtShooting = new System.Windows.Forms.TextBox();
            this.txtPenaltyLaps = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(37, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(37, 131);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 20);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(37, 170);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 20);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country:";
            // 
            // lblShooting
            // 
            this.lblShooting.AutoSize = true;
            this.lblShooting.Location = new System.Drawing.Point(37, 215);
            this.lblShooting.Name = "lblShooting";
            this.lblShooting.Size = new System.Drawing.Size(69, 20);
            this.lblShooting.TabIndex = 4;
            this.lblShooting.Text = "Shooting";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Location = new System.Drawing.Point(37, 247);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(90, 20);
            this.lblPenalty.TabIndex = 5;
            this.lblPenalty.Text = "Penalty laps:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 27);
            this.txtId.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(172, 124);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(125, 27);
            this.txtGender.TabIndex = 8;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(172, 163);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(125, 27);
            this.txtCounty.TabIndex = 9;
            // 
            // txtShooting
            // 
            this.txtShooting.Location = new System.Drawing.Point(172, 207);
            this.txtShooting.Name = "txtShooting";
            this.txtShooting.Size = new System.Drawing.Size(125, 27);
            this.txtShooting.TabIndex = 10;
            // 
            // txtPenaltyLaps
            // 
            this.txtPenaltyLaps.Location = new System.Drawing.Point(172, 240);
            this.txtPenaltyLaps.Name = "txtPenaltyLaps";
            this.txtPenaltyLaps.Size = new System.Drawing.Size(125, 27);
            this.txtPenaltyLaps.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(116, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 46);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPenaltyLaps);
            this.Controls.Add(this.txtShooting);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPenalty);
            this.Controls.Add(this.lblShooting);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "AddForm";
            this.Text = "Add Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblGender;
        private Label lblCountry;
        private Label lblShooting;
        private Label lblPenalty;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtGender;
        private TextBox txtCounty;
        private TextBox txtShooting;
        private TextBox txtPenaltyLaps;
        private Button btnAdd;
    }
}