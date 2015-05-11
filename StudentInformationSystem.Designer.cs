namespace StudentInformationSystem
{
    partial class studentInformationSystem
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
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.studentRollNoTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.motherNameTextBox = new System.Windows.Forms.TextBox();
            this.instituteNameTextBox = new System.Windows.Forms.TextBox();
            this.sscResultTextBox = new System.Windows.Forms.TextBox();
            this.sessionTextBox = new System.Windows.Forms.TextBox();
            this.studentInformationDataGridView = new System.Windows.Forms.DataGridView();
            this.studentRollNoData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherNameData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instituteNameData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sscResultData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(35, 330);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 32);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.showButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(162, 330);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 32);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            this.showButton.MouseEnter += new System.EventHandler(this.showButton_MouseEnter);
            this.showButton.MouseLeave += new System.EventHandler(this.showButton_MouseLeave);
            this.showButton.MouseHover += new System.EventHandler(this.showButton_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Roll No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Father Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mother Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Institute Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "S.S.C Result:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Session:";
            // 
            // studentRollNoTextBox
            // 
            this.studentRollNoTextBox.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRollNoTextBox.Location = new System.Drawing.Point(137, 48);
            this.studentRollNoTextBox.Name = "studentRollNoTextBox";
            this.studentRollNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentRollNoTextBox.TabIndex = 0;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTextBox.Location = new System.Drawing.Point(137, 87);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNameTextBox.TabIndex = 1;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherNameTextBox.Location = new System.Drawing.Point(137, 126);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatherNameTextBox.TabIndex = 2;
            // 
            // motherNameTextBox
            // 
            this.motherNameTextBox.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherNameTextBox.Location = new System.Drawing.Point(137, 164);
            this.motherNameTextBox.Name = "motherNameTextBox";
            this.motherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.motherNameTextBox.TabIndex = 3;
            // 
            // instituteNameTextBox
            // 
            this.instituteNameTextBox.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instituteNameTextBox.Location = new System.Drawing.Point(137, 203);
            this.instituteNameTextBox.Name = "instituteNameTextBox";
            this.instituteNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.instituteNameTextBox.TabIndex = 4;
            // 
            // sscResultTextBox
            // 
            this.sscResultTextBox.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sscResultTextBox.Location = new System.Drawing.Point(137, 243);
            this.sscResultTextBox.Name = "sscResultTextBox";
            this.sscResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.sscResultTextBox.TabIndex = 5;
            // 
            // sessionTextBox
            // 
            this.sessionTextBox.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionTextBox.Location = new System.Drawing.Point(137, 276);
            this.sessionTextBox.Name = "sessionTextBox";
            this.sessionTextBox.Size = new System.Drawing.Size(100, 20);
            this.sessionTextBox.TabIndex = 6;
            // 
            // studentInformationDataGridView
            // 
            this.studentInformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInformationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentRollNoData,
            this.studentNameData,
            this.fatherNameData,
            this.motherNameData,
            this.instituteNameData,
            this.sscResultData,
            this.sessionData});
            this.studentInformationDataGridView.Location = new System.Drawing.Point(259, 48);
            this.studentInformationDataGridView.Name = "studentInformationDataGridView";
            this.studentInformationDataGridView.Size = new System.Drawing.Size(746, 314);
            this.studentInformationDataGridView.TabIndex = 9;
            // 
            // studentRollNoData
            // 
            this.studentRollNoData.HeaderText = "Student Roll No";
            this.studentRollNoData.Name = "studentRollNoData";
            // 
            // studentNameData
            // 
            this.studentNameData.HeaderText = "StudentName";
            this.studentNameData.Name = "studentNameData";
            // 
            // fatherNameData
            // 
            this.fatherNameData.HeaderText = "Father Name";
            this.fatherNameData.Name = "fatherNameData";
            // 
            // motherNameData
            // 
            this.motherNameData.HeaderText = "Mother Name";
            this.motherNameData.Name = "motherNameData";
            // 
            // instituteNameData
            // 
            this.instituteNameData.HeaderText = "Institute Name";
            this.instituteNameData.Name = "instituteNameData";
            // 
            // sscResultData
            // 
            this.sscResultData.HeaderText = "SSC Result";
            this.sscResultData.Name = "sscResultData";
            // 
            // sessionData
            // 
            this.sessionData.HeaderText = "Session";
            this.sessionData.Name = "sessionData";
            // 
            // studentInformationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1017, 410);
            this.Controls.Add(this.studentInformationDataGridView);
            this.Controls.Add(this.sessionTextBox);
            this.Controls.Add(this.sscResultTextBox);
            this.Controls.Add(this.instituteNameTextBox);
            this.Controls.Add(this.motherNameTextBox);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentRollNoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "studentInformationSystem";
            this.Text = "Student Information System";
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentRollNoTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox motherNameTextBox;
        private System.Windows.Forms.TextBox instituteNameTextBox;
        private System.Windows.Forms.TextBox sscResultTextBox;
        private System.Windows.Forms.TextBox sessionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView studentInformationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRollNoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameData;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameData;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherNameData;
        private System.Windows.Forms.DataGridViewTextBoxColumn instituteNameData;
        private System.Windows.Forms.DataGridViewTextBoxColumn sscResultData;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionData;
    }
}

