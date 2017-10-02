namespace PeopleManagementStation.UI
{
    partial class GradeManagementUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeManagementUI));
            this.label4 = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.salaryButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.gradeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(249, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "Grade Management";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.LightCyan;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reportButton.Location = new System.Drawing.Point(298, 324);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(180, 62);
            this.reportButton.TabIndex = 21;
            this.reportButton.Text = "Grade Deletion";
            this.reportButton.UseVisualStyleBackColor = false;
            // 
            // salaryButton
            // 
            this.salaryButton.BackColor = System.Drawing.Color.LightCyan;
            this.salaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.salaryButton.Location = new System.Drawing.Point(298, 162);
            this.salaryButton.Margin = new System.Windows.Forms.Padding(4);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(180, 58);
            this.salaryButton.TabIndex = 18;
            this.salaryButton.Text = "Grade Creation";
            this.salaryButton.UseVisualStyleBackColor = false;
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.Color.LightCyan;
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeButton.Location = new System.Drawing.Point(298, 86);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(180, 54);
            this.employeeButton.TabIndex = 19;
            this.employeeButton.Text = "Grade Type Creation";
            this.employeeButton.UseVisualStyleBackColor = false;
            // 
            // gradeButton
            // 
            this.gradeButton.BackColor = System.Drawing.Color.LightCyan;
            this.gradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gradeButton.Location = new System.Drawing.Point(298, 242);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(180, 62);
            this.gradeButton.TabIndex = 20;
            this.gradeButton.Text = "Grade Amendment";
            this.gradeButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(298, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 62);
            this.button1.TabIndex = 22;
            this.button1.Text = "Grade Report";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // GradeManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.salaryButton);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GradeManagementUI";
            this.Text = "Grade_ManagementUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button salaryButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Button button1;
    }
}