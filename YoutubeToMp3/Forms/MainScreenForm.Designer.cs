﻿namespace YoutubeToMp3.Forms
{
    partial class MainScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            this.lblUrl = new System.Windows.Forms.Label();
            this.txbVideoUrl = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.fbdSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectSavePath = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorDivider = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblConvertStatus = new System.Windows.Forms.Label();
            this.pbxInternetConnection = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblNoInternetConnection = new System.Windows.Forms.Label();
            this.lblAudioDetails = new System.Windows.Forms.Label();
            this.lblAudioTitle = new System.Windows.Forms.Label();
            this.lblAudioTitleText = new System.Windows.Forms.Label();
            this.lblAudioDurationText = new System.Windows.Forms.Label();
            this.lblAudioDuration = new System.Windows.Forms.Label();
            this.lblAudioBitRateText = new System.Windows.Forms.Label();
            this.lblAudioBitRate = new System.Windows.Forms.Label();
            this.pbxFoundABug = new System.Windows.Forms.PictureBox();
            this.lblFoundABug = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAudioSizeText = new System.Windows.Forms.Label();
            this.lblAudioSize = new System.Windows.Forms.Label();
            this.pbxThumbnail = new System.Windows.Forms.PictureBox();
            this.pbxStatusIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInternetConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoundABug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatusIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUrl.Location = new System.Drawing.Point(12, 13);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(103, 25);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "Video URL:";
            // 
            // txbVideoUrl
            // 
            this.txbVideoUrl.Location = new System.Drawing.Point(121, 15);
            this.txbVideoUrl.Name = "txbVideoUrl";
            this.txbVideoUrl.Size = new System.Drawing.Size(584, 23);
            this.txbVideoUrl.TabIndex = 1;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHint.Location = new System.Drawing.Point(15, 44);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(232, 12);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "*You can use YouTube or YouTube Music video Url.";
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSavePath.Location = new System.Drawing.Point(12, 71);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(136, 25);
            this.lblSavePath.TabIndex = 3;
            this.lblSavePath.Text = "Where to save:";
            // 
            // btnSelectSavePath
            // 
            this.btnSelectSavePath.BackColor = System.Drawing.Color.Firebrick;
            this.btnSelectSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSavePath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectSavePath.Location = new System.Drawing.Point(154, 70);
            this.btnSelectSavePath.Name = "btnSelectSavePath";
            this.btnSelectSavePath.Size = new System.Drawing.Size(103, 29);
            this.btnSelectSavePath.TabIndex = 4;
            this.btnSelectSavePath.Text = "Select";
            this.btnSelectSavePath.UseVisualStyleBackColor = false;
            this.btnSelectSavePath.Click += new System.EventHandler(this.btnSelectSavePath_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.AutoSize = true;
            this.txtSavePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSavePath.Location = new System.Drawing.Point(263, 73);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(73, 21);
            this.txtSavePath.TabIndex = 5;
            this.txtSavePath.Text = "SavePath";
            this.txtSavePath.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Default save path is Desktop (in same path temporary .mp4 file will be downloade" +
    "d but after conversion will be deleted).";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(0, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(712, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "_________________________________________________________________________________" +
    "____________________________________________________________";
            // 
            // lblErrorDivider
            // 
            this.lblErrorDivider.AutoSize = true;
            this.lblErrorDivider.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorDivider.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorDivider.Location = new System.Drawing.Point(0, 166);
            this.lblErrorDivider.Name = "lblErrorDivider";
            this.lblErrorDivider.Size = new System.Drawing.Size(712, 15);
            this.lblErrorDivider.TabIndex = 8;
            this.lblErrorDivider.Text = "_________________________________________________________________________________" +
    "____________________________________________________________";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Firebrick;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConvert.Location = new System.Drawing.Point(3, 139);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(138, 33);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_ClickAsync);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Firebrick;
            this.progressBar.Location = new System.Drawing.Point(147, 144);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(520, 23);
            this.progressBar.Step = 2;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 10;
            // 
            // lblConvertStatus
            // 
            this.lblConvertStatus.AutoSize = true;
            this.lblConvertStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblConvertStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConvertStatus.ForeColor = System.Drawing.Color.Firebrick;
            this.lblConvertStatus.Location = new System.Drawing.Point(4, 176);
            this.lblConvertStatus.MaximumSize = new System.Drawing.Size(725, 0);
            this.lblConvertStatus.Name = "lblConvertStatus";
            this.lblConvertStatus.Size = new System.Drawing.Size(0, 21);
            this.lblConvertStatus.TabIndex = 11;
            this.lblConvertStatus.Visible = false;
            // 
            // pbxInternetConnection
            // 
            this.pbxInternetConnection.Image = global::YoutubeToMp3.Properties.Resources.InternetConnection;
            this.pbxInternetConnection.Location = new System.Drawing.Point(685, 404);
            this.pbxInternetConnection.Name = "pbxInternetConnection";
            this.pbxInternetConnection.Size = new System.Drawing.Size(23, 23);
            this.pbxInternetConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxInternetConnection.TabIndex = 12;
            this.pbxInternetConnection.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            // 
            // lblNoInternetConnection
            // 
            this.lblNoInternetConnection.AutoSize = true;
            this.lblNoInternetConnection.Location = new System.Drawing.Point(545, 408);
            this.lblNoInternetConnection.Name = "lblNoInternetConnection";
            this.lblNoInternetConnection.Size = new System.Drawing.Size(135, 15);
            this.lblNoInternetConnection.TabIndex = 13;
            this.lblNoInternetConnection.Text = "No Internet Connection!";
            this.lblNoInternetConnection.Visible = false;
            // 
            // lblAudioDetails
            // 
            this.lblAudioDetails.AutoSize = true;
            this.lblAudioDetails.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAudioDetails.Location = new System.Drawing.Point(12, 210);
            this.lblAudioDetails.Name = "lblAudioDetails";
            this.lblAudioDetails.Size = new System.Drawing.Size(126, 25);
            this.lblAudioDetails.TabIndex = 15;
            this.lblAudioDetails.Text = "Audio details:";
            this.lblAudioDetails.Visible = false;
            // 
            // lblAudioTitle
            // 
            this.lblAudioTitle.AutoSize = true;
            this.lblAudioTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAudioTitle.Location = new System.Drawing.Point(34, 246);
            this.lblAudioTitle.Name = "lblAudioTitle";
            this.lblAudioTitle.Size = new System.Drawing.Size(42, 21);
            this.lblAudioTitle.TabIndex = 16;
            this.lblAudioTitle.Text = "Title:";
            this.lblAudioTitle.Visible = false;
            // 
            // lblAudioTitleText
            // 
            this.lblAudioTitleText.AutoSize = true;
            this.lblAudioTitleText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAudioTitleText.Location = new System.Drawing.Point(79, 246);
            this.lblAudioTitleText.Name = "lblAudioTitleText";
            this.lblAudioTitleText.Size = new System.Drawing.Size(106, 21);
            this.lblAudioTitleText.TabIndex = 17;
            this.lblAudioTitleText.Text = "<Audio Title>";
            this.lblAudioTitleText.Visible = false;
            // 
            // lblAudioDurationText
            // 
            this.lblAudioDurationText.AutoSize = true;
            this.lblAudioDurationText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAudioDurationText.Location = new System.Drawing.Point(79, 276);
            this.lblAudioDurationText.Name = "lblAudioDurationText";
            this.lblAudioDurationText.Size = new System.Drawing.Size(138, 21);
            this.lblAudioDurationText.TabIndex = 21;
            this.lblAudioDurationText.Text = "<Audio Duration>";
            this.lblAudioDurationText.Visible = false;
            // 
            // lblAudioDuration
            // 
            this.lblAudioDuration.AutoSize = true;
            this.lblAudioDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAudioDuration.Location = new System.Drawing.Point(2, 276);
            this.lblAudioDuration.Name = "lblAudioDuration";
            this.lblAudioDuration.Size = new System.Drawing.Size(74, 21);
            this.lblAudioDuration.TabIndex = 20;
            this.lblAudioDuration.Text = "Duration:";
            this.lblAudioDuration.Visible = false;
            // 
            // lblAudioBitRateText
            // 
            this.lblAudioBitRateText.AutoSize = true;
            this.lblAudioBitRateText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAudioBitRateText.Location = new System.Drawing.Point(79, 306);
            this.lblAudioBitRateText.Name = "lblAudioBitRateText";
            this.lblAudioBitRateText.Size = new System.Drawing.Size(130, 21);
            this.lblAudioBitRateText.TabIndex = 23;
            this.lblAudioBitRateText.Text = "<Audio Bit Rate>";
            this.lblAudioBitRateText.Visible = false;
            // 
            // lblAudioBitRate
            // 
            this.lblAudioBitRate.AutoSize = true;
            this.lblAudioBitRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAudioBitRate.Location = new System.Drawing.Point(14, 306);
            this.lblAudioBitRate.Name = "lblAudioBitRate";
            this.lblAudioBitRate.Size = new System.Drawing.Size(62, 21);
            this.lblAudioBitRate.TabIndex = 22;
            this.lblAudioBitRate.Text = "Bit rate:";
            this.lblAudioBitRate.Visible = false;
            // 
            // pbxFoundABug
            // 
            this.pbxFoundABug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxFoundABug.Image = global::YoutubeToMp3.Properties.Resources.Bug;
            this.pbxFoundABug.Location = new System.Drawing.Point(4, 404);
            this.pbxFoundABug.Name = "pbxFoundABug";
            this.pbxFoundABug.Size = new System.Drawing.Size(23, 23);
            this.pbxFoundABug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoundABug.TabIndex = 24;
            this.pbxFoundABug.TabStop = false;
            this.pbxFoundABug.Click += new System.EventHandler(this.pbxFoundABug_Click);
            // 
            // lblFoundABug
            // 
            this.lblFoundABug.AutoSize = true;
            this.lblFoundABug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoundABug.Location = new System.Drawing.Point(34, 408);
            this.lblFoundABug.Name = "lblFoundABug";
            this.lblFoundABug.Size = new System.Drawing.Size(79, 15);
            this.lblFoundABug.TabIndex = 25;
            this.lblFoundABug.Text = "Found a bug?";
            this.lblFoundABug.Click += new System.EventHandler(this.lblFoundABug_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(1, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(712, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "_________________________________________________________________________________" +
    "____________________________________________________________";
            // 
            // lblAudioSizeText
            // 
            this.lblAudioSizeText.AutoSize = true;
            this.lblAudioSizeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAudioSizeText.Location = new System.Drawing.Point(79, 336);
            this.lblAudioSizeText.Name = "lblAudioSizeText";
            this.lblAudioSizeText.Size = new System.Drawing.Size(105, 21);
            this.lblAudioSizeText.TabIndex = 28;
            this.lblAudioSizeText.Text = "<Audio Size>";
            this.lblAudioSizeText.Visible = false;
            // 
            // lblAudioSize
            // 
            this.lblAudioSize.AutoSize = true;
            this.lblAudioSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAudioSize.Location = new System.Drawing.Point(35, 336);
            this.lblAudioSize.Name = "lblAudioSize";
            this.lblAudioSize.Size = new System.Drawing.Size(41, 21);
            this.lblAudioSize.TabIndex = 27;
            this.lblAudioSize.Text = "Size:";
            this.lblAudioSize.Visible = false;
            // 
            // pbxThumbnail
            // 
            this.pbxThumbnail.Location = new System.Drawing.Point(520, 214);
            this.pbxThumbnail.Name = "pbxThumbnail";
            this.pbxThumbnail.Size = new System.Drawing.Size(170, 170);
            this.pbxThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxThumbnail.TabIndex = 29;
            this.pbxThumbnail.TabStop = false;
            this.pbxThumbnail.Visible = false;
            // 
            // pbxStatusIcon
            // 
            this.pbxStatusIcon.Image = global::YoutubeToMp3.Properties.Resources.Completed;
            this.pbxStatusIcon.Location = new System.Drawing.Point(675, 141);
            this.pbxStatusIcon.Name = "pbxStatusIcon";
            this.pbxStatusIcon.Size = new System.Drawing.Size(28, 28);
            this.pbxStatusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStatusIcon.TabIndex = 30;
            this.pbxStatusIcon.TabStop = false;
            this.pbxStatusIcon.Visible = false;
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(714, 432);
            this.Controls.Add(this.pbxStatusIcon);
            this.Controls.Add(this.pbxThumbnail);
            this.Controls.Add(this.lblAudioSizeText);
            this.Controls.Add(this.lblAudioSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFoundABug);
            this.Controls.Add(this.pbxFoundABug);
            this.Controls.Add(this.lblAudioBitRateText);
            this.Controls.Add(this.lblAudioBitRate);
            this.Controls.Add(this.lblAudioDurationText);
            this.Controls.Add(this.lblAudioDuration);
            this.Controls.Add(this.lblAudioTitleText);
            this.Controls.Add(this.lblAudioTitle);
            this.Controls.Add(this.lblAudioDetails);
            this.Controls.Add(this.lblNoInternetConnection);
            this.Controls.Add(this.pbxInternetConnection);
            this.Controls.Add(this.lblConvertStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblErrorDivider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.btnSelectSavePath);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.txbVideoUrl);
            this.Controls.Add(this.lblUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube To Mp3";
            ((System.ComponentModel.ISupportInitialize)(this.pbxInternetConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoundABug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatusIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUrl;
        private TextBox txbVideoUrl;
        private Label lblHint;
        private Label lblSavePath;
        private FolderBrowserDialog fbdSavePath;
        private Button btnSelectSavePath;
        private Label txtSavePath;
        private Label label1;
        private Label label2;
        private Label lblErrorDivider;
        private Button btnConvert;
        private ProgressBar progressBar;
        private Label lblConvertStatus;
        private PictureBox pbxInternetConnection;
        private System.Windows.Forms.Timer timer;
        private Label lblNoInternetConnection;
        private Label lblAudioDetails;
        private Label lblAudioTitle;
        private Label lblAudioTitleText;
        private Label lblAudioDurationText;
        private Label lblAudioDuration;
        private Label lblAudioBitRateText;
        private Label lblAudioBitRate;
        private PictureBox pbxFoundABug;
        private Label lblFoundABug;
        private Label label5;
        private Label lblAudioSizeText;
        private Label lblAudioSize;
        private PictureBox pbxThumbnail;
        private PictureBox pbxStatusIcon;
    }
}