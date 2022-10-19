using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AtomicLauncher
{
	// Token: 0x02000002 RID: 2
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
	internal sealed partial class Config_file : ApplicationSettingsBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00000458
		public static Config_file Default
		{
			get
			{
				return Config_file.defaultInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002070 File Offset: 0x00000470
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002092 File Offset: 0x00000492
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020A4 File Offset: 0x000004A4
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000020C6 File Offset: 0x000004C6
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020DC File Offset: 0x000004DC
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000020FE File Offset: 0x000004FE
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002114 File Offset: 0x00000514
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002136 File Offset: 0x00000536
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

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002148 File Offset: 0x00000548
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000216A File Offset: 0x0000056A
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

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000217C File Offset: 0x0000057C
		// (set) Token: 0x0600000F RID: 15 RVA: 0x0000219E File Offset: 0x0000059E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Accid
		{
			get
			{
				return (string)this["Accid"];
			}
			set
			{
				this["Accid"] = value;
			}
		}

		// Token: 0x04000001 RID: 1
		private static Config_file defaultInstance = (Config_file)SettingsBase.Synchronized(new Config_file());
	}
}
