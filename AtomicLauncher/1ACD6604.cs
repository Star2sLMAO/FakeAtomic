using System;
using System.IO;

// Token: 0x02000019 RID: 25
internal class 1ACD6604
{
	// Token: 0x06000102 RID: 258 RVA: 0x003A8CD0 File Offset: 0x001D90D0
	public void 74257AE4(Stream 6ECE27EE)
	{
		this.43A361B7 = 6ECE27EE;
		this.6E966A72 = 0U;
		this.4379281B = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.6E966A72 = (this.6E966A72 << 8 | (uint)((byte)this.43A361B7.ReadByte()));
		}
	}

	// Token: 0x06000103 RID: 259 RVA: 0x003A8D20 File Offset: 0x001D9120
	public void 11F54EC2()
	{
		this.43A361B7 = null;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x003A8D2C File Offset: 0x001D912C
	public uint 468F7801(int 2727601D)
	{
		uint num = this.4379281B;
		uint num2 = this.6E966A72;
		uint num3 = 0U;
		for (int i = 2727601D; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.43A361B7.ReadByte()));
				num <<= 8;
			}
		}
		this.4379281B = num;
		this.6E966A72 = num2;
		return num3;
	}

	// Token: 0x0400006F RID: 111
	private uint 2E0C43B9 = 1U;

	// Token: 0x04000070 RID: 112
	public const uint 06716C7B = 16777216U;

	// Token: 0x04000071 RID: 113
	public uint 4379281B;

	// Token: 0x04000072 RID: 114
	public uint 6E966A72;

	// Token: 0x04000073 RID: 115
	public Stream 43A361B7;
}
