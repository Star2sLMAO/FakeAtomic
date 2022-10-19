using System;
using System.Text.Json.Serialization;

namespace StormFN_Launcher.Epic
{
	// Token: 0x0200000D RID: 13
	public class Exchange
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00004A56 File Offset: 0x00002E56
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00004A5E File Offset: 0x00002E5E
		[JsonPropertyName("expiresInSeconds")]
		public int ExpiresInSeconds { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004A67 File Offset: 0x00002E67
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00004A6F File Offset: 0x00002E6F
		[JsonPropertyName("code")]
		public string Code { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00004A78 File Offset: 0x00002E78
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00004A80 File Offset: 0x00002E80
		[JsonPropertyName("creatingClientId")]
		public string CreatingClientId { get; set; }
	}
}
