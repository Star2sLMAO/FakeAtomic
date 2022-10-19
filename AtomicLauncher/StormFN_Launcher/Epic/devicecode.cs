using System;
using System.Text.Json.Serialization;

namespace StormFN_Launcher.Epic
{
	// Token: 0x0200000C RID: 12
	public class devicecode
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000049CE File Offset: 0x00002DCE
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000049D6 File Offset: 0x00002DD6
		[JsonPropertyName("user_code")]
		public int user_code { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000049DF File Offset: 0x00002DDF
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000049E7 File Offset: 0x00002DE7
		[JsonPropertyName("device_code")]
		public string device_code { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000049F0 File Offset: 0x00002DF0
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000049F8 File Offset: 0x00002DF8
		[JsonPropertyName("verification_uri")]
		public string verification_uri { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00004A01 File Offset: 0x00002E01
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00004A09 File Offset: 0x00002E09
		[JsonPropertyName("verification_uri_complete")]
		public string verification_uri_complete { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00004A12 File Offset: 0x00002E12
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00004A1A File Offset: 0x00002E1A
		[JsonPropertyName("prompt")]
		public string prompt { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00004A23 File Offset: 0x00002E23
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00004A2B File Offset: 0x00002E2B
		[JsonPropertyName("expires_in")]
		public string expires_in { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00004A34 File Offset: 0x00002E34
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00004A3C File Offset: 0x00002E3C
		[JsonPropertyName("interval")]
		public string interval { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00004A45 File Offset: 0x00002E45
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00004A4D File Offset: 0x00002E4D
		[JsonPropertyName("client_id")]
		public string client_id { get; set; }
	}
}
