namespace ADO2EFcore
{
    partial class Form1
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
            btnSave = new Button();
            cbSpecialization = new ComboBox();
            btnPrev = new Button();
            btnNext = new Button();
            lblTitle = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblDoctorID = new Label();
            label1 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(111, 356);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 36);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbSpecialization
            // 
            cbSpecialization.FormattingEnabled = true;
            cbSpecialization.Location = new Point(31, 214);
            cbSpecialization.Name = "cbSpecialization";
            cbSpecialization.Size = new Size(264, 23);
            cbSpecialization.TabIndex = 18;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(40, 295);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(115, 36);
            btnPrev.TabIndex = 17;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(180, 295);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(115, 36);
            btnNext.TabIndex = 16;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(322, 65);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Doctors Data";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lblDoctorID
            // 
            lblDoctorID.AutoSize = true;
            lblDoctorID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoctorID.ForeColor = Color.Goldenrod;
            lblDoctorID.Location = new Point(187, 84);
            lblDoctorID.Name = "lblDoctorID";
            lblDoctorID.Size = new Size(50, 21);
            lblDoctorID.TabIndex = 22;
            lblDoctorID.Text = "[????]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(90, 85);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 23;
            label1.Text = "Doctor ID :";
            // 
            // txtName
            // 
            txtName.Location = new Point(37, 139);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 23);
            txtName.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 457);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(lblDoctorID);
            Controls.Add(btnSave);
            Controls.Add(cbSpecialization);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private ComboBox cbSpecialization;
        private Button btnPrev;
        private Button btnNext;
        private Label lblTitle;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblDoctorID;
        private Label label1;
        private TextBox txtName;
    }
}
