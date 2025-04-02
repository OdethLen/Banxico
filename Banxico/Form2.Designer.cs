namespace Banxico
{
    partial class Form2
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
            btnExit = new Button();
            btnData = new Button();
            btnGraphic = new Button();
            btnCarGrpahic = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Yu Gothic UI", 9.75F);
            btnExit.Location = new Point(140, 75);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 35);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnData
            // 
            btnData.Font = new Font("Yu Gothic UI", 9.75F);
            btnData.Location = new Point(140, 130);
            btnData.Name = "btnData";
            btnData.Size = new Size(119, 35);
            btnData.TabIndex = 1;
            btnData.Text = "Data";
            btnData.UseVisualStyleBackColor = true;
            btnData.Click += btnData_Click;
            // 
            // btnGraphic
            // 
            btnGraphic.Font = new Font("Yu Gothic UI", 9.75F);
            btnGraphic.Location = new Point(140, 190);
            btnGraphic.Name = "btnGraphic";
            btnGraphic.Size = new Size(119, 35);
            btnGraphic.TabIndex = 2;
            btnGraphic.Text = "Graphic";
            btnGraphic.UseVisualStyleBackColor = true;
            btnGraphic.Click += btnGraphic_Click;
            // 
            // btnCarGrpahic
            // 
            btnCarGrpahic.Font = new Font("Yu Gothic UI", 9.75F);
            btnCarGrpahic.Location = new Point(317, 75);
            btnCarGrpahic.Name = "btnCarGrpahic";
            btnCarGrpahic.Size = new Size(119, 35);
            btnCarGrpahic.TabIndex = 3;
            btnCarGrpahic.Text = "Car Graphic";
            btnCarGrpahic.UseVisualStyleBackColor = true;
            btnCarGrpahic.Click += btnCarGrpahic_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 326);
            Controls.Add(btnCarGrpahic);
            Controls.Add(btnGraphic);
            Controls.Add(btnData);
            Controls.Add(btnExit);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnData;
        private Button btnGraphic;
        private Button btnCarGrpahic;
    }
}