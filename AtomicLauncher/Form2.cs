using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Toolkit.Uwp.Notifications;
using RestSharp;

namespace AtomicLauncher
{
	// Token: 0x02000004 RID: 4
	public partial class Form2 : Form
	{
		// Token: 0x0600001C RID: 28 RVA: 0x0000317B File Offset: 0x0000157B
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003194 File Offset: 0x00001594
		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			int num = msg;
			if (num != 132)
			{
				base.WndProc(ref m);
			}
			else
			{
				base.WndProc(ref m);
				bool flag = (int)m.Result == 1;
				if (flag)
				{
					m.Result = (IntPtr)2;
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000031E6 File Offset: 0x000015E6
		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=mq9qXeT8Y5g");
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000031F4 File Offset: 0x000015F4
		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
			Config_file.Default.Accid = this.guna2TextBox1.Text;
			string text = "https://atomicbackend.raxterxpsycho.repl.co/endpoints/vbucks/" + this.guna2TextBox1.Text + "/" + this.guna2TextBox2.Text;
			IRestClient restClient = new RestClient();
			IRestRequest restRequest = new RestRequest(text);
			RestClientExtensions.Get(restClient, restRequest);
			new ToastContentBuilder().AddText("Applied Your Vbucks As " + this.guna2TextBox2.Text + "!", null, null, null, null, null, null).AddText("Restart Fn For This To Show", null, null, null, null, null, null).Show();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000032EC File Offset: 0x000016EC
		private void guna2GradientButton3_Click(object sender, EventArgs e)
		{
			Config_file.Default.Accid = this.guna2TextBox1.Text;
			string text = "https://atomicbackend.raxterxpsycho.repl.co/endpoints/level/" + this.guna2TextBox1.Text + "/" + this.guna2TextBox3.Text;
			IRestClient restClient = new RestClient();
			IRestRequest restRequest = new RestRequest(text);
			RestClientExtensions.Get(restClient, restRequest);
			new ToastContentBuilder().AddText("Applied Your Level As " + this.guna2TextBox3.Text + "!", null, null, null, null, null, null).AddText("Change Any Cosmetic or Restart Fn For This To Show", null, null, null, null, null, null).Show();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000033E3 File Offset: 0x000017E3
		private void Form2_Load(object sender, EventArgs e)
		{
			this.guna2TextBox1.Text = Config_file.Default.Accid;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000033FC File Offset: 0x000017FC
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000026B0 File Offset: 0x00000AB0
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}
	}
}
