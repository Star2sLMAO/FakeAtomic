using System;

// Token: 0x0200001B RID: 27
internal struct 4AF73F26
{
	// Token: 0x06000108 RID: 264 RVA: 0x003A8EBC File Offset: 0x003A4EBC
	public 4AF73F26(int 3C944A2C)
	{
		this.6CBD72FA = 3C944A2C;
		this.34F73BA7 = new 1AB8456E[1 << 3C944A2C];
	}

	// Token: 0x06000109 RID: 265 RVA: 0x003A8ED8 File Offset: 0x003A4ED8
	public void 36432CE0()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.6CBD72FA & 31)))
		{
			this.34F73BA7[(int)num].55D17E04();
			num += 1U;
		}
	}

	// Token: 0x0600010A RID: 266 RVA: 0x003A8F14 File Offset: 0x003A4F14
	public uint 705B3E67(1ACD6604 0A3A13FD)
	{
		uint num = 1U;
		for (int i = this.6CBD72FA; i > 0; i--)
		{
			num = (num << 1) + this.34F73BA7[(int)num].18827237(0A3A13FD);
		}
		return num - (1U << this.6CBD72FA);
	}

	// Token: 0x0600010B RID: 267 RVA: 0x003A8F60 File Offset: 0x003A4F60
	public uint 1F7C1C85(1ACD6604 4B9D4DF3)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < this.6CBD72FA; i++)
		{
			uint num3 = this.34F73BA7[(int)num].18827237(4B9D4DF3);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x003A8FB0 File Offset: 0x003A4FB0
	public static uint 7EBE5D84(1AB8456E[] 1383448A, uint 360076EA, 1ACD6604 4B77425D, int 10B71A78)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < 10B71A78; i++)
		{
			uint num3 = 1383448A[(int)(360076EA + num)].18827237(4B77425D);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x04000078 RID: 120
	private readonly 1AB8456E[] 34F73BA7;

	// Token: 0x04000079 RID: 121
	private readonly int 6CBD72FA;
}
