using System;
using System.Runtime.InteropServices;

// Token: 0x02000016 RID: 22
internal static class 582A2C78
{
	// Token: 0x060000EE RID: 238
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFile", SetLastError = true)]
	public static extern IntPtr 69D170ED(string 18496060, int 2B44670E, int 0C80472C, IntPtr 35CC6EF3, int 519D67AF, int 71F419A8, IntPtr 0B3607F7);

	// Token: 0x060000EF RID: 239
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFileMapping", SetLastError = true)]
	public static extern IntPtr 14515D6B(IntPtr 3B210C4D, IntPtr 63FE19BE, 582A2C78.2E982FB5 26B80707, int 5A9523EC, int 578F3AA2, string 50A5655D);

	// Token: 0x060000F0 RID: 240
	[DllImport("kernel32", EntryPoint = "MapViewOfFile", SetLastError = true)]
	public static extern IntPtr 07C8325A(IntPtr 25A2217A, 582A2C78.368C5C3C 102A14E3, int 6E085F9B, int 3B11628F, IntPtr 1F256E27);

	// Token: 0x060000F1 RID: 241
	[DllImport("kernel32", EntryPoint = "UnmapViewOfFile", SetLastError = true)]
	public static extern bool 65117C88(IntPtr 59051E2C);

	// Token: 0x060000F2 RID: 242
	[DllImport("kernel32", EntryPoint = "CloseHandle", SetLastError = true)]
	public static extern bool 3D0C35BA(IntPtr 552015F8);

	// Token: 0x060000F3 RID: 243
	[DllImport("kernel32", EntryPoint = "GetFileSize", SetLastError = true)]
	public static extern uint 702F19C4(IntPtr 7786270D, IntPtr 1A977D87);

	// Token: 0x060000F4 RID: 244
	[DllImport("kernel32", EntryPoint = "VirtualProtect", SetLastError = true)]
	public static extern bool 57D946E2(IntPtr 103B0909, UIntPtr 21924E0C, 582A2C78.2E982FB5 29896AC3, out 582A2C78.2E982FB5 08B633E7);

	// Token: 0x060000F5 RID: 245
	[DllImport("kernel32", EntryPoint = "IsDebuggerPresent")]
	public static extern bool 587F6739();

	// Token: 0x060000F6 RID: 246
	[DllImport("kernel32", EntryPoint = "CheckRemoteDebuggerPresent")]
	public static extern bool 59EA44A4();

	// Token: 0x060000F7 RID: 247
	[DllImport("ntdll", EntryPoint = "NtQueryInformationProcess")]
	public static extern int 1DC2617B(IntPtr 6564312F, int 00BC3E3F, byte[] 72657C51, uint 662161E9, out uint 131D6148);

	// Token: 0x04000045 RID: 69
	public const int 231E238B = -2147483648;

	// Token: 0x04000046 RID: 70
	public const int 2FAA058C = 3;

	// Token: 0x04000047 RID: 71
	public const int 6DDA2D01 = 128;

	// Token: 0x04000048 RID: 72
	public const int 25877F74 = 1;

	// Token: 0x04000049 RID: 73
	public const int 36DF51FF = 2;

	// Token: 0x0400004A RID: 74
	public static readonly IntPtr 49A91FFB = new IntPtr(-1);

	// Token: 0x0400004B RID: 75
	public static readonly IntPtr 5BCA47F8 = IntPtr.Zero;

	// Token: 0x0400004C RID: 76
	public static readonly IntPtr 50C709C3 = new IntPtr(-1);

	// Token: 0x0200003D RID: 61
	public enum 2E982FB5 : uint
	{
		// Token: 0x040000AB RID: 171
		249E4C4A = 1U,
		// Token: 0x040000AC RID: 172
		18CD5EA5,
		// Token: 0x040000AD RID: 173
		69255AF6 = 4U,
		// Token: 0x040000AE RID: 174
		21444C0C = 8U,
		// Token: 0x040000AF RID: 175
		1FCF00A4 = 16U,
		// Token: 0x040000B0 RID: 176
		007935E8 = 32U,
		// Token: 0x040000B1 RID: 177
		63046EE7 = 64U,
		// Token: 0x040000B2 RID: 178
		5F4728FD = 256U
	}

	// Token: 0x0200003E RID: 62
	public enum 368C5C3C : uint
	{
		// Token: 0x040000B4 RID: 180
		085D518F = 1U,
		// Token: 0x040000B5 RID: 181
		4DBC6EDC,
		// Token: 0x040000B6 RID: 182
		33B17100 = 4U,
		// Token: 0x040000B7 RID: 183
		485E3C58 = 31U
	}
}
