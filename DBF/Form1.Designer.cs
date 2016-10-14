﻿namespace DBF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.roll_back = new System.Windows.Forms.Button();
            this.commit_conversion = new System.Windows.Forms.Button();
            this.start_conversion = new System.Windows.Forms.Button();
            this.maps_folder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rollbackBar = new System.Windows.Forms.ProgressBar();
            this.commitBar = new System.Windows.Forms.ProgressBar();
            this.conversionBar = new System.Windows.Forms.ProgressBar();
            this.dbBar = new System.Windows.Forms.ProgressBar();
            this.warring = new System.Windows.Forms.NotifyIcon(this.components);
            this.success = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.roll_back);
            this.splitContainer1.Panel1.Controls.Add(this.commit_conversion);
            this.splitContainer1.Panel1.Controls.Add(this.start_conversion);
            this.splitContainer1.Panel1.Controls.Add(this.maps_folder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.rollbackBar);
            this.splitContainer1.Panel2.Controls.Add(this.commitBar);
            this.splitContainer1.Panel2.Controls.Add(this.conversionBar);
            this.splitContainer1.Panel2.Controls.Add(this.dbBar);
            this.splitContainer1.Size = new System.Drawing.Size(988, 306);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // roll_back
            // 
            this.roll_back.Location = new System.Drawing.Point(11, 208);
            this.roll_back.Name = "roll_back";
            this.roll_back.Size = new System.Drawing.Size(147, 31);
            this.roll_back.TabIndex = 3;
            this.roll_back.Text = "Roll back";
            this.roll_back.UseVisualStyleBackColor = true;
            // 
            // commit_conversion
            // 
            this.commit_conversion.Location = new System.Drawing.Point(12, 148);
            this.commit_conversion.Name = "commit_conversion";
            this.commit_conversion.Size = new System.Drawing.Size(148, 32);
            this.commit_conversion.TabIndex = 2;
            this.commit_conversion.Text = "Commit conversion";
            this.commit_conversion.UseVisualStyleBackColor = true;
            // 
            // start_conversion
            // 
            this.start_conversion.Location = new System.Drawing.Point(11, 90);
            this.start_conversion.Name = "start_conversion";
            this.start_conversion.Size = new System.Drawing.Size(149, 31);
            this.start_conversion.TabIndex = 1;
            this.start_conversion.Text = "Start files conversions";
            this.start_conversion.UseVisualStyleBackColor = true;
            // 
            // maps_folder
            // 
            this.maps_folder.Location = new System.Drawing.Point(13, 34);
            this.maps_folder.Name = "maps_folder";
            this.maps_folder.Size = new System.Drawing.Size(150, 30);
            this.maps_folder.TabIndex = 0;
            this.maps_folder.Text = "Open maps folder";
            this.maps_folder.UseVisualStyleBackColor = true;
            this.maps_folder.Click += new System.EventHandler(this.maps_folder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Roll back";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Commit conversion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Files conversion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Maps loading";
            // 
            // rollbackBar
            // 
            this.rollbackBar.Location = new System.Drawing.Point(36, 208);
            this.rollbackBar.Name = "rollbackBar";
            this.rollbackBar.Size = new System.Drawing.Size(202, 31);
            this.rollbackBar.TabIndex = 3;
            // 
            // commitBar
            // 
            this.commitBar.Location = new System.Drawing.Point(36, 148);
            this.commitBar.Name = "commitBar";
            this.commitBar.Size = new System.Drawing.Size(202, 32);
            this.commitBar.TabIndex = 2;
            // 
            // conversionBar
            // 
            this.conversionBar.Location = new System.Drawing.Point(36, 90);
            this.conversionBar.Name = "conversionBar";
            this.conversionBar.Size = new System.Drawing.Size(202, 31);
            this.conversionBar.TabIndex = 1;
            // 
            // dbBar
            // 
            this.dbBar.Location = new System.Drawing.Point(36, 34);
            this.dbBar.Name = "dbBar";
            this.dbBar.Size = new System.Drawing.Size(202, 30);
            this.dbBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.dbBar.TabIndex = 0;
            // 
            // warring
            // 
            this.warring.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.warring.Icon = ((System.Drawing.Icon)(resources.GetObject("warring.Icon")));
            this.warring.Text = "notifyIcon1";
            // 
            // success
            // 
            this.success.Icon = ((System.Drawing.Icon)(resources.GetObject("success.Icon")));
            this.success.Text = "notifyIcon2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Success report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Failure report";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total report";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 306);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button roll_back;
        private System.Windows.Forms.Button commit_conversion;
        private System.Windows.Forms.Button start_conversion;
        private System.Windows.Forms.Button maps_folder;
        private System.Windows.Forms.ProgressBar rollbackBar;
        private System.Windows.Forms.ProgressBar commitBar;
        private System.Windows.Forms.ProgressBar conversionBar;
        private System.Windows.Forms.ProgressBar dbBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon warring;
        private System.Windows.Forms.NotifyIcon success;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;

    }
}
