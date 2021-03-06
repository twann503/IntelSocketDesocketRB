﻿namespace VishnuMain
{
    partial class TemplateMatchView
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
            this.components = new System.ComponentModel.Container();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.template_imgbox = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.captured_imgbox = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tracked_imgbox = new Emgu.CV.UI.ImageBox();
            this.startCaptureButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.template_textbox = new System.Windows.Forms.TextBox();
            this.findMatch = new System.Windows.Forms.Button();
            this.loadTemplate = new System.Windows.Forms.Button();
            this.capturePicture = new System.Windows.Forms.Button();
            this.sourceimg_textbox = new System.Windows.Forms.TextBox();
            this.loadSource = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.template_imgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captured_imgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracked_imgbox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox4
            // 
            this.imageBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox4.Location = new System.Drawing.Point(25, 54);
            this.imageBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(640, 480);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox4.TabIndex = 3;
            this.imageBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Video Feed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 623);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Template Image";
            // 
            // template_imgbox
            // 
            this.template_imgbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.template_imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.template_imgbox.Location = new System.Drawing.Point(25, 648);
            this.template_imgbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.template_imgbox.Name = "template_imgbox";
            this.template_imgbox.Size = new System.Drawing.Size(640, 480);
            this.template_imgbox.TabIndex = 18;
            this.template_imgbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(997, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Captured Image";
            // 
            // captured_imgbox
            // 
            this.captured_imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captured_imgbox.Location = new System.Drawing.Point(1001, 54);
            this.captured_imgbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.captured_imgbox.Name = "captured_imgbox";
            this.captured_imgbox.Size = new System.Drawing.Size(640, 480);
            this.captured_imgbox.TabIndex = 20;
            this.captured_imgbox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(997, 612);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tracked Objects";
            // 
            // tracked_imgbox
            // 
            this.tracked_imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tracked_imgbox.Location = new System.Drawing.Point(1001, 648);
            this.tracked_imgbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tracked_imgbox.Name = "tracked_imgbox";
            this.tracked_imgbox.Size = new System.Drawing.Size(640, 480);
            this.tracked_imgbox.TabIndex = 22;
            this.tracked_imgbox.TabStop = false;
            // 
            // startCaptureButton
            // 
            this.startCaptureButton.Location = new System.Drawing.Point(40, 1249);
            this.startCaptureButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startCaptureButton.Name = "startCaptureButton";
            this.startCaptureButton.Size = new System.Drawing.Size(150, 35);
            this.startCaptureButton.TabIndex = 31;
            this.startCaptureButton.Text = "Start Capture";
            this.startCaptureButton.UseVisualStyleBackColor = true;
            this.startCaptureButton.Click += new System.EventHandler(this.startCaptureButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 1196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Template";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 1154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Image";
            // 
            // template_textbox
            // 
            this.template_textbox.Location = new System.Drawing.Point(138, 1200);
            this.template_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.template_textbox.Name = "template_textbox";
            this.template_textbox.Size = new System.Drawing.Size(373, 26);
            this.template_textbox.TabIndex = 28;
            // 
            // findMatch
            // 
            this.findMatch.Location = new System.Drawing.Point(364, 1249);
            this.findMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findMatch.Name = "findMatch";
            this.findMatch.Size = new System.Drawing.Size(150, 35);
            this.findMatch.TabIndex = 27;
            this.findMatch.Text = "Find";
            this.findMatch.UseVisualStyleBackColor = true;
            this.findMatch.Click += new System.EventHandler(this.findMatch_Click);
            // 
            // loadTemplate
            // 
            this.loadTemplate.Location = new System.Drawing.Point(522, 1192);
            this.loadTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadTemplate.Name = "loadTemplate";
            this.loadTemplate.Size = new System.Drawing.Size(38, 34);
            this.loadTemplate.TabIndex = 26;
            this.loadTemplate.Text = "...";
            this.loadTemplate.UseVisualStyleBackColor = true;
            this.loadTemplate.Click += new System.EventHandler(this.loadTemplate_Click);
            // 
            // capturePicture
            // 
            this.capturePicture.Location = new System.Drawing.Point(198, 1249);
            this.capturePicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.capturePicture.Name = "capturePicture";
            this.capturePicture.Size = new System.Drawing.Size(150, 35);
            this.capturePicture.TabIndex = 25;
            this.capturePicture.Text = "Capture Picture";
            this.capturePicture.UseVisualStyleBackColor = true;
            this.capturePicture.Click += new System.EventHandler(this.takepicture_Click);
            // 
            // sourceimg_textbox
            // 
            this.sourceimg_textbox.Location = new System.Drawing.Point(138, 1151);
            this.sourceimg_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sourceimg_textbox.Name = "sourceimg_textbox";
            this.sourceimg_textbox.Size = new System.Drawing.Size(373, 26);
            this.sourceimg_textbox.TabIndex = 24;
            // 
            // loadSource
            // 
            this.loadSource.Location = new System.Drawing.Point(522, 1151);
            this.loadSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadSource.Name = "loadSource";
            this.loadSource.Size = new System.Drawing.Size(38, 31);
            this.loadSource.TabIndex = 23;
            this.loadSource.Text = "...";
            this.loadSource.UseVisualStyleBackColor = true;
            this.loadSource.Click += new System.EventHandler(this.loadSource_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // TemplateMatchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.startCaptureButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.template_textbox);
            this.Controls.Add(this.findMatch);
            this.Controls.Add(this.loadTemplate);
            this.Controls.Add(this.capturePicture);
            this.Controls.Add(this.sourceimg_textbox);
            this.Controls.Add(this.loadSource);
            this.Controls.Add(this.tracked_imgbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.captured_imgbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.template_imgbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imageBox4);
            this.Name = "TemplateMatchView";
            this.Size = new System.Drawing.Size(1665, 1306);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.template_imgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captured_imgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracked_imgbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox template_imgbox;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox captured_imgbox;
        private System.Windows.Forms.Label label2;
        private Emgu.CV.UI.ImageBox tracked_imgbox;
        private System.Windows.Forms.Button startCaptureButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox template_textbox;
        private System.Windows.Forms.Button findMatch;
        private System.Windows.Forms.Button loadTemplate;
        private System.Windows.Forms.Button capturePicture;
        private System.Windows.Forms.TextBox sourceimg_textbox;
        private System.Windows.Forms.Button loadSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}