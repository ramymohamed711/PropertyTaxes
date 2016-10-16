namespace DBF
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
            this.start_conversion = new System.Windows.Forms.Button();
            this.maps_folder = new System.Windows.Forms.Button();
            this.currentstatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rollbackBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zonebar = new System.Windows.Forms.ProgressBar();
            this.tasksbar = new System.Windows.Forms.ProgressBar();
            this.mapsBar = new System.Windows.Forms.ProgressBar();
            this.conversionBar = new System.Windows.Forms.ProgressBar();
            this.mapslable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileconversion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.failurepanel = new System.Windows.Forms.Panel();
            this.failureprecentage = new System.Windows.Forms.Label();
            this.totalfailure = new System.Windows.Forms.Label();
            this.successpanel = new System.Windows.Forms.Panel();
            this.successprecentage = new System.Windows.Forms.Label();
            this.totalsuccess = new System.Windows.Forms.Label();
            this.totalreport = new System.Windows.Forms.Panel();
            this.totaltasks = new System.Windows.Forms.Label();
            this.totalzones = new System.Windows.Forms.Label();
            this.totalmaps = new System.Windows.Forms.Label();
            this.warring = new System.Windows.Forms.NotifyIcon(this.components);
            this.success = new System.Windows.Forms.NotifyIcon(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.failurepanel.SuspendLayout();
            this.successpanel.SuspendLayout();
            this.totalreport.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Panel1.Controls.Add(this.roll_back);
            this.splitContainer1.Panel1.Controls.Add(this.start_conversion);
            this.splitContainer1.Panel1.Controls.Add(this.maps_folder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Panel2.Controls.Add(this.currentstatus);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.failurepanel);
            this.splitContainer1.Panel2.Controls.Add(this.successpanel);
            this.splitContainer1.Panel2.Controls.Add(this.totalreport);
            this.splitContainer1.Size = new System.Drawing.Size(988, 306);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // roll_back
            // 
            this.roll_back.Enabled = false;
            this.roll_back.Location = new System.Drawing.Point(14, 242);
            this.roll_back.Name = "roll_back";
            this.roll_back.Size = new System.Drawing.Size(147, 31);
            this.roll_back.TabIndex = 3;
            this.roll_back.Text = "Roll back";
            this.roll_back.UseVisualStyleBackColor = true;
            this.roll_back.Click += new System.EventHandler(this.roll_back_Click);
            // 
            // start_conversion
            // 
            this.start_conversion.Enabled = false;
            this.start_conversion.Location = new System.Drawing.Point(11, 150);
            this.start_conversion.Name = "start_conversion";
            this.start_conversion.Size = new System.Drawing.Size(149, 31);
            this.start_conversion.TabIndex = 1;
            this.start_conversion.Text = "Start files conversions";
            this.start_conversion.UseVisualStyleBackColor = true;
            this.start_conversion.Click += new System.EventHandler(this.start_conversion_Click);
            // 
            // maps_folder
            // 
            this.maps_folder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.maps_folder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maps_folder.Location = new System.Drawing.Point(11, 90);
            this.maps_folder.Name = "maps_folder";
            this.maps_folder.Size = new System.Drawing.Size(150, 30);
            this.maps_folder.TabIndex = 0;
            this.maps_folder.Text = "Open maps folder";
            this.maps_folder.UseVisualStyleBackColor = true;
            this.maps_folder.Click += new System.EventHandler(this.maps_folder_Click);
            // 
            // currentstatus
            // 
            this.currentstatus.AutoSize = true;
            this.currentstatus.Location = new System.Drawing.Point(296, 293);
            this.currentstatus.Name = "currentstatus";
            this.currentstatus.Size = new System.Drawing.Size(0, 13);
            this.currentstatus.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rollbackBar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.zonebar);
            this.panel2.Controls.Add(this.tasksbar);
            this.panel2.Controls.Add(this.mapsBar);
            this.panel2.Controls.Add(this.conversionBar);
            this.panel2.Controls.Add(this.mapslable);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.fileconversion);
            this.panel2.Location = new System.Drawing.Point(20, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 230);
            this.panel2.TabIndex = 22;
            // 
            // rollbackBar
            // 
            this.rollbackBar.Location = new System.Drawing.Point(7, 179);
            this.rollbackBar.Name = "rollbackBar";
            this.rollbackBar.Size = new System.Drawing.Size(202, 31);
            this.rollbackBar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Current zone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Current task";
            // 
            // zonebar
            // 
            this.zonebar.Location = new System.Drawing.Point(7, 137);
            this.zonebar.Name = "zonebar";
            this.zonebar.Size = new System.Drawing.Size(102, 14);
            this.zonebar.TabIndex = 18;
            // 
            // tasksbar
            // 
            this.tasksbar.Location = new System.Drawing.Point(126, 137);
            this.tasksbar.Name = "tasksbar";
            this.tasksbar.Size = new System.Drawing.Size(80, 14);
            this.tasksbar.TabIndex = 19;
            // 
            // mapsBar
            // 
            this.mapsBar.Location = new System.Drawing.Point(7, 28);
            this.mapsBar.Name = "mapsBar";
            this.mapsBar.Size = new System.Drawing.Size(202, 30);
            this.mapsBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.mapsBar.TabIndex = 0;
            // 
            // conversionBar
            // 
            this.conversionBar.Location = new System.Drawing.Point(7, 87);
            this.conversionBar.Name = "conversionBar";
            this.conversionBar.Size = new System.Drawing.Size(202, 31);
            this.conversionBar.TabIndex = 1;
            // 
            // mapslable
            // 
            this.mapslable.AutoSize = true;
            this.mapslable.Location = new System.Drawing.Point(4, 12);
            this.mapslable.Name = "mapslable";
            this.mapslable.Size = new System.Drawing.Size(70, 13);
            this.mapslable.TabIndex = 5;
            this.mapslable.Text = "Maps loading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Roll back";
            // 
            // fileconversion
            // 
            this.fileconversion.AutoSize = true;
            this.fileconversion.Location = new System.Drawing.Point(4, 71);
            this.fileconversion.Name = "fileconversion";
            this.fileconversion.Size = new System.Drawing.Size(83, 13);
            this.fileconversion.TabIndex = 6;
            this.fileconversion.Text = "Files conversion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(4, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 40);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(34, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current proccess";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(296, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(483, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Success report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(661, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Failure report";
            // 
            // failurepanel
            // 
            this.failurepanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.failurepanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.failurepanel.Controls.Add(this.failureprecentage);
            this.failurepanel.Controls.Add(this.totalfailure);
            this.failurepanel.Location = new System.Drawing.Point(660, 58);
            this.failurepanel.Name = "failurepanel";
            this.failurepanel.Size = new System.Drawing.Size(144, 181);
            this.failurepanel.TabIndex = 15;
            this.failurepanel.Visible = false;
            // 
            // failureprecentage
            // 
            this.failureprecentage.AutoSize = true;
            this.failureprecentage.Location = new System.Drawing.Point(1, 57);
            this.failureprecentage.Name = "failureprecentage";
            this.failureprecentage.Size = new System.Drawing.Size(95, 13);
            this.failureprecentage.TabIndex = 1;
            this.failureprecentage.Text = "Failure precentage";
            this.failureprecentage.Visible = false;
            // 
            // totalfailure
            // 
            this.totalfailure.AutoSize = true;
            this.totalfailure.Location = new System.Drawing.Point(1, 30);
            this.totalfailure.Name = "totalfailure";
            this.totalfailure.Size = new System.Drawing.Size(60, 13);
            this.totalfailure.TabIndex = 0;
            this.totalfailure.Text = "Total DBFs";
            // 
            // successpanel
            // 
            this.successpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.successpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.successpanel.Controls.Add(this.successprecentage);
            this.successpanel.Controls.Add(this.totalsuccess);
            this.successpanel.Location = new System.Drawing.Point(485, 58);
            this.successpanel.Name = "successpanel";
            this.successpanel.Size = new System.Drawing.Size(134, 181);
            this.successpanel.TabIndex = 14;
            this.successpanel.Visible = false;
            // 
            // successprecentage
            // 
            this.successprecentage.AutoSize = true;
            this.successprecentage.Location = new System.Drawing.Point(3, 57);
            this.successprecentage.Name = "successprecentage";
            this.successprecentage.Size = new System.Drawing.Size(88, 13);
            this.successprecentage.TabIndex = 1;
            this.successprecentage.Text = "Total precentage";
            this.successprecentage.Visible = false;
            // 
            // totalsuccess
            // 
            this.totalsuccess.AutoSize = true;
            this.totalsuccess.Location = new System.Drawing.Point(3, 30);
            this.totalsuccess.Name = "totalsuccess";
            this.totalsuccess.Size = new System.Drawing.Size(63, 13);
            this.totalsuccess.TabIndex = 0;
            this.totalsuccess.Text = "Total DBFs ";
            // 
            // totalreport
            // 
            this.totalreport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalreport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalreport.Controls.Add(this.totaltasks);
            this.totalreport.Controls.Add(this.totalzones);
            this.totalreport.Controls.Add(this.totalmaps);
            this.totalreport.Location = new System.Drawing.Point(299, 58);
            this.totalreport.Name = "totalreport";
            this.totalreport.Size = new System.Drawing.Size(134, 181);
            this.totalreport.TabIndex = 13;
            this.totalreport.Visible = false;
            // 
            // totaltasks
            // 
            this.totaltasks.AutoSize = true;
            this.totaltasks.Location = new System.Drawing.Point(2, 82);
            this.totaltasks.Name = "totaltasks";
            this.totaltasks.Size = new System.Drawing.Size(59, 13);
            this.totaltasks.TabIndex = 2;
            this.totaltasks.Text = "Total tasks";
            this.totaltasks.Visible = false;
            // 
            // totalzones
            // 
            this.totalzones.AutoSize = true;
            this.totalzones.Location = new System.Drawing.Point(0, 57);
            this.totalzones.Name = "totalzones";
            this.totalzones.Size = new System.Drawing.Size(65, 13);
            this.totalzones.TabIndex = 1;
            this.totalzones.Text = "Total zones ";
            this.totalzones.Visible = false;
            // 
            // totalmaps
            // 
            this.totalmaps.AutoSize = true;
            this.totalmaps.Location = new System.Drawing.Point(1, 30);
            this.totalmaps.Name = "totalmaps";
            this.totalmaps.Size = new System.Drawing.Size(59, 13);
            this.totalmaps.TabIndex = 0;
            this.totalmaps.Text = "Total maps";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 306);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.failurepanel.ResumeLayout(false);
            this.failurepanel.PerformLayout();
            this.successpanel.ResumeLayout(false);
            this.successpanel.PerformLayout();
            this.totalreport.ResumeLayout(false);
            this.totalreport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button roll_back;
        private System.Windows.Forms.Button start_conversion;
        private System.Windows.Forms.Button maps_folder;
        private System.Windows.Forms.ProgressBar rollbackBar;
        private System.Windows.Forms.ProgressBar conversionBar;
        private System.Windows.Forms.ProgressBar mapsBar;
        private System.Windows.Forms.Label fileconversion;
        private System.Windows.Forms.Label mapslable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon warring;
        private System.Windows.Forms.NotifyIcon success;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel totalreport;
        private System.Windows.Forms.Label totalmaps;
        private System.Windows.Forms.Label totaltasks;
        private System.Windows.Forms.Label totalzones;
        private System.Windows.Forms.Panel failurepanel;
        private System.Windows.Forms.Panel successpanel;
        private System.Windows.Forms.Label totalfailure;
        private System.Windows.Forms.Label successprecentage;
        private System.Windows.Forms.Label totalsuccess;
        private System.Windows.Forms.Label failureprecentage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar tasksbar;
        private System.Windows.Forms.ProgressBar zonebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentstatus;

    }
}

