﻿namespace quick_screen_recorder
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.videoGroup = new QuickLibrary.QlibGroupBox();
            this.refreshScreensBtn = new System.Windows.Forms.Button();
            this.hideTaskbarCheckBox = new QuickLibrary.QlibCheckBox();
            this.sizelabel = new System.Windows.Forms.Label();
            this.yNumeric = new QuickLibrary.QlibNumericBox();
            this.xNumeric = new QuickLibrary.QlibNumericBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.widthNumeric = new QuickLibrary.QlibNumericBox();
            this.qualityComboBox = new QuickLibrary.QlibComboBox();
            this.heightNumeric = new QuickLibrary.QlibNumericBox();
            this.areaComboBox = new QuickLibrary.QlibComboBox();
            this.captureCursorCheckBox = new QuickLibrary.QlibCheckBox();
            this.inputDeviceLabel = new System.Windows.Forms.Label();
            this.audioGroup = new QuickLibrary.QlibGroupBox();
            this.refreshAudioBtn = new System.Windows.Forms.Button();
            this.inputDeviceComboBox = new QuickLibrary.QlibComboBox();
            this.separateAudioCheckBox = new QuickLibrary.QlibCheckBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new QuickLibrary.QlibToolStrip();
            this.previewBtn = new System.Windows.Forms.ToolStripButton();
            this.onTopBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsBtn = new System.Windows.Forms.ToolStripButton();
            this.aboutBtn = new System.Windows.Forms.ToolStripButton();
            this.recButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.videoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
            this.audioGroup.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(19, 25);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(48, 15);
            this.qualityLabel.TabIndex = 10;
            this.qualityLabel.Text = "Quality:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(33, 55);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(34, 15);
            this.areaLabel.TabIndex = 18;
            this.areaLabel.Text = "Area:";
            // 
            // videoGroup
            // 
            this.videoGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.videoGroup.Controls.Add(this.refreshScreensBtn);
            this.videoGroup.Controls.Add(this.hideTaskbarCheckBox);
            this.videoGroup.Controls.Add(this.sizelabel);
            this.videoGroup.Controls.Add(this.yNumeric);
            this.videoGroup.Controls.Add(this.xNumeric);
            this.videoGroup.Controls.Add(this.locationLabel);
            this.videoGroup.Controls.Add(this.widthNumeric);
            this.videoGroup.Controls.Add(this.qualityComboBox);
            this.videoGroup.Controls.Add(this.heightNumeric);
            this.videoGroup.Controls.Add(this.areaComboBox);
            this.videoGroup.Controls.Add(this.captureCursorCheckBox);
            this.videoGroup.Controls.Add(this.areaLabel);
            this.videoGroup.Controls.Add(this.qualityLabel);
            this.videoGroup.Location = new System.Drawing.Point(9, 157);
            this.videoGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.videoGroup.Name = "videoGroup";
            this.videoGroup.Size = new System.Drawing.Size(10, 10);
            this.videoGroup.TabIndex = 6;
            this.videoGroup.TabStop = false;
            this.videoGroup.Text = "Video options";
            // 
            // refreshScreensBtn
            // 
            this.refreshScreensBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.refreshScreensBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.refreshScreensBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshScreensBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshScreensBtn.Image")));
            this.refreshScreensBtn.Location = new System.Drawing.Point(311, 52);
            this.refreshScreensBtn.Margin = new System.Windows.Forms.Padding(0);
            this.refreshScreensBtn.Name = "refreshScreensBtn";
            this.refreshScreensBtn.Size = new System.Drawing.Size(23, 23);
            this.refreshScreensBtn.TabIndex = 9;
            this.refreshScreensBtn.UseVisualStyleBackColor = false;
            this.refreshScreensBtn.Click += new System.EventHandler(this.refreshScreensBtn_Click);
            // 
            // hideTaskbarCheckBox
            // 
            this.hideTaskbarCheckBox.Location = new System.Drawing.Point(132, 113);
            this.hideTaskbarCheckBox.Name = "hideTaskbarCheckBox";
            this.hideTaskbarCheckBox.Size = new System.Drawing.Size(92, 19);
            this.hideTaskbarCheckBox.TabIndex = 14;
            this.hideTaskbarCheckBox.Text = "Hide taskbar";
            this.hideTaskbarCheckBox.UseVisualStyleBackColor = true;
            this.hideTaskbarCheckBox.CheckedChanged += new System.EventHandler(this.hideTaskbarCheckBox_CheckedChanged);
            // 
            // sizelabel
            // 
            this.sizelabel.AutoSize = true;
            this.sizelabel.Location = new System.Drawing.Point(197, 84);
            this.sizelabel.Name = "sizelabel";
            this.sizelabel.Size = new System.Drawing.Size(30, 15);
            this.sizelabel.TabIndex = 22;
            this.sizelabel.Text = "Size:";
            // 
            // yNumeric
            // 
            this.yNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yNumeric.Location = new System.Drawing.Point(127, 82);
            this.yNumeric.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(47, 23);
            this.yNumeric.TabIndex = 11;
            this.yNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // xNumeric
            // 
            this.xNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xNumeric.Location = new System.Drawing.Point(73, 82);
            this.xNumeric.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.xNumeric.Name = "xNumeric";
            this.xNumeric.Size = new System.Drawing.Size(47, 23);
            this.xNumeric.TabIndex = 10;
            this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(11, 84);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(56, 15);
            this.locationLabel.TabIndex = 19;
            this.locationLabel.Text = "Location:";
            // 
            // widthNumeric
            // 
            this.widthNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthNumeric.Location = new System.Drawing.Point(233, 82);
            this.widthNumeric.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.widthNumeric.Minimum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.widthNumeric.Name = "widthNumeric";
            this.widthNumeric.Size = new System.Drawing.Size(47, 23);
            this.widthNumeric.TabIndex = 12;
            this.widthNumeric.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.widthNumeric.ValueChanged += new System.EventHandler(this.widthNumeric_ValueChanged);
            // 
            // qualityComboBox
            // 
            this.qualityComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.qualityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.qualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.qualityComboBox.FormattingEnabled = true;
            this.qualityComboBox.IntegralHeight = false;
            this.qualityComboBox.Items.AddRange(new object[] {
            "25% - Low (Motion JPEG)",
            "50% - Medium (Motion JPEG)",
            "75% - High (Motion JPEG)",
            "100% - Original (Motion JPEG)",
            "Uncompressed"});
            this.qualityComboBox.Location = new System.Drawing.Point(73, 22);
            this.qualityComboBox.Name = "qualityComboBox";
            this.qualityComboBox.Size = new System.Drawing.Size(261, 24);
            this.qualityComboBox.TabIndex = 7;
            this.qualityComboBox.SelectedIndexChanged += new System.EventHandler(this.qualityComboBox_SelectedIndexChanged);
            // 
            // heightNumeric
            // 
            this.heightNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightNumeric.Location = new System.Drawing.Point(287, 82);
            this.heightNumeric.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.heightNumeric.Minimum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.heightNumeric.Name = "heightNumeric";
            this.heightNumeric.Size = new System.Drawing.Size(47, 23);
            this.heightNumeric.TabIndex = 13;
            this.heightNumeric.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.heightNumeric.ValueChanged += new System.EventHandler(this.heightNumeric_ValueChanged);
            // 
            // areaComboBox
            // 
            this.areaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.areaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.IntegralHeight = false;
            this.areaComboBox.Location = new System.Drawing.Point(73, 52);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(231, 24);
            this.areaComboBox.TabIndex = 8;
            this.areaComboBox.SelectedIndexChanged += new System.EventHandler(this.areaComboBox_SelectedIndexChanged);
            // 
            // captureCursorCheckBox
            // 
            this.captureCursorCheckBox.Checked = true;
            this.captureCursorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.captureCursorCheckBox.Location = new System.Drawing.Point(230, 113);
            this.captureCursorCheckBox.Name = "captureCursorCheckBox";
            this.captureCursorCheckBox.Size = new System.Drawing.Size(104, 19);
            this.captureCursorCheckBox.TabIndex = 15;
            this.captureCursorCheckBox.Text = "Capture cursor";
            this.captureCursorCheckBox.UseVisualStyleBackColor = true;
            this.captureCursorCheckBox.CheckedChanged += new System.EventHandler(this.captureCursorCheckBox_CheckedChanged);
            // 
            // inputDeviceLabel
            // 
            this.inputDeviceLabel.AutoSize = true;
            this.inputDeviceLabel.Location = new System.Drawing.Point(29, 26);
            this.inputDeviceLabel.Name = "inputDeviceLabel";
            this.inputDeviceLabel.Size = new System.Drawing.Size(38, 15);
            this.inputDeviceLabel.TabIndex = 26;
            this.inputDeviceLabel.Text = "Input:";
            // 
            // audioGroup
            // 
            this.audioGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.audioGroup.Controls.Add(this.refreshAudioBtn);
            this.audioGroup.Controls.Add(this.inputDeviceComboBox);
            this.audioGroup.Controls.Add(this.separateAudioCheckBox);
            this.audioGroup.Controls.Add(this.inputDeviceLabel);
            this.audioGroup.Location = new System.Drawing.Point(9, 306);
            this.audioGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.audioGroup.Name = "audioGroup";
            this.audioGroup.Size = new System.Drawing.Size(340, 80);
            this.audioGroup.TabIndex = 16;
            this.audioGroup.TabStop = false;
            this.audioGroup.Text = "Audio options";
            // 
            // refreshAudioBtn
            // 
            this.refreshAudioBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.refreshAudioBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.refreshAudioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshAudioBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshAudioBtn.Image")));
            this.refreshAudioBtn.Location = new System.Drawing.Point(311, 22);
            this.refreshAudioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.refreshAudioBtn.Name = "refreshAudioBtn";
            this.refreshAudioBtn.Size = new System.Drawing.Size(23, 23);
            this.refreshAudioBtn.TabIndex = 18;
            this.refreshAudioBtn.UseVisualStyleBackColor = false;
            this.refreshAudioBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // inputDeviceComboBox
            // 
            this.inputDeviceComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.inputDeviceComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.inputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDeviceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inputDeviceComboBox.FormattingEnabled = true;
            this.inputDeviceComboBox.IntegralHeight = false;
            this.inputDeviceComboBox.Items.AddRange(new object[] {
            "None",
            "System sounds (Soundcard)"});
            this.inputDeviceComboBox.Location = new System.Drawing.Point(73, 22);
            this.inputDeviceComboBox.Name = "inputDeviceComboBox";
            this.inputDeviceComboBox.Size = new System.Drawing.Size(231, 24);
            this.inputDeviceComboBox.TabIndex = 17;
            this.inputDeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.inputDeviceComboBox_SelectedIndexChanged);
            // 
            // separateAudioCheckBox
            // 
            this.separateAudioCheckBox.Location = new System.Drawing.Point(123, 53);
            this.separateAudioCheckBox.Name = "separateAudioCheckBox";
            this.separateAudioCheckBox.Size = new System.Drawing.Size(211, 19);
            this.separateAudioCheckBox.TabIndex = 19;
            this.separateAudioCheckBox.Text = "Write audio to a separate file (.wav)";
            this.separateAudioCheckBox.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewBtn,
            this.onTopBtn,
            this.toolStripSeparator1,
            this.settingsBtn,
            this.aboutBtn});
            this.toolStrip1.Location = new System.Drawing.Point(115, 117);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(9);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(132, 43);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // previewBtn
            // 
            this.previewBtn.AutoSize = false;
            this.previewBtn.CheckOnClick = true;
            this.previewBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.previewBtn.Image = ((System.Drawing.Image)(resources.GetObject("previewBtn.Image")));
            this.previewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previewBtn.Margin = new System.Windows.Forms.Padding(0);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(24, 25);
            this.previewBtn.Text = "Preview | Ctrl + P";
            this.previewBtn.ToolTipText = "Preview | Ctrl + P";
            this.previewBtn.CheckedChanged += new System.EventHandler(this.previewBtn_CheckedChanged);
            // 
            // onTopBtn
            // 
            this.onTopBtn.AutoSize = false;
            this.onTopBtn.CheckOnClick = true;
            this.onTopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.onTopBtn.Image = ((System.Drawing.Image)(resources.GetObject("onTopBtn.Image")));
            this.onTopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.onTopBtn.Margin = new System.Windows.Forms.Padding(0);
            this.onTopBtn.Name = "onTopBtn";
            this.onTopBtn.Size = new System.Drawing.Size(24, 25);
            this.onTopBtn.Text = "Always on top | Ctrl + T";
            this.onTopBtn.ToolTipText = "Always on top | Ctrl+T";
            this.onTopBtn.CheckedChanged += new System.EventHandler(this.onTopCheckBox_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(2, 16);
            // 
            // settingsBtn
            // 
            this.settingsBtn.AutoSize = false;
            this.settingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(24, 25);
            this.settingsBtn.Text = "About | F1";
            this.settingsBtn.ToolTipText = "Settings | Ctrl+Comma";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.AutoSize = false;
            this.aboutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutBtn.Image")));
            this.aboutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(24, 25);
            this.aboutBtn.Text = "About | F1";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // recButton
            // 
            this.recButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.recButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.recButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recButton.Image = ((System.Drawing.Image)(resources.GetObject("recButton.Image")));
            this.recButton.Location = new System.Drawing.Point(115, 79);
            this.recButton.Margin = new System.Windows.Forms.Padding(0);
            this.recButton.Name = "recButton";
            this.recButton.Size = new System.Drawing.Size(133, 38);
            this.recButton.TabIndex = 0;
            this.recButton.Text = "GRABAR (Alt+C)";
            this.recButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recButton.UseVisualStyleBackColor = false;
            this.recButton.Click += new System.EventHandler(this.recButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // previewBox
            // 
            this.previewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewBox.BackColor = System.Drawing.Color.Black;
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewBox.Location = new System.Drawing.Point(358, 9);
            this.previewBox.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(437, 376);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewBox.TabIndex = 26;
            this.previewBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(804, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.audioGroup);
            this.Controls.Add(this.videoGroup);
            this.Controls.Add(this.recButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nexus Clips";
            this.TransparencyKey = System.Drawing.Color.MediumBlue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.videoGroup.ResumeLayout(false);
            this.videoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).EndInit();
            this.audioGroup.ResumeLayout(false);
            this.audioGroup.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button recButton;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label qualityLabel;
		private System.Windows.Forms.Label areaLabel;
		private QuickLibrary.QlibGroupBox videoGroup;
		private QuickLibrary.QlibCheckBox captureCursorCheckBox;
		private System.Windows.Forms.Label inputDeviceLabel;
		private QuickLibrary.QlibGroupBox audioGroup;
		private System.Windows.Forms.Timer updateTimer;
		private QuickLibrary.QlibComboBox areaComboBox;
		private QuickLibrary.QlibComboBox qualityComboBox;
		private QuickLibrary.QlibComboBox inputDeviceComboBox;
		private QuickLibrary.QlibNumericBox heightNumeric;
		private QuickLibrary.QlibNumericBox widthNumeric;
		private System.Windows.Forms.Button refreshAudioBtn;
		private QuickLibrary.QlibToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton onTopBtn;
		private System.Windows.Forms.ToolStripButton aboutBtn;
		private System.Windows.Forms.ToolStripButton settingsBtn;
		private QuickLibrary.QlibCheckBox separateAudioCheckBox;
		private System.Windows.Forms.Label locationLabel;
		private QuickLibrary.QlibNumericBox xNumeric;
		private QuickLibrary.QlibNumericBox yNumeric;
		private System.Windows.Forms.Label sizelabel;
		private QuickLibrary.QlibCheckBox hideTaskbarCheckBox;
		private System.Windows.Forms.Button refreshScreensBtn;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton previewBtn;
        private System.Windows.Forms.PictureBox previewBox;
    }
}

