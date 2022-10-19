using System;
using System.IO;

// Token: 0x0200001C RID: 28
public class 18F62D5D
{
	// Token: 0x0600010D RID: 269 RVA: 0x003A8FF8 File Offset: 0x001D93F8
	public void 0BC351AC(uint 3B142C25)
	{
		if (this.6FE575D2 != 3B142C25)
		{
			this.0078138B = new byte[3B142C25];
		}
		this.6FE575D2 = 3B142C25;
		this.4DFA4C26 = 0U;
		this.6CBF194C = 0U;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x003A9028 File Offset: 0x001D9428
	public void 00CF443C(Stream 7D025E2E, bool 3F924C1C)
	{
		this.4D2527CD();
		this.1D5B7AFE = 7D025E2E;
		if (!3F924C1C)
		{
			this.6CBF194C = 0U;
			this.4DFA4C26 = 0U;
			this.075607EC = 0U;
		}
	}

	// Token: 0x0600010F RID: 271 RVA: 0x003A9054 File Offset: 0x001D9454
	public void 4D2527CD()
	{
		this.2ADC4F0B();
		this.1D5B7AFE = null;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x003A9064 File Offset: 0x001D9464
	public void 2ADC4F0B()
	{
		uint num = this.4DFA4C26 - this.6CBF194C;
		if (num == 0U)
		{
			return;
		}
		this.1D5B7AFE.Write(this.0078138B, (int)this.6CBF194C, (int)num);
		if (this.4DFA4C26 >= this.6FE575D2)
		{
			this.4DFA4C26 = 0U;
		}
		this.6CBF194C = this.4DFA4C26;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x003A90C4 File Offset: 0x001D94C4
	public void 671C2AFE(uint 160F2471, uint 43CE18A1)
	{
		uint num = this.4DFA4C26 - 160F2471 - 1U;
		if (num >= this.6FE575D2)
		{
			num += this.6FE575D2;
		}
		while (43CE18A1 > 0U)
		{
			if (num >= this.6FE575D2)
			{
				num = 0U;
			}
			byte[] array = this.0078138B;
			uint num2 = this.4DFA4C26;
			this.4DFA4C26 = num2 + 1U;
			array[(int)num2] = this.0078138B[(int)num++];
			if (this.4DFA4C26 >= this.6FE575D2)
			{
				this.2ADC4F0B();
			}
			43CE18A1 -= 1U;
		}
	}

	// Token: 0x06000112 RID: 274 RVA: 0x003A914C File Offset: 0x001D954C
	public void 2D442620(byte 0A170BD2)
	{
		byte[] array = this.0078138B;
		uint num = this.4DFA4C26;
		this.4DFA4C26 = num + 1U;
		array[(int)num] = 0A170BD2;
		if (this.4DFA4C26 >= this.6FE575D2)
		{
			this.2ADC4F0B();
		}
	}

	// Token: 0x06000113 RID: 275 RVA: 0x003A918C File Offset: 0x001D958C
	public byte 403518EC(uint 5279706F)
	{
		uint num = this.4DFA4C26 - 5279706F - 1U;
		if (num >= this.6FE575D2)
		{
			num += this.6FE575D2;
		}
		return this.0078138B[(int)num];
	}

	// Token: 0x0400007A RID: 122
	private byte[] 0078138B;

	// Token: 0x0400007B RID: 123
	private uint 4DFA4C26;

	// Token: 0x0400007C RID: 124
	private uint 6FE575D2;

	// Token: 0x0400007D RID: 125
	private uint 6CBF194C;

	// Token: 0x0400007E RID: 126
	private Stream 1D5B7AFE;

	// Token: 0x0400007F RID: 127
	private uint 4FD14691 = 1U;

	// Token: 0x04000080 RID: 128
	public uint 075607EC;
}
