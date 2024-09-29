namespace webassignment4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "S.name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Roll No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StudentRecordDataGridView
            // 
            this.StudentRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecordDataGridView.Location = new System.Drawing.Point(23, 413);
            this.StudentRecordDataGridView.Name = "StudentRecordDataGridView";
            this.StudentRecordDataGridView.RowHeadersWidth = 102;
            this.StudentRecordDataGridView.RowTemplate.Height = 40;
            this.StudentRecordDataGridView.Size = new System.Drawing.Size(928, 309);
            this.StudentRecordDataGridView.TabIndex = 3;
            this.StudentRecordDataGridView.Tag = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(234, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(487, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 75);
            this.button3.TabIndex = 1;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(715, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 75);
            this.button4.TabIndex = 1;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "F Name";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mobile";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(195, 27);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(259, 38);
            this.txtStudentName.TabIndex = 4;
            this.txtStudentName.Tag = "";
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.Location = new System.Drawing.Point(195, 102);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(245, 38);
            this.txtRollNumber.TabIndex = 4;
            this.txtRollNumber.Tag = "";
            this.txtRollNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(715, 29);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(260, 38);
            this.txtFatherName.TabIndex = 4;
            this.txtFatherName.Tag = "";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(715, 104);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(260, 38);
            this.txtMobile.TabIndex = 4;
            this.txtMobile.Tag = "";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(195, 178);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(245, 38);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1005, 764);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtRollNumber);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.StudentRecordDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView StudentRecordDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
    }
}

