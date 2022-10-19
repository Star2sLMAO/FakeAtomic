using System;

// Token: 0x0200001A RID: 26
internal struct 1AB8456E
{
	// Token: 0x06000106 RID: 262 RVA: 0x003A8DB8 File Offset: 0x001D91B8
	public void 55D17E04()
	{
		this.6A4155EA = 1024U;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x003A8DC8 File Offset: 0x001D91C8
	public uint 18827237(1ACD6604 023C70AE)
	{
		uint num = (023C70AE.4379281B >> 11) * this.6A4155EA;
		if (023C70AE.6E966A72 < num)
		{
			023C70AE.4379281B = num;
			this.6A4155EA += 2048U - this.6A4155EA >> 5;
			if (023C70AE.4379281B < 16777216U)
			{
				023C70AE.6E966A72 = (023C70AE.6E966A72 << 8 | (uint)((byte)023C70AE.43A361B7.ReadByte()));
				023C70AE.4379281B <<= 8;
			}
			return 0U;
		}
		023C70AE.4379281B -= num;
		023C70AE.6E966A72 -= num;
		this.6A4155EA -= this.6A4155EA >> 5;
		if (023C70AE.4379281B < 16777216U)
		{
			023C70AE.6E966A72 = (023C70AE.6E966A72 << 8 | (uint)((byte)023C70AE.43A361B7.ReadByte()));
			023C70AE.4379281B <<= 8;
		}
		return 1U;
	}

	// Token: 0x04000074 RID: 116
	private const int 28031F76 = 11;

	// Token: 0x04000075 RID: 117
	private const uint 307C683A = 2048U;

	// Token: 0x04000076 RID: 118
	private const int 4DBC4F75 = 5;

	// Token: 0x04000077 RID: 119
	private uint 6A4155EA;
}
