namespace Banxico
{
    partial class automobile
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
            dgvCars = new DataGridView();
            btnOpen = new Button();
            cmbCars = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(218, 23);
            dgvCars.Name = "dgvCars";
            dgvCars.Size = new Size(486, 309);
            dgvCars.TabIndex = 0;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(87, 51);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(87, 31);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // cmbCars
            // 
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(71, 100);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(121, 23);
            cmbCars.TabIndex = 2;
            cmbCars.SelectedIndexChanged += cmbCars_SelectedIndexChanged;
            // 
            // automobile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 355);
            Controls.Add(cmbCars);
            Controls.Add(btnOpen);
            Controls.Add(dgvCars);
            Name = "automobile";
            Text = "automobile";
            Load += automobile_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCars;
        private Button btnOpen;
        private ComboBox cmbCars;
    }
}