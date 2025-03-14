namespace Banxico
{
    partial class Form3
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dgvData = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnShow = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(103, 43);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(124, 23);
            dtpStartDate.TabIndex = 0;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(99, 86);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(128, 23);
            dtpEndDate.TabIndex = 1;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 43);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Start date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 86);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "End date";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(49, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 142);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvData.Location = new Point(348, 68);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(297, 231);
            dgvData.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Date";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Dollar prize";
            Column2.Name = "Column2";
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(136, 268);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(88, 31);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 354);
            Controls.Add(btnShow);
            Controls.Add(dgvData);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dgvData;
        private Button btnShow;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}