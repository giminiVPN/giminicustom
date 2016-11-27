﻿namespace Shadowsocks.View
{
	// Token: 0x02000003 RID: 3
	public partial class ConfigForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00003413 File Offset: 0x00001613
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003434 File Offset: 0x00001634
		private void InitializeComponent()
		{
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ObfsCombo = new System.Windows.Forms.ComboBox();
            this.labelObfs = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EncryptionLabel = new System.Windows.Forms.Label();
            this.EncryptionSelect = new System.Windows.Forms.ComboBox();
            this.TextLink = new System.Windows.Forms.TextBox();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.ObfsUDPLabel = new System.Windows.Forms.Label();
            this.CheckObfsUDP = new System.Windows.Forms.CheckBox();
            this.TCPProtocolLabel = new System.Windows.Forms.Label();
            this.UDPoverTCPLabel = new System.Windows.Forms.Label();
            this.CheckUDPoverUDP = new System.Windows.Forms.CheckBox();
            this.LabelNote = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.CheckBox();
            this.TCPoverUDPLabel = new System.Windows.Forms.Label();
            this.CheckTCPoverUDP = new System.Windows.Forms.CheckBox();
            this.TCPProtocolComboBox = new System.Windows.Forms.ComboBox();
            this.labelObfsParam = new System.Windows.Forms.Label();
            this.textObfsParam = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.TextGroup = new System.Windows.Forms.TextBox();
            this.checkAdvSetting = new System.Windows.Forms.CheckBox();
            this.labelUDPPort = new System.Windows.Forms.Label();
            this.textUDPPort = new System.Windows.Forms.TextBox();
            this.checkSSRLink = new System.Windows.Forms.CheckBox();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MyCancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ServerGroupBox = new System.Windows.Forms.GroupBox();
            this.PictureQRcode = new System.Windows.Forms.PictureBox();
            this.ServersListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.LinkUpdate = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.ServerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureQRcode)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ObfsCombo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelObfs, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.IPLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ServerPortLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IPTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ServerPortTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EncryptionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EncryptionSelect, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextLink, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.RemarksTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.ObfsUDPLabel, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.CheckObfsUDP, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.TCPProtocolLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.UDPoverTCPLabel, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.CheckUDPoverUDP, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.LabelNote, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TCPoverUDPLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.CheckTCPoverUDP, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.TCPProtocolComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelObfsParam, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textObfsParam, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelGroup, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.TextGroup, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.checkAdvSetting, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelUDPPort, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.textUDPPort, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.checkSSRLink, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelRemarks, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 15);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ObfsCombo
            // 
            this.ObfsCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ObfsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObfsCombo.FormattingEnabled = true;
            this.ObfsCombo.Items.AddRange(new object[] {
            "plain",
            "http_simple",
            "http_post",
            "random_head",
            "tls1.2_ticket_auth"});
            this.ObfsCombo.Location = new System.Drawing.Point(118, 157);
            this.ObfsCombo.Name = "ObfsCombo";
            this.ObfsCombo.Size = new System.Drawing.Size(222, 25);
            this.ObfsCombo.TabIndex = 34;
            this.ObfsCombo.TextChanged += new System.EventHandler(this.ObfsCombo_TextChanged);
            // 
            // labelObfs
            // 
            this.labelObfs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelObfs.AutoSize = true;
            this.labelObfs.Location = new System.Drawing.Point(72, 160);
            this.labelObfs.Name = "labelObfs";
            this.labelObfs.Size = new System.Drawing.Size(40, 17);
            this.labelObfs.TabIndex = 33;
            this.labelObfs.Text = "Obfs";
            // 
            // IPLabel
            // 
            this.IPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(44, 10);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(68, 17);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "Server IP";
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(30, 41);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(82, 17);
            this.ServerPortLabel.TabIndex = 1;
            this.ServerPortLabel.Text = "Server Port";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IPTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IPTextBox.Location = new System.Drawing.Point(118, 6);
            this.IPTextBox.MaxLength = 512;
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(222, 25);
            this.IPTextBox.TabIndex = 0;
            this.IPTextBox.WordWrap = false;
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerPortTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ServerPortTextBox.Location = new System.Drawing.Point(118, 37);
            this.ServerPortTextBox.MaxLength = 10;
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(222, 25);
            this.ServerPortTextBox.TabIndex = 1;
            this.ServerPortTextBox.WordWrap = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PasswordTextBox.Location = new System.Drawing.Point(118, 68);
            this.PasswordTextBox.MaxLength = 256;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(222, 25);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WordWrap = false;
            // 
            // EncryptionLabel
            // 
            this.EncryptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EncryptionLabel.AutoSize = true;
            this.EncryptionLabel.Location = new System.Drawing.Point(35, 102);
            this.EncryptionLabel.Name = "EncryptionLabel";
            this.EncryptionLabel.Size = new System.Drawing.Size(77, 17);
            this.EncryptionLabel.TabIndex = 8;
            this.EncryptionLabel.Text = "Encryption";
            // 
            // EncryptionSelect
            // 
            this.EncryptionSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncryptionSelect.FormattingEnabled = true;
            this.EncryptionSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EncryptionSelect.ItemHeight = 17;
            this.EncryptionSelect.Location = new System.Drawing.Point(118, 99);
            this.EncryptionSelect.Name = "EncryptionSelect";
            this.EncryptionSelect.Size = new System.Drawing.Size(222, 25);
            this.EncryptionSelect.TabIndex = 3;
            // 
            // TextLink
            // 
            this.TextLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextLink.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextLink.Location = new System.Drawing.Point(118, 279);
            this.TextLink.MaxLength = 32;
            this.TextLink.Name = "TextLink";
            this.TextLink.Size = new System.Drawing.Size(222, 25);
            this.TextLink.TabIndex = 12;
            this.TextLink.WordWrap = false;
            this.TextLink.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextLink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseUp);
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarksTextBox.Location = new System.Drawing.Point(118, 217);
            this.RemarksTextBox.MaxLength = 32;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(222, 25);
            this.RemarksTextBox.TabIndex = 10;
            this.RemarksTextBox.WordWrap = false;
            // 
            // ObfsUDPLabel
            // 
            this.ObfsUDPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ObfsUDPLabel.AutoSize = true;
            this.ObfsUDPLabel.Location = new System.Drawing.Point(37, 424);
            this.ObfsUDPLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ObfsUDPLabel.Name = "ObfsUDPLabel";
            this.ObfsUDPLabel.Size = new System.Drawing.Size(75, 17);
            this.ObfsUDPLabel.TabIndex = 25;
            this.ObfsUDPLabel.Text = "Obfs UDP";
            this.ObfsUDPLabel.Visible = false;
            // 
            // CheckObfsUDP
            // 
            this.CheckObfsUDP.AutoSize = true;
            this.CheckObfsUDP.Location = new System.Drawing.Point(118, 422);
            this.CheckObfsUDP.Name = "CheckObfsUDP";
            this.CheckObfsUDP.Size = new System.Drawing.Size(174, 21);
            this.CheckObfsUDP.TabIndex = 28;
            this.CheckObfsUDP.Text = "Recommend checked";
            this.CheckObfsUDP.UseVisualStyleBackColor = true;
            this.CheckObfsUDP.Visible = false;
            // 
            // TCPProtocolLabel
            // 
            this.TCPProtocolLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TCPProtocolLabel.AutoSize = true;
            this.TCPProtocolLabel.Location = new System.Drawing.Point(50, 131);
            this.TCPProtocolLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TCPProtocolLabel.Name = "TCPProtocolLabel";
            this.TCPProtocolLabel.Size = new System.Drawing.Size(62, 17);
            this.TCPProtocolLabel.TabIndex = 24;
            this.TCPProtocolLabel.Text = "Protocol";
            // 
            // UDPoverTCPLabel
            // 
            this.UDPoverTCPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UDPoverTCPLabel.AutoSize = true;
            this.UDPoverTCPLabel.Location = new System.Drawing.Point(15, 397);
            this.UDPoverTCPLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UDPoverTCPLabel.Name = "UDPoverTCPLabel";
            this.UDPoverTCPLabel.Size = new System.Drawing.Size(97, 17);
            this.UDPoverTCPLabel.TabIndex = 23;
            this.UDPoverTCPLabel.Text = "UDPoverTCP";
            this.UDPoverTCPLabel.Visible = false;
            // 
            // CheckUDPoverUDP
            // 
            this.CheckUDPoverUDP.AutoSize = true;
            this.CheckUDPoverUDP.Location = new System.Drawing.Point(118, 395);
            this.CheckUDPoverUDP.Name = "CheckUDPoverUDP";
            this.CheckUDPoverUDP.Size = new System.Drawing.Size(222, 21);
            this.CheckUDPoverUDP.TabIndex = 26;
            this.CheckUDPoverUDP.Text = "UDP over UDP if not checked";
            this.CheckUDPoverUDP.UseVisualStyleBackColor = true;
            this.CheckUDPoverUDP.Visible = false;
            // 
            // LabelNote
            // 
            this.LabelNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelNote.AutoSize = true;
            this.LabelNote.Location = new System.Drawing.Point(120, 312);
            this.LabelNote.Margin = new System.Windows.Forms.Padding(5);
            this.LabelNote.Name = "LabelNote";
            this.LabelNote.Size = new System.Drawing.Size(205, 17);
            this.LabelNote.TabIndex = 29;
            this.LabelNote.Text = "NOT all server support belows";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(16, 70);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(96, 21);
            this.PasswordLabel.TabIndex = 31;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.UseVisualStyleBackColor = true;
            this.PasswordLabel.CheckedChanged += new System.EventHandler(this.PasswordLabel_CheckedChanged);
            // 
            // TCPoverUDPLabel
            // 
            this.TCPoverUDPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TCPoverUDPLabel.AutoSize = true;
            this.TCPoverUDPLabel.Location = new System.Drawing.Point(15, 370);
            this.TCPoverUDPLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TCPoverUDPLabel.Name = "TCPoverUDPLabel";
            this.TCPoverUDPLabel.Size = new System.Drawing.Size(97, 17);
            this.TCPoverUDPLabel.TabIndex = 23;
            this.TCPoverUDPLabel.Text = "TCPoverUDP";
            this.TCPoverUDPLabel.Visible = false;
            // 
            // CheckTCPoverUDP
            // 
            this.CheckTCPoverUDP.AutoSize = true;
            this.CheckTCPoverUDP.Location = new System.Drawing.Point(118, 368);
            this.CheckTCPoverUDP.Name = "CheckTCPoverUDP";
            this.CheckTCPoverUDP.Size = new System.Drawing.Size(220, 21);
            this.CheckTCPoverUDP.TabIndex = 26;
            this.CheckTCPoverUDP.Text = "TCP over TCP if not checked";
            this.CheckTCPoverUDP.UseVisualStyleBackColor = true;
            this.CheckTCPoverUDP.Visible = false;
            // 
            // TCPProtocolComboBox
            // 
            this.TCPProtocolComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TCPProtocolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TCPProtocolComboBox.FormattingEnabled = true;
            this.TCPProtocolComboBox.Items.AddRange(new object[] {
            "origin",
            "verify_simple",
            "verify_deflate",
            "verify_sha1",
            "auth_sha1",
            "auth_sha1_v2"});
            this.TCPProtocolComboBox.Location = new System.Drawing.Point(118, 128);
            this.TCPProtocolComboBox.Name = "TCPProtocolComboBox";
            this.TCPProtocolComboBox.Size = new System.Drawing.Size(222, 25);
            this.TCPProtocolComboBox.TabIndex = 32;
            // 
            // labelObfsParam
            // 
            this.labelObfsParam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelObfsParam.AutoSize = true;
            this.labelObfsParam.Location = new System.Drawing.Point(26, 190);
            this.labelObfsParam.Name = "labelObfsParam";
            this.labelObfsParam.Size = new System.Drawing.Size(86, 17);
            this.labelObfsParam.TabIndex = 33;
            this.labelObfsParam.Text = "Obfs param";
            // 
            // textObfsParam
            // 
            this.textObfsParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textObfsParam.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textObfsParam.Location = new System.Drawing.Point(118, 186);
            this.textObfsParam.Name = "textObfsParam";
            this.textObfsParam.Size = new System.Drawing.Size(222, 25);
            this.textObfsParam.TabIndex = 35;
            // 
            // labelGroup
            // 
            this.labelGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(64, 252);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(48, 17);
            this.labelGroup.TabIndex = 33;
            this.labelGroup.Text = "Group";
            // 
            // TextGroup
            // 
            this.TextGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextGroup.Location = new System.Drawing.Point(118, 248);
            this.TextGroup.MaxLength = 32;
            this.TextGroup.Name = "TextGroup";
            this.TextGroup.Size = new System.Drawing.Size(222, 25);
            this.TextGroup.TabIndex = 12;
            this.TextGroup.WordWrap = false;
            // 
            // checkAdvSetting
            // 
            this.checkAdvSetting.AutoSize = true;
            this.checkAdvSetting.Location = new System.Drawing.Point(6, 310);
            this.checkAdvSetting.Name = "checkAdvSetting";
            this.checkAdvSetting.Size = new System.Drawing.Size(106, 21);
            this.checkAdvSetting.TabIndex = 37;
            this.checkAdvSetting.Text = "Adv. Setting";
            this.checkAdvSetting.UseVisualStyleBackColor = true;
            this.checkAdvSetting.CheckedChanged += new System.EventHandler(this.checkAdvSetting_CheckedChanged);
            // 
            // labelUDPPort
            // 
            this.labelUDPPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUDPPort.AutoSize = true;
            this.labelUDPPort.Location = new System.Drawing.Point(42, 341);
            this.labelUDPPort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelUDPPort.Name = "labelUDPPort";
            this.labelUDPPort.Size = new System.Drawing.Size(70, 17);
            this.labelUDPPort.TabIndex = 23;
            this.labelUDPPort.Text = "UDP Port";
            this.labelUDPPort.Visible = false;
            // 
            // textUDPPort
            // 
            this.textUDPPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textUDPPort.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textUDPPort.Location = new System.Drawing.Point(118, 337);
            this.textUDPPort.MaxLength = 10;
            this.textUDPPort.Name = "textUDPPort";
            this.textUDPPort.Size = new System.Drawing.Size(222, 25);
            this.textUDPPort.TabIndex = 1;
            this.textUDPPort.Visible = false;
            this.textUDPPort.WordWrap = false;
            // 
            // checkSSRLink
            // 
            this.checkSSRLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkSSRLink.AutoSize = true;
            this.checkSSRLink.Checked = true;
            this.checkSSRLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSSRLink.Location = new System.Drawing.Point(21, 281);
            this.checkSSRLink.Name = "checkSSRLink";
            this.checkSSRLink.Size = new System.Drawing.Size(91, 21);
            this.checkSSRLink.TabIndex = 38;
            this.checkSSRLink.Text = "SSR Link";
            this.checkSSRLink.UseVisualStyleBackColor = true;
            this.checkSSRLink.CheckedChanged += new System.EventHandler(this.checkSSRLink_CheckedChanged);
            // 
            // labelRemarks
            // 
            this.labelRemarks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Location = new System.Drawing.Point(44, 221);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(68, 17);
            this.labelRemarks.TabIndex = 39;
            this.labelRemarks.Text = "Remarks";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.MyCancelButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.OKButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(118, 449);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(159, 36);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.AutoSize = true;
            this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MyCancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MyCancelButton.Location = new System.Drawing.Point(84, 3);
            this.MyCancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.Size = new System.Drawing.Size(75, 33);
            this.MyCancelButton.TabIndex = 9;
            this.MyCancelButton.Text = "Cancel";
            this.MyCancelButton.UseVisualStyleBackColor = true;
            this.MyCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.AutoSize = true;
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.OKButton.Location = new System.Drawing.Point(3, 3);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 33);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(373, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(130, 0);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 34);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 34);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ServerGroupBox
            // 
            this.ServerGroupBox.AutoSize = true;
            this.ServerGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ServerGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.ServerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerGroupBox.Location = new System.Drawing.Point(268, 0);
            this.ServerGroupBox.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ServerGroupBox.Name = "ServerGroupBox";
            this.ServerGroupBox.Size = new System.Drawing.Size(357, 544);
            this.ServerGroupBox.TabIndex = 6;
            this.ServerGroupBox.TabStop = false;
            this.ServerGroupBox.Text = "Server";
            // 
            // PictureQRcode
            // 
            this.PictureQRcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureQRcode.BackColor = System.Drawing.SystemColors.Control;
            this.PictureQRcode.Location = new System.Drawing.Point(4, 169);
            this.PictureQRcode.Margin = new System.Windows.Forms.Padding(4);
            this.PictureQRcode.Name = "PictureQRcode";
            this.PictureQRcode.Size = new System.Drawing.Size(260, 200);
            this.PictureQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureQRcode.TabIndex = 13;
            this.PictureQRcode.TabStop = false;
            // 
            // ServersListBox
            // 
            this.ServersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServersListBox.FormattingEnabled = true;
            this.ServersListBox.IntegralHeight = false;
            this.ServersListBox.ItemHeight = 17;
            this.ServersListBox.Location = new System.Drawing.Point(0, 0);
            this.ServersListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ServersListBox.Name = "ServersListBox";
            this.ServersListBox.Size = new System.Drawing.Size(250, 320);
            this.ServersListBox.TabIndex = 5;
            this.ServersListBox.SelectedIndexChanged += new System.EventHandler(this.ServersListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ServerGroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 13);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(908, 544);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.ServersListBox, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.LinkUpdate, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(250, 538);
            this.tableLayoutPanel7.TabIndex = 16;
            // 
            // LinkUpdate
            // 
            this.LinkUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LinkUpdate.AutoSize = true;
            this.LinkUpdate.Location = new System.Drawing.Point(51, 457);
            this.LinkUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.LinkUpdate.Name = "LinkUpdate";
            this.LinkUpdate.Size = new System.Drawing.Size(148, 17);
            this.LinkUpdate.TabIndex = 15;
            this.LinkUpdate.TabStop = true;
            this.LinkUpdate.Text = "New version available";
            this.LinkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUpdate_LinkClicked);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.DownButton, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.UpButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.DeleteButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 325);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 68);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // DownButton
            // 
            this.DownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownButton.Location = new System.Drawing.Point(130, 34);
            this.DownButton.Margin = new System.Windows.Forms.Padding(0);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(120, 34);
            this.DownButton.TabIndex = 9;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(0, 34);
            this.UpButton.Margin = new System.Windows.Forms.Padding(0);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(120, 34);
            this.UpButton.TabIndex = 8;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.PictureQRcode, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(637, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(268, 538);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // ConfigForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(906, 544);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Servers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.Shown += new System.EventHandler(this.ConfigForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ServerGroupBox.ResumeLayout(false);
            this.ServerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureQRcode)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button AddButton;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.CheckBox checkAdvSetting;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.CheckBox CheckObfsUDP;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.CheckBox checkSSRLink;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.CheckBox CheckTCPoverUDP;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.CheckBox CheckUDPoverUDP;

		// Token: 0x04000007 RID: 7
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button DeleteButton;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button DownButton;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label EncryptionLabel;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.ComboBox EncryptionSelect;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label IPLabel;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.TextBox IPTextBox;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label labelGroup;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label LabelNote;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label labelObfs;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label labelObfsParam;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label labelRemarks;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label labelUDPPort;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.LinkLabel LinkUpdate;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Button MyCancelButton;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.ComboBox ObfsCombo;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label ObfsUDPLabel;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button OKButton;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.CheckBox PasswordLabel;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.TextBox PasswordTextBox;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.PictureBox PictureQRcode;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.TextBox RemarksTextBox;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.GroupBox ServerGroupBox;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label ServerPortLabel;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.TextBox ServerPortTextBox;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ListBox ServersListBox;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Label TCPoverUDPLabel;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.ComboBox TCPProtocolComboBox;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label TCPProtocolLabel;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.TextBox TextGroup;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.TextBox TextLink;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.TextBox textObfsParam;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.TextBox textUDPPort;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label UDPoverTCPLabel;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button UpButton;
	}
}
