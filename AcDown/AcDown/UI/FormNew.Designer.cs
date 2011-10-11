﻿namespace Kaedei.AcDown.UI
{
	 partial class FormNew
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
           this.txtInput = new System.Windows.Forms.TextBox();
           this.label1 = new System.Windows.Forms.Label();
           this.btnAdd = new System.Windows.Forms.Button();
           this.picCheck = new System.Windows.Forms.PictureBox();
           this.toolTip = new System.Windows.Forms.ToolTip(this.components);
           this.lnkPaste = new System.Windows.Forms.LinkLabel();
           this.lblShowConfig = new System.Windows.Forms.LinkLabel();
           this.lnkSetProxy = new System.Windows.Forms.LinkLabel();
           this.chkFlvcd = new System.Windows.Forms.CheckBox();
           this.rdoDownSubOnly = new System.Windows.Forms.RadioButton();
           this.label2 = new System.Windows.Forms.Label();
           this.groupBox1 = new System.Windows.Forms.GroupBox();
           this.cboProxy = new System.Windows.Forms.ComboBox();
           this.txtPath = new System.Windows.Forms.TextBox();
           this.label3 = new System.Windows.Forms.Label();
           this.groupBox2 = new System.Windows.Forms.GroupBox();
           this.lblVideoType = new System.Windows.Forms.Label();
           this.cboVideoType = new System.Windows.Forms.ComboBox();
           this.txtExample = new System.Windows.Forms.TextBox();
           this.tabNew = new System.Windows.Forms.TabControl();
           this.tabConfig = new System.Windows.Forms.TabPage();
           this.tabOnline = new System.Windows.Forms.TabPage();
           this.tabSub = new System.Windows.Forms.TabPage();
           this.rdoDownSub = new System.Windows.Forms.RadioButton();
           this.rdoNotDownSub = new System.Windows.Forms.RadioButton();
           this.tabExample = new System.Windows.Forms.TabPage();
           ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
           this.groupBox1.SuspendLayout();
           this.groupBox2.SuspendLayout();
           this.tabNew.SuspendLayout();
           this.tabConfig.SuspendLayout();
           this.tabOnline.SuspendLayout();
           this.tabSub.SuspendLayout();
           this.tabExample.SuspendLayout();
           this.SuspendLayout();
           // 
           // txtInput
           // 
           this.txtInput.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
           this.txtInput.Location = new System.Drawing.Point(14, 50);
           this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.txtInput.Multiline = true;
           this.txtInput.Name = "txtInput";
           this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
           this.txtInput.Size = new System.Drawing.Size(434, 91);
           this.txtInput.TabIndex = 0;
           this.txtInput.Text = "http://";
           this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
           this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
           this.label1.Location = new System.Drawing.Point(15, 24);
           this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(106, 21);
           this.label1.TabIndex = 1;
           this.label1.Text = "请输入网址：";
           // 
           // btnAdd
           // 
           this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
           this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
           this.btnAdd.Location = new System.Drawing.Point(324, 148);
           this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.btnAdd.Name = "btnAdd";
           this.btnAdd.Size = new System.Drawing.Size(124, 37);
           this.btnAdd.TabIndex = 0;
           this.btnAdd.Text = "添加";
           this.toolTip.SetToolTip(this.btnAdd, "单击以确认新建此任务");
           this.btnAdd.UseVisualStyleBackColor = true;
           this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
           // 
           // picCheck
           // 
           this.picCheck.Image = global::Kaedei.AcDown.Properties.Resources._1;
           this.picCheck.Location = new System.Drawing.Point(124, 26);
           this.picCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.picCheck.Name = "picCheck";
           this.picCheck.Size = new System.Drawing.Size(19, 19);
           this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
           this.picCheck.TabIndex = 6;
           this.picCheck.TabStop = false;
           this.picCheck.Visible = false;
           // 
           // toolTip
           // 
           this.toolTip.AutoPopDelay = 8000;
           this.toolTip.InitialDelay = 500;
           this.toolTip.ReshowDelay = 100;
           this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
           this.toolTip.ToolTipTitle = "提示:";
           // 
           // lnkPaste
           // 
           this.lnkPaste.AutoSize = true;
           this.lnkPaste.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
           this.lnkPaste.Location = new System.Drawing.Point(342, 24);
           this.lnkPaste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
           this.lnkPaste.Name = "lnkPaste";
           this.lnkPaste.Size = new System.Drawing.Size(106, 21);
           this.lnkPaste.TabIndex = 9;
           this.lnkPaste.TabStop = true;
           this.lnkPaste.Text = "从剪贴板粘贴";
           this.toolTip.SetToolTip(this.lnkPaste, "如果系统剪贴板中有文字,\r\n则将剪贴板中文字粘贴入文本框");
           this.lnkPaste.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPaste_LinkClicked);
           // 
           // lblShowConfig
           // 
           this.lblShowConfig.AutoSize = true;
           this.lblShowConfig.Location = new System.Drawing.Point(334, 24);
           this.lblShowConfig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
           this.lblShowConfig.Name = "lblShowConfig";
           this.lblShowConfig.Size = new System.Drawing.Size(93, 20);
           this.lblShowConfig.TabIndex = 10;
           this.lblShowConfig.TabStop = true;
           this.lblShowConfig.Text = "更改保存位置";
           this.toolTip.SetToolTip(this.lblShowConfig, "更改默认保存下载文件的位置");
           this.lblShowConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowConfig_LinkClicked);
           // 
           // lnkSetProxy
           // 
           this.lnkSetProxy.AutoSize = true;
           this.lnkSetProxy.Location = new System.Drawing.Point(325, 93);
           this.lnkSetProxy.Name = "lnkSetProxy";
           this.lnkSetProxy.Size = new System.Drawing.Size(107, 20);
           this.lnkSetProxy.TabIndex = 14;
           this.lnkSetProxy.TabStop = true;
           this.lnkSetProxy.Text = "设置代理服务器";
           this.toolTip.SetToolTip(this.lnkSetProxy, "编辑代理服务器列表 ");
           this.lnkSetProxy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSetProxy_LinkClicked);
           // 
           // chkFlvcd
           // 
           this.chkFlvcd.Location = new System.Drawing.Point(14, 159);
           this.chkFlvcd.Name = "chkFlvcd";
           this.chkFlvcd.Size = new System.Drawing.Size(190, 25);
           this.chkFlvcd.TabIndex = 10;
           this.chkFlvcd.Text = "使用在线引擎解析视频";
           this.toolTip.SetToolTip(this.chkFlvcd, "遇到无法解析的网址，可以选择使用在线引擎来解析。\r\n目前在线解析引擎支持解析多达70多个网站，将近200多个网址示例");
           this.chkFlvcd.UseVisualStyleBackColor = true;
           this.chkFlvcd.CheckedChanged += new System.EventHandler(this.chkFlvcd_CheckedChanged);
           // 
           // rdoDownSubOnly
           // 
           this.rdoDownSubOnly.AutoSize = true;
           this.rdoDownSubOnly.Location = new System.Drawing.Point(22, 78);
           this.rdoDownSubOnly.Name = "rdoDownSubOnly";
           this.rdoDownSubOnly.Size = new System.Drawing.Size(131, 24);
           this.rdoDownSubOnly.TabIndex = 3;
           this.rdoDownSubOnly.TabStop = true;
           this.rdoDownSubOnly.Text = "只下载弹幕/字幕";
           this.toolTip.SetToolTip(this.rdoDownSubOnly, "针对弹幕网站的下载任务，下载时仅下载相应的弹幕/字幕文件，而不下载视频本身");
           this.rdoDownSubOnly.UseVisualStyleBackColor = true;
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(8, 24);
           this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(54, 20);
           this.label2.TabIndex = 8;
           this.label2.Text = "存储到:";
           // 
           // groupBox1
           // 
           this.groupBox1.Controls.Add(this.lnkSetProxy);
           this.groupBox1.Controls.Add(this.cboProxy);
           this.groupBox1.Controls.Add(this.txtPath);
           this.groupBox1.Controls.Add(this.lblShowConfig);
           this.groupBox1.Controls.Add(this.label3);
           this.groupBox1.Controls.Add(this.label2);
           this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
           this.groupBox1.Location = new System.Drawing.Point(3, 3);
           this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.groupBox1.Name = "groupBox1";
           this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.groupBox1.Size = new System.Drawing.Size(442, 168);
           this.groupBox1.TabIndex = 11;
           this.groupBox1.TabStop = false;
           this.groupBox1.Text = "设置";
           // 
           // cboProxy
           // 
           this.cboProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.cboProxy.FormattingEnabled = true;
           this.cboProxy.Location = new System.Drawing.Point(7, 116);
           this.cboProxy.Name = "cboProxy";
           this.cboProxy.Size = new System.Drawing.Size(420, 28);
           this.cboProxy.TabIndex = 12;
           // 
           // txtPath
           // 
           this.txtPath.Location = new System.Drawing.Point(12, 47);
           this.txtPath.Name = "txtPath";
           this.txtPath.ReadOnly = true;
           this.txtPath.Size = new System.Drawing.Size(415, 26);
           this.txtPath.TabIndex = 13;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Location = new System.Drawing.Point(3, 93);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(138, 20);
           this.label3.TabIndex = 11;
           this.label3.Text = "使用以下代理服务器:";
           // 
           // groupBox2
           // 
           this.groupBox2.Controls.Add(this.chkFlvcd);
           this.groupBox2.Controls.Add(this.txtInput);
           this.groupBox2.Controls.Add(this.picCheck);
           this.groupBox2.Controls.Add(this.btnAdd);
           this.groupBox2.Controls.Add(this.lnkPaste);
           this.groupBox2.Controls.Add(this.label1);
           this.groupBox2.Location = new System.Drawing.Point(12, 14);
           this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.groupBox2.Name = "groupBox2";
           this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.groupBox2.Size = new System.Drawing.Size(456, 195);
           this.groupBox2.TabIndex = 12;
           this.groupBox2.TabStop = false;
           this.groupBox2.Text = "下载";
           // 
           // lblVideoType
           // 
           this.lblVideoType.AutoSize = true;
           this.lblVideoType.Location = new System.Drawing.Point(25, 27);
           this.lblVideoType.Name = "lblVideoType";
           this.lblVideoType.Size = new System.Drawing.Size(93, 20);
           this.lblVideoType.TabIndex = 19;
           this.lblVideoType.Text = "视频清晰度：";
           // 
           // cboVideoType
           // 
           this.cboVideoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.cboVideoType.Enabled = false;
           this.cboVideoType.FlatStyle = System.Windows.Forms.FlatStyle.System;
           this.cboVideoType.FormattingEnabled = true;
           this.cboVideoType.Items.AddRange(new object[] {
            "普通 / 标清",
            "优酷高清 / 土豆360P",
            "优酷超清 / 土豆480P",
            "原画"});
           this.cboVideoType.Location = new System.Drawing.Point(120, 24);
           this.cboVideoType.Name = "cboVideoType";
           this.cboVideoType.Size = new System.Drawing.Size(189, 28);
           this.cboVideoType.TabIndex = 18;
           this.cboVideoType.SelectedIndexChanged += new System.EventHandler(this.cboVideoType_SelectedIndexChanged);
           // 
           // txtExample
           // 
           this.txtExample.Dock = System.Windows.Forms.DockStyle.Fill;
           this.txtExample.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
           this.txtExample.Location = new System.Drawing.Point(3, 3);
           this.txtExample.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.txtExample.Multiline = true;
           this.txtExample.Name = "txtExample";
           this.txtExample.ScrollBars = System.Windows.Forms.ScrollBars.Both;
           this.txtExample.Size = new System.Drawing.Size(442, 168);
           this.txtExample.TabIndex = 13;
           // 
           // tabNew
           // 
           this.tabNew.Controls.Add(this.tabConfig);
           this.tabNew.Controls.Add(this.tabOnline);
           this.tabNew.Controls.Add(this.tabSub);
           this.tabNew.Controls.Add(this.tabExample);
           this.tabNew.Location = new System.Drawing.Point(12, 217);
           this.tabNew.Name = "tabNew";
           this.tabNew.SelectedIndex = 0;
           this.tabNew.Size = new System.Drawing.Size(456, 207);
           this.tabNew.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
           this.tabNew.TabIndex = 14;
           // 
           // tabConfig
           // 
           this.tabConfig.Controls.Add(this.groupBox1);
           this.tabConfig.Location = new System.Drawing.Point(4, 29);
           this.tabConfig.Name = "tabConfig";
           this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
           this.tabConfig.Size = new System.Drawing.Size(448, 174);
           this.tabConfig.TabIndex = 1;
           this.tabConfig.Text = "下载设置";
           this.tabConfig.UseVisualStyleBackColor = true;
           // 
           // tabOnline
           // 
           this.tabOnline.Controls.Add(this.lblVideoType);
           this.tabOnline.Controls.Add(this.cboVideoType);
           this.tabOnline.Location = new System.Drawing.Point(4, 29);
           this.tabOnline.Name = "tabOnline";
           this.tabOnline.Padding = new System.Windows.Forms.Padding(3);
           this.tabOnline.Size = new System.Drawing.Size(448, 174);
           this.tabOnline.TabIndex = 0;
           this.tabOnline.Text = "在线解析";
           this.tabOnline.UseVisualStyleBackColor = true;
           // 
           // tabSub
           // 
           this.tabSub.Controls.Add(this.rdoDownSubOnly);
           this.tabSub.Controls.Add(this.rdoDownSub);
           this.tabSub.Controls.Add(this.rdoNotDownSub);
           this.tabSub.Location = new System.Drawing.Point(4, 29);
           this.tabSub.Name = "tabSub";
           this.tabSub.Padding = new System.Windows.Forms.Padding(3);
           this.tabSub.Size = new System.Drawing.Size(448, 174);
           this.tabSub.TabIndex = 3;
           this.tabSub.Text = "弹幕/字幕";
           this.tabSub.UseVisualStyleBackColor = true;
           // 
           // rdoDownSub
           // 
           this.rdoDownSub.AutoSize = true;
           this.rdoDownSub.Location = new System.Drawing.Point(22, 18);
           this.rdoDownSub.Name = "rdoDownSub";
           this.rdoDownSub.Size = new System.Drawing.Size(117, 24);
           this.rdoDownSub.TabIndex = 2;
           this.rdoDownSub.Text = "下载弹幕/字幕";
           this.rdoDownSub.UseVisualStyleBackColor = true;
           // 
           // rdoNotDownSub
           // 
           this.rdoNotDownSub.AutoSize = true;
           this.rdoNotDownSub.Location = new System.Drawing.Point(22, 48);
           this.rdoNotDownSub.Name = "rdoNotDownSub";
           this.rdoNotDownSub.Size = new System.Drawing.Size(131, 24);
           this.rdoNotDownSub.TabIndex = 1;
           this.rdoNotDownSub.Text = "不下载弹幕/字幕";
           this.rdoNotDownSub.UseVisualStyleBackColor = true;
           // 
           // tabExample
           // 
           this.tabExample.Controls.Add(this.txtExample);
           this.tabExample.Location = new System.Drawing.Point(4, 29);
           this.tabExample.Name = "tabExample";
           this.tabExample.Padding = new System.Windows.Forms.Padding(3);
           this.tabExample.Size = new System.Drawing.Size(448, 174);
           this.tabExample.TabIndex = 2;
           this.tabExample.Text = "网址示例";
           this.tabExample.UseVisualStyleBackColor = true;
           // 
           // FormNew
           // 
           this.AcceptButton = this.btnAdd;
           this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(481, 434);
           this.Controls.Add(this.groupBox2);
           this.Controls.Add(this.tabNew);
           this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
           this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.MaximizeBox = false;
           this.MinimizeBox = false;
           this.Name = "FormNew";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "新建下载任务";
           this.TopMost = true;
           this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNew_FormClosing);
           this.Load += new System.EventHandler(this.FormNew_Load);
           ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
           this.groupBox1.ResumeLayout(false);
           this.groupBox1.PerformLayout();
           this.groupBox2.ResumeLayout(false);
           this.groupBox2.PerformLayout();
           this.tabNew.ResumeLayout(false);
           this.tabConfig.ResumeLayout(false);
           this.tabOnline.ResumeLayout(false);
           this.tabOnline.PerformLayout();
           this.tabSub.ResumeLayout(false);
           this.tabSub.PerformLayout();
           this.tabExample.ResumeLayout(false);
           this.tabExample.PerformLayout();
           this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.TextBox txtInput;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Button btnAdd;
		  private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.LinkLabel lblShowConfig;
		  private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.LinkLabel lnkPaste;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ComboBox cboProxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkSetProxy;
        private System.Windows.Forms.CheckBox chkFlvcd;
        private System.Windows.Forms.TabControl tabNew;
        private System.Windows.Forms.TabPage tabOnline;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabPage tabExample;
        private System.Windows.Forms.Label lblVideoType;
        private System.Windows.Forms.ComboBox cboVideoType;
        private System.Windows.Forms.TabPage tabSub;
        private System.Windows.Forms.RadioButton rdoDownSubOnly;
        private System.Windows.Forms.RadioButton rdoDownSub;
        private System.Windows.Forms.RadioButton rdoNotDownSub;
	 }
}