using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace StormFN_Launcher
{
	// Token: 0x02000008 RID: 8
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
	internal sealed partial class Config_file : ApplicationSettingsBase
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000435C File Offset: 0x0000275C
		public static Config_file Default
		{
			get
			{
				return Config_file.defaultInstance;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00004374 File Offset: 0x00002774
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002092 File Offset: 0x00000492
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Path
		{
			get
			{
				return (string)this["Path"];
			}
			set
			{
				this["Path"] = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004398 File Offset: 0x00002798
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000020C6 File Offset: 0x000004C6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool Show
		{
			get
			{
				return (bool)this["Show"];
			}
			set
			{
				this["Show"] = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000043BC File Offset: 0x000027BC
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000020FE File Offset: 0x000004FE
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AC_bypass
		{
			get
			{
				return (bool)this["AC_bypass"];
			}
			set
			{
				this["AC_bypass"] = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000043E0 File Offset: 0x000027E0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002136 File Offset: 0x00000536
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Email
		{
			get
			{
				return (string)this["Email"];
			}
			set
			{
				this["Email"] = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00004404 File Offset: 0x00002804
		// (set) Token: 0x0600003B RID: 59 RVA: 0x0000216A File Offset: 0x0000056A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Imgpath
		{
			get
			{
				return (string)this["Imgpath"];
			}
			set
			{
				this["Imgpath"] = value;
			}
		}

		// Token: 0x04000017 RID: 23
		private static Config_file defaultInstance = (Config_file)SettingsBase.Synchronized(new Config_file());
	}
}
