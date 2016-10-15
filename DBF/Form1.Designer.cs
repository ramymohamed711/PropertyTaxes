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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileconversion = new System.Windows.Forms.Label();
            this.mapslable = new System.Windows.Forms.Label();
            this.rollbackBar = new System.Windows.Forms.ProgressBar();
            this.conversionBar = new System.Windows.Forms.ProgressBar();
            this.mapsBar = new System.Windows.Forms.ProgressBar();
            this.warring = new System.Windows.Forms.NotifyIcon(this.components);
            this.success = new System.Windows.Forms.NotifyIcon(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.roll_back);
            this.splitContainer1.Panel1.Controls.Add(this.start_conversion);
            this.splitContainer1.Panel1.Controls.Add(this.maps_folder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.failurepanel);
            this.splitContainer1.Panel2.Controls.Add(this.successpanel);
            this.splitContainer1.Panel2.Controls.Add(this.totalreport);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.fileconversion);
            this.splitContainer1.Panel2.Controls.Add(this.mapslable);
            this.splitContainer1.Panel2.Controls.Add(this.rollbackBar);
            this.splitContainer1.Panel2.Controls.Add(this.conversionBar);
            this.splitContainer1.Panel2.Controls.Add(this.mapsBar);
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
            // start_conversion
            // 
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
            this.maps_folder.Location = new System.Drawing.Point(11, 90);
            this.maps_folder.Name = "maps_folder";
            this.maps_folder.Size = new System.Drawing.Size(150, 30);
            this.maps_folder.TabIndex = 0;
            this.maps_folder.Text = "Open maps folder";
            this.maps_folder.UseVisualStyleBackColor = true;
            this.maps_folder.Click += new System.EventHandler(this.maps_folder_Click);
            // 
            // failurepanel
            // 
            this.failurepanel.BackColor = System.Drawing.SystemColors.Info;
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
            // 
            // totalfailure
            // 
            this.totalfailure.AutoSize = true;
            this.totalfailure.Location = new System.Drawing.Point(1, 30);
            this.totalfailure.Name = "totalfailure";
            this.totalfailure.Size = new System.Drawing.Size(62, 13);
            this.totalfailure.TabIndex = 0;
            this.totalfailure.Text = "Total failure";
            // 
            // successpanel
            // 
            this.successpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // 
            // totalsuccess
            // 
            this.totalsuccess.AutoSize = true;
            this.totalsuccess.Location = new System.Drawing.Point(3, 30);
            this.totalsuccess.Name = "totalsuccess";
            this.totalsuccess.Size = new System.Drawing.Size(63, 13);
            this.totalsuccess.TabIndex = 0;
            this.totalsuccess.Text = "Total BDFs ";
            // 
            // totalreport
            // 
            this.totalreport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalreport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalreport.Controls.Add(this.totaltasks);
            this.totalreport.Controls.Add(this.totalzones);
            this.totalreport.Controls.Add(this.totalmaps);
            this.totalreport.Location = new System.Drawing.Point(300, 58);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Failure report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Success report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Roll back";
            // 
            // fileconversion
            // 
            this.fileconversion.AutoSize = true;
            this.fileconversion.Location = new System.Drawing.Point(36, 134);
            this.fileconversion.Name = "fileconversion";
            this.fileconversion.Size = new System.Drawing.Size(83, 13);
            this.fileconversion.TabIndex = 6;
            this.fileconversion.Text = "Files conversion";
            // 
            // mapslable
            // 
            this.mapslable.AutoSize = true;
            this.mapslable.Location = new System.Drawing.Point(36, 74);
            this.mapslable.Name = "mapslable";
            this.mapslable.Size = new System.Drawing.Size(70, 13);
            this.mapslable.TabIndex = 5;
            this.mapslable.Text = "Maps loading";
            // 
            // rollbackBar
            // 
            this.rollbackBar.Location = new System.Drawing.Point(39, 208);
            this.rollbackBar.Name = "rollbackBar";
            this.rollbackBar.Size = new System.Drawing.Size(202, 31);
            this.rollbackBar.TabIndex = 3;
            // 
            // conversionBar
            // 
            this.conversionBar.Location = new System.Drawing.Point(39, 150);
            this.conversionBar.Name = "conversionBar";
            this.conversionBar.Size = new System.Drawing.Size(202, 31);
            this.conversionBar.TabIndex = 1;
            // 
            // mapsBar
            // 
            this.mapsBar.Location = new System.Drawing.Point(39, 90);
            this.mapsBar.Name = "mapsBar";
            this.mapsBar.Size = new System.Drawing.Size(202, 30);
            this.mapsBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.mapsBar.TabIndex = 0;
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
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

    }
}

