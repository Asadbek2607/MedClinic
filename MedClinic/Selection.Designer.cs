
namespace MedClinic
{
    partial class Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.copyright = new System.Windows.Forms.Label();
            this.pictureBoxNurse = new System.Windows.Forms.PictureBox();
            this.labelNurse = new System.Windows.Forms.Label();
            this.pictureBoxPat = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNurse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to MedClinic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.copyright);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 40);
            this.panel2.TabIndex = 3;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.White;
            this.copyright.Location = new System.Drawing.Point(138, 15);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(208, 16);
            this.copyright.TabIndex = 3;
            this.copyright.Text = "Copyright © 2021  | All Rights Reserved";
            // 
            // pictureBoxNurse
            // 
            this.pictureBoxNurse.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNurse.Image")));
            this.pictureBoxNurse.Location = new System.Drawing.Point(38, 98);
            this.pictureBoxNurse.Name = "pictureBoxNurse";
            this.pictureBoxNurse.Size = new System.Drawing.Size(106, 90);
            this.pictureBoxNurse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNurse.TabIndex = 3;
            this.pictureBoxNurse.TabStop = false;
            this.pictureBoxNurse.Click += new System.EventHandler(this.pictureBoxNurse_Click);
            // 
            // labelNurse
            // 
            this.labelNurse.AutoSize = true;
            this.labelNurse.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNurse.ForeColor = System.Drawing.Color.Brown;
            this.labelNurse.Location = new System.Drawing.Point(43, 191);
            this.labelNurse.Name = "labelNurse";
            this.labelNurse.Size = new System.Drawing.Size(92, 37);
            this.labelNurse.TabIndex = 3;
            this.labelNurse.Text = "Nurse";
            this.labelNurse.Click += new System.EventHandler(this.labelNurse_Click);
            // 
            // pictureBoxPat
            // 
            this.pictureBoxPat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPat.Image")));
            this.pictureBoxPat.Location = new System.Drawing.Point(185, 98);
            this.pictureBoxPat.Name = "pictureBoxPat";
            this.pictureBoxPat.Size = new System.Drawing.Size(106, 90);
            this.pictureBoxPat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPat.TabIndex = 4;
            this.pictureBoxPat.TabStop = false;
            this.pictureBoxPat.Click += new System.EventHandler(this.pictureBoxPat_Click);
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdmin.Image")));
            this.pictureBoxAdmin.Location = new System.Drawing.Point(335, 98);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(106, 90);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdmin.TabIndex = 5;
            this.pictureBoxAdmin.TabStop = false;
            this.pictureBoxAdmin.Click += new System.EventHandler(this.pictureBoxAdmin_Click);
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatient.ForeColor = System.Drawing.Color.Orange;
            this.labelPatient.Location = new System.Drawing.Point(182, 191);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(109, 37);
            this.labelPatient.TabIndex = 6;
            this.labelPatient.Text = "Patient";
            this.labelPatient.Click += new System.EventHandler(this.labelPatient_Click);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.Navy;
            this.labelAdmin.Location = new System.Drawing.Point(339, 191);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(102, 37);
            this.labelAdmin.TabIndex = 7;
            this.labelAdmin.Text = "Admin";
            this.labelAdmin.Click += new System.EventHandler(this.labelAdmin_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 306);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.pictureBoxAdmin);
            this.Controls.Add(this.pictureBoxPat);
            this.Controls.Add(this.labelNurse);
            this.Controls.Add(this.pictureBoxNurse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNurse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxNurse;
        private System.Windows.Forms.Label labelNurse;
        private System.Windows.Forms.PictureBox pictureBoxPat;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label copyright;
    }
}