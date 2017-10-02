namespace PeopleManagementStation.UI
{
    partial class LandingUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingUI));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.salaryButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.gradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(284, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "People Management Station";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(401, -47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kyoto Engineering And Automation Ltd.";
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.LightCyan;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reportButton.Location = new System.Drawing.Point(197, 191);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(180, 62);
            this.reportButton.TabIndex = 20;
            this.reportButton.Text = "Perquisite Management";
            this.reportButton.UseVisualStyleBackColor = false;
            // 
            // salaryButton
            // 
            this.salaryButton.BackColor = System.Drawing.Color.LightCyan;
            this.salaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.salaryButton.Location = new System.Drawing.Point(601, 102);
            this.salaryButton.Margin = new System.Windows.Forms.Padding(4);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(180, 58);
            this.salaryButton.TabIndex = 17;
            this.salaryButton.Text = "Grade Assignment";
            this.salaryButton.UseVisualStyleBackColor = false;
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.Color.LightCyan;
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeButton.Location = new System.Drawing.Point(197, 102);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(180, 58);
            this.employeeButton.TabIndex = 18;
            this.employeeButton.Text = "Grade Management";
            this.employeeButton.UseVisualStyleBackColor = false;
            // 
            // gradeButton
            // 
            this.gradeButton.BackColor = System.Drawing.Color.LightCyan;
            this.gradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gradeButton.Location = new System.Drawing.Point(601, 202);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(180, 62);
            this.gradeButton.TabIndex = 19;
            this.gradeButton.Text = "People Management";
            this.gradeButton.UseVisualStyleBackColor = false;
            // 
            // LandingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(909, 517);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.salaryButton);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LandingUI";
            this.Text = "LandingUI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button salaryButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button gradeButton;
    }
}