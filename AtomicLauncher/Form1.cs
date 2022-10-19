using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.WindowsAPICodePack.Dialogs;
using StormFN_Launcher.Epic;
using StormFN_Launcher.Services;

namespace AtomicLauncher
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000021CD File Offset: 0x000005CD
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021E8 File Offset: 0x000005E8
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

		// Token: 0x06000014 RID: 20 RVA: 0x0000223C File Offset: 0x0000063C
		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			string path = Directory.GetCurrentDirectory() + "\\";
			string arg = Directory.GetCurrentDirectory() + "\\Atomic.dll";
			WebClient webClient = new WebClient();
			Config_file.Default.Path = this.guna2TextBox2.Text;
			base.Hide();
			string devicecode = Auth.GetDevicecode(Auth.GetDevicecodetoken());
			string[] array = devicecode.Split(new char[]
			{
				','
			}, 2);
			bool flag = devicecode.Contains("error");
			if (!flag)
			{
				string str = array[1];
				string text = (string)(array[1] ?? "");
				string token = array[0];
				string exchange = Auth.GetExchange(token);
				new ToastContentBuilder().AddText("Successfully logged in as " + str + "!", null, null, null, null, null, null).AddText("Going into fortnite...", null, null, null, null, null, null).Show();
				string text2 = Path.Combine(Config_file.Default.Path, "FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe");
				string fileName = Path.Combine(Config_file.Default.Path, "FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe");
				string fileName2 = Path.Combine(Config_file.Default.Path, "FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe");
				bool flag2 = !File.Exists(text2);
				if (flag2)
				{
					MessageBox.Show("Please enter valid path");
				}
				else
				{
					exchange = Auth.GetExchange(token);
					string arguments = "-AUTH_LOGIN=unused -AUTH_PASSWORD=" + exchange + " -AUTH_TYPE=exchangecode -epicapp=Fortnite -epicportal -nobe -fromfl=eac -fltoken=020912211c40g052474d02f1 -skippatchcheck -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiYmU5ZGE1YzJmYmVhNDQwN2IyZjQwZWJhYWQ4NTlhZDQiLCJnZW5lcmF0ZWQiOjE2Mzg3MTcyNzgsImNhbGRlcmFHdWlkIjoiMzgxMGI4NjMtMmE2NS00NDU3LTliNTgtNGRhYjNiNDgyYTg2IiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.VAWQB67RTxhiWOxx7DBjnzDnXyyEnX7OljJm-j2d88G_WgwQ9wrE6lwMEHZHjBd1ISJdUO1UVUqkfLdU5nofBQ -fltoken=3db3ba5dcbd2e16703f3978d";
					Process process = new Process
					{
						StartInfo = new ProcessStartInfo(text2, arguments)
						{
							UseShellExecute = false,
							RedirectStandardOutput = false,
							CreateNoWindow = true
						}
					};
					Process process2 = new Process();
					process2.StartInfo.FileName = fileName2;
					process2.Start();
					Process process3 = new Process();
					process3.StartInfo.FileName = fileName;
					process3.StartInfo.Arguments = "-epiclocale=en -noeac -fromfl=be -fltoken=7d05d6869798a086b4bb6222 -frombe";
					process3.Start();
					foreach (object obj in process3.Threads)
					{
						ProcessThread processThread = (ProcessThread)obj;
						Win32.SuspendThread(Win32.OpenThread(2, false, processThread.Id));
					}
					process.Start();
					Thread.Sleep(2000);
					base.Hide();
					Thread.Sleep(8000);
					try
					{
						File.Delete(tempPath + "/Injector.exe");
					}
					catch
					{
					}
					try
					{
						webClient.DownloadFile("https://cdn.discordapp.com/attachments/823233042788122685/828311722036690984/Injector.exe", tempPath + "/Injector.exe");
					}
					catch
					{
						MessageBox.Show("Please Run Launcher as Administrator and turn off Antivirus.");
						return;
					}
					process.WaitForInputIdle();
					string text3 = Path.Combine(path, "S13.dll");
					new Process
					{
						StartInfo = 
						{
							Arguments = string.Format("\"{0}\" \"{1}\"", process.Id, arg),
							CreateNoWindow = true,
							UseShellExecute = false,
							FileName = tempPath + "/Injector.exe"
						}
					}.Start();
					Thread.Sleep(25000);
					process.WaitForExit();
					try
					{
						process2.Close();
						process3.Close();
					}
					catch
					{
					}
					base.Show();
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002628 File Offset: 0x00000A28
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
			commonOpenFileDialog.IsFolderPicker = true;
			bool flag = commonOpenFileDialog.ShowDialog() == 1;
			if (flag)
			{
				this.guna2TextBox2.Text = commonOpenFileDialog.FileName;
			}
			bool flag2 = !Directory.Exists(this.guna2TextBox2.Text + "\\FortniteGame");
			if (flag2)
			{
				MessageBox.Show("Invalid path! Please input valid path that contains \"FortniteGame\" and \"Engine\"");
				this.guna2TextBox2.Text = string.Empty;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000026A4 File Offset: 0x00000AA4
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000026A7 File Offset: 0x00000AA7
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000026B0 File Offset: 0x00000AB0
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000026BC File Offset: 0x00000ABC
		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.Show();
		}
	}
}
