using System;

// Token: 0x02000011 RID: 17
public class 12061389
{
	// Token: 0x06000075 RID: 117 RVA: 0x0039A0BC File Offset: 0x001CA4BC
	public 12061389()
	{
		this.1DA73008 = 1722231942U;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0039A0D0 File Offset: 0x001CA4D0
	public uint 0BF144D5(uint 2906304A)
	{
		uint num = 2906304A ^ this.1DA73008;
		this.1DA73008 = (7DAF09CC.3BEF4103(this.1DA73008, 7) ^ num);
		return num;
	}

	// Token: 0x04000033 RID: 51
	private uint 1DA73008;
}
