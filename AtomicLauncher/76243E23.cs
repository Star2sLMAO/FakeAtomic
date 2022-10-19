using System;
using System.Runtime.InteropServices;

// Token: 0x02000010 RID: 16
public class 76243E23
{
	// Token: 0x06000073 RID: 115 RVA: 0x00399FF4 File Offset: 0x00395FF4
	public 76243E23()
	{
		if (76243E23.736E1A39 == null)
		{
			76243E23.736E1A39 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				76243E23.736E1A39[i] = num;
			}
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0039A070 File Offset: 0x00396070
	public uint 47A51E0F(IntPtr 3BA95343, uint 026D7D78)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)026D7D78))
		{
			num = (76243E23.736E1A39[(int)(((uint)Marshal.ReadByte(new IntPtr(3BA95343.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x04000032 RID: 50
	private static uint[] 736E1A39;
}
