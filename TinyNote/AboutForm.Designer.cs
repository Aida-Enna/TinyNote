﻿namespace TinyNote
{
	partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.githubBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.copyrightBtn = new System.Windows.Forms.Label();
            this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.donateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(9, 169);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(239, 21);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "TinyNote";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            // 
            // versionLabel
            // 
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(106)))), ((int)(((byte)(29)))));
            this.versionLabel.Location = new System.Drawing.Point(9, 199);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(239, 17);
            this.versionLabel.TabIndex = 14;
            this.versionLabel.Text = "Sticky Notes v{0}";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.versionLabel_MouseDown);
            // 
            // githubBtn
            // 
            this.githubBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(192)))), ((int)(((byte)(52)))));
            this.githubBtn.FlatAppearance.BorderSize = 0;
            this.githubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.githubBtn.Image = global::TinyNote.Properties.Resources.black_github;
            this.githubBtn.Location = new System.Drawing.Point(9, 234);
            this.githubBtn.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.githubBtn.Name = "githubBtn";
            this.githubBtn.Size = new System.Drawing.Size(115, 32);
            this.githubBtn.TabIndex = 1;
            this.githubBtn.Text = " Contribute";
            this.githubBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.githubBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.infoToolTip.SetToolTip(this.githubBtn, "Open GitHub repository of this app");
            this.githubBtn.UseVisualStyleBackColor = false;
            this.githubBtn.Click += new System.EventHandler(this.githubBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = global::TinyNote.Properties.Resources.black_close;
            this.closeBtn.Location = new System.Drawing.Point(225, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 32);
            this.closeBtn.TabIndex = 0;
            this.infoToolTip.SetToolTip(this.closeBtn, "Close (Alt+F4)");
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // copyrightBtn
            // 
            this.copyrightBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(106)))), ((int)(((byte)(29)))));
            this.copyrightBtn.Location = new System.Drawing.Point(9, 284);
            this.copyrightBtn.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.copyrightBtn.Name = "copyrightBtn";
            this.copyrightBtn.Size = new System.Drawing.Size(239, 17);
            this.copyrightBtn.TabIndex = 16;
            this.copyrightBtn.Text = "Originally created by Module Art";
            this.copyrightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.copyrightBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.copyrightBtn_MouseDown);
            // 
            // donateBtn
            // 
            this.donateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(192)))), ((int)(((byte)(52)))));
            this.donateBtn.FlatAppearance.BorderSize = 0;
            this.donateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donateBtn.Image = global::TinyNote.Properties.Resources.black_donate;
            this.donateBtn.Location = new System.Drawing.Point(130, 234);
            this.donateBtn.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.donateBtn.Name = "donateBtn";
            this.donateBtn.Size = new System.Drawing.Size(118, 32);
            this.donateBtn.TabIndex = 3;
            this.donateBtn.Text = " Donate";
            this.donateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.donateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.infoToolTip.SetToolTip(this.donateBtn, "Buy me a coffe (Patreon)");
            this.donateBtn.UseVisualStyleBackColor = false;
            this.donateBtn.Click += new System.EventHandler(this.donateBtn_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(257, 311);
            this.Controls.Add(this.donateBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.copyrightBtn);
            this.Controls.Add(this.githubBtn);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AboutForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Button githubBtn;
		private System.Windows.Forms.Label copyrightBtn;
		private System.Windows.Forms.ToolTip infoToolTip;
		private System.Windows.Forms.Button donateBtn;
	}
}