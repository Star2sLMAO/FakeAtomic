namespace AtomicLauncher
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000026D8 File Offset: 0x00000AD8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002710 File Offset: 0x00000B10
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AtomicLauncher.Form1));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2TextBox2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2GradientButton2 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			base.SuspendLayout();
			this.panel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel1.BackgroundImage");
			this.panel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Location = new global::System.Drawing.Point(166, 35);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(427, 197);
			this.panel1.TabIndex = 0;
			this.guna2GradientButton1.BorderRadius = 15;
			this.guna2GradientButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton1.FillColor = global::System.Drawing.Color.FromArgb(192, 0, 192);
			this.guna2GradientButton1.FillColor2 = global::System.Drawing.Color.Blue;
			this.guna2GradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientButton1.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton1.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.guna2GradientButton1.Location = new global::System.Drawing.Point(210, 342);
			this.guna2GradientButton1.Name = "guna2GradientButton1";
			this.guna2GradientButton1.Size = new global::System.Drawing.Size(160, 66);
			this.guna2GradientButton1.TabIndex = 14;
			this.guna2GradientButton1.Text = "Login to Atomic";
			this.guna2GradientButton1.Click += new global::System.EventHandler(this.guna2GradientButton1_Click);
			this.guna2Button1.BorderRadius = 15;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.White;
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button1.Location = new global::System.Drawing.Point(489, 259);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(78, 52);
			this.guna2Button1.TabIndex = 13;
			this.guna2Button1.Text = "...";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.guna2TextBox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox2.DefaultText = "";
			this.guna2TextBox2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox2.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox2.Location = new global::System.Drawing.Point(194, 259);
			this.guna2TextBox2.Margin = new global::System.Windows.Forms.Padding(5, 5, 5, 5);
			this.guna2TextBox2.Name = "guna2TextBox2";
			this.guna2TextBox2.PasswordChar = '\0';
			this.guna2TextBox2.PlaceholderText = "Game Path";
			this.guna2TextBox2.SelectedText = "";
			this.guna2TextBox2.Size = new global::System.Drawing.Size(287, 52);
			this.guna2TextBox2.TabIndex = 12;
			this.guna2GradientButton2.BorderRadius = 15;
			this.guna2GradientButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton2.FillColor = global::System.Drawing.Color.FromArgb(192, 0, 192);
			this.guna2GradientButton2.FillColor2 = global::System.Drawing.Color.Blue;
			this.guna2GradientButton2.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientButton2.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton2.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.guna2GradientButton2.Location = new global::System.Drawing.Point(396, 342);
			this.guna2GradientButton2.Name = "guna2GradientButton2";
			this.guna2GradientButton2.Size = new global::System.Drawing.Size(160, 66);
			this.guna2GradientButton2.TabIndex = 15;
			this.guna2GradientButton2.Text = "Change Stats";
			this.guna2GradientButton2.Click += new global::System.EventHandler(this.guna2GradientButton2_Click);
			this.guna2Button2.BorderRadius = 15;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = global::System.Drawing.Color.White;
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button2.Location = new global::System.Drawing.Point(746, 12);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new global::System.Drawing.Size(42, 38);
			this.guna2Button2.TabIndex = 16;
			this.guna2Button2.Text = "X";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.guna2Button3.BorderRadius = 15;
			this.guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.FillColor = global::System.Drawing.Color.White;
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button3.Location = new global::System.Drawing.Point(698, 12);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new global::System.Drawing.Size(42, 38);
			this.guna2Button3.TabIndex = 17;
			this.guna2Button3.Text = "-";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.guna2GradientButton2);
			base.Controls.Add(this.guna2GradientButton1);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.guna2TextBox2);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form1";
			base.Opacity = 0.85;
			this.Text = "MainForm";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000004 RID: 4
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;

		// Token: 0x04000005 RID: 5
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000006 RID: 6
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;

		// Token: 0x04000007 RID: 7
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;

		// Token: 0x04000008 RID: 8
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x04000009 RID: 9
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;
	}
}
