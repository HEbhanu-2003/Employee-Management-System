namespace Employee_Management_System_3
{
    partial class Home
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DashBoard = new System.Windows.Forms.PictureBox();
            this.Employee = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(476, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1306, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dashboard";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(851, 910);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashBoard
            // 
            this.DashBoard.BackgroundImage = global::Employee_Management_System_3.Properties.Resources.Dashboard;
            this.DashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashBoard.Location = new System.Drawing.Point(1199, 203);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Size = new System.Drawing.Size(406, 381);
            this.DashBoard.TabIndex = 2;
            this.DashBoard.TabStop = false;
            this.DashBoard.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Employee
            // 
            this.Employee.BackgroundImage = global::Employee_Management_System_3.Properties.Resources.Employee;
            this.Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Employee.Location = new System.Drawing.Point(370, 203);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(406, 381);
            this.Employee.TabIndex = 1;
            this.Employee.TabStop = false;
            this.Employee.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1946, 98);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(887, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DashBoard);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Employee;
        private System.Windows.Forms.PictureBox DashBoard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}