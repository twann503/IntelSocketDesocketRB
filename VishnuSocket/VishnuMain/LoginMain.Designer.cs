﻿namespace VishnuMain
{
    partial class LoginMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMain));
            this.centralTab = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // centralTab
            // 
            this.centralTab.Location = new System.Drawing.Point(11, 10);
            this.centralTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.centralTab.Name = "centralTab";
            this.centralTab.SelectedIndex = 0;
            this.centralTab.Size = new System.Drawing.Size(1707, 864);
            this.centralTab.TabIndex = 0;
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1417, 692);
            this.Controls.Add(this.centralTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginMain";
            this.Text = "Vishnu 2017 0.4a";
            this.Load += new System.EventHandler(this.LoginMain_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl centralTab;
    }
}

