using System;
using System.IO;

// Token: 0x02000018 RID: 24
public class 0C55212B
{
	// Token: 0x060000FB RID: 251 RVA: 0x003A85C0 File Offset: 0x003A45C0
	public 0C55212B()
	{
		this.13C54DA8 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.72B627FE[num] = new 4AF73F26(6);
			num++;
		}
	}

	// Token: 0x060000FC RID: 252 RVA: 0x003A86B8 File Offset: 0x003A46B8
	private void 281A70E7(uint 5A865ADF)
	{
		if (this.13C54DA8 != 5A865ADF)
		{
			this.13C54DA8 = 5A865ADF;
			this.4E3E1FAE = Math.Max(this.13C54DA8, 1U);
			uint 3B142C = Math.Max(this.4E3E1FAE, 4096U);
			this.752310B9.0BC351AC(3B142C);
		}
	}

	// Token: 0x060000FD RID: 253 RVA: 0x003A8708 File Offset: 0x003A4708
	private void 33E7301E(int 58046C79, int 38207408)
	{
		if (58046C79 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (38207408 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		this.5D9B6176.52A44C0D(58046C79, 38207408);
	}

	// Token: 0x060000FE RID: 254 RVA: 0x003A873C File Offset: 0x003A473C
	private void 53862A16(int 75E45904)
	{
		if (75E45904 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = 1U << 75E45904;
		this.1DAC4FB1.28825997(num);
		this.128876BE.28825997(num);
		this.57F476D4 = num - 1U;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x003A8784 File Offset: 0x003A4784
	private void 093D13AD(Stream 193570E1, Stream 62532110)
	{
		this.1EC87311.74257AE4(193570E1);
		this.752310B9.00CF443C(62532110, false);
		for (uint num = 0U; num < 12U; num += 1U)
		{
			for (uint num2 = 0U; num2 <= this.57F476D4; num2 += 1U)
			{
				uint num3 = (num << 4) + num2;
				this.58082C24[(int)num3].55D17E04();
				this.74665BD2[(int)num3].55D17E04();
			}
			this.6D795C6C[(int)num].55D17E04();
			this.72EE50C5[(int)num].55D17E04();
			this.30DC4AB1[(int)num].55D17E04();
			this.1A1733A6[(int)num].55D17E04();
		}
		this.5D9B6176.2A086F63();
		for (uint num = 0U; num < 4U; num += 1U)
		{
			this.72B627FE[(int)num].36432CE0();
		}
		for (uint num = 0U; num < 114U; num += 1U)
		{
			this.35FC6F6F[(int)num].55D17E04();
		}
		this.1DAC4FB1.615F0160();
		this.128876BE.615F0160();
		this.120111FB.36432CE0();
	}

	// Token: 0x06000100 RID: 256 RVA: 0x003A88B4 File Offset: 0x003A48B4
	public void 4B637322(Stream 7650221A, Stream 3C4C7474, long 59745CF7)
	{
		this.093D13AD(7650221A, 3C4C7474);
		09C94119.3BBC2F9F 3BBC2F9F = default(09C94119.3BBC2F9F);
		3BBC2F9F.24FE06B9();
		uint num = 0U;
		uint num2 = 0U;
		uint num3 = 0U;
		uint num4 = 0U;
		ulong num5 = 0UL;
		if (num5 < (ulong)59745CF7)
		{
			if (this.58082C24[(int)((int)3BBC2F9F.454A13E3 << 4)].18827237(this.1EC87311) != 0U)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			3BBC2F9F.3D35632C();
			byte 0A170BD = this.5D9B6176.0A00111F(this.1EC87311, 0U, 0);
			this.752310B9.2D442620(0A170BD);
			num5 += 1UL;
		}
		while (num5 < (ulong)59745CF7)
		{
			uint num6 = (uint)num5 & this.57F476D4;
			if (this.58082C24[(int)((3BBC2F9F.454A13E3 << 4) + num6)].18827237(this.1EC87311) == 0U)
			{
				byte b = this.752310B9.403518EC(0U);
				byte 0A170BD2;
				if (!3BBC2F9F.03FC1E7E())
				{
					0A170BD2 = this.5D9B6176.50BF7356(this.1EC87311, (uint)num5, b, this.752310B9.403518EC(num));
				}
				else
				{
					0A170BD2 = this.5D9B6176.0A00111F(this.1EC87311, (uint)num5, b);
				}
				this.752310B9.2D442620(0A170BD2);
				3BBC2F9F.3D35632C();
				num5 += 1UL;
			}
			else
			{
				uint num8;
				if (this.6D795C6C[(int)3BBC2F9F.454A13E3].18827237(this.1EC87311) == 1U)
				{
					if (this.72EE50C5[(int)3BBC2F9F.454A13E3].18827237(this.1EC87311) == 0U)
					{
						if (this.74665BD2[(int)((3BBC2F9F.454A13E3 << 4) + num6)].18827237(this.1EC87311) == 0U)
						{
							3BBC2F9F.49842739();
							this.752310B9.2D442620(this.752310B9.403518EC(num));
							num5 += 1UL;
							continue;
						}
					}
					else
					{
						uint num7;
						if (this.30DC4AB1[(int)3BBC2F9F.454A13E3].18827237(this.1EC87311) == 0U)
						{
							num7 = num2;
						}
						else
						{
							if (this.1A1733A6[(int)3BBC2F9F.454A13E3].18827237(this.1EC87311) == 0U)
							{
								num7 = num3;
							}
							else
							{
								num7 = num4;
								num4 = num3;
							}
							num3 = num2;
						}
						num2 = num;
						num = num7;
					}
					num8 = this.128876BE.21FF0A2A(this.1EC87311, num6) + 2U;
					3BBC2F9F.43E42D0D();
				}
				else
				{
					num4 = num3;
					num3 = num2;
					num2 = num;
					num8 = 2U + this.1DAC4FB1.21FF0A2A(this.1EC87311, num6);
					3BBC2F9F.3FB47EC0();
					uint num9 = this.72B627FE[(int)09C94119.3F0E08F0(num8)].705B3E67(this.1EC87311);
					if (num9 >= 4U)
					{
						int num10 = (int)((num9 >> 1) - 1U);
						num = (2U | (num9 & 1U)) << num10;
						if (num9 < 14U)
						{
							num += 4AF73F26.7EBE5D84(this.35FC6F6F, num - num9 - 1U, this.1EC87311, num10);
						}
						else
						{
							num += this.1EC87311.468F7801(num10 - 4) << 4;
							num += this.120111FB.1F7C1C85(this.1EC87311);
						}
					}
					else
					{
						num = num9;
					}
				}
				if ((ulong)num >= (ulong)this.752310B9.075607EC + num5 || num >= this.4E3E1FAE)
				{
					if (num != 4294967295U)
					{
						throw new InvalidDataException("rep0");
					}
					break;
				}
				else
				{
					this.752310B9.671C2AFE(num, num8);
					num5 += (ulong)num8;
				}
			}
		}
		this.752310B9.2ADC4F0B();
		this.752310B9.4D2527CD();
		this.1EC87311.11F54EC2();
	}

	// Token: 0x06000101 RID: 257 RVA: 0x003A8C48 File Offset: 0x003A4C48
	public void 536C1F6B(byte[] 6A182E26)
	{
		if (6A182E26.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int <<EMPTY_NAME>> = (int)(6A182E26[0] % 9);
		byte b = 6A182E26[0] / 9;
		int 58046C = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)6A182E26[1 + i] << i * 8);
		}
		this.281A70E7(num2);
		this.33E7301E(58046C, <<EMPTY_NAME>>);
		this.53862A16(num);
	}

	// Token: 0x0400005D RID: 93
	private uint 48550CAE = 1U;

	// Token: 0x0400005E RID: 94
	private readonly 18F62D5D 752310B9 = new 18F62D5D();

	// Token: 0x0400005F RID: 95
	private readonly 1ACD6604 1EC87311 = new 1ACD6604();

	// Token: 0x04000060 RID: 96
	private readonly 1AB8456E[] 58082C24 = new 1AB8456E[192];

	// Token: 0x04000061 RID: 97
	private readonly 1AB8456E[] 6D795C6C = new 1AB8456E[12];

	// Token: 0x04000062 RID: 98
	private readonly 1AB8456E[] 72EE50C5 = new 1AB8456E[12];

	// Token: 0x04000063 RID: 99
	private readonly 1AB8456E[] 30DC4AB1 = new 1AB8456E[12];

	// Token: 0x04000064 RID: 100
	private readonly 1AB8456E[] 1A1733A6 = new 1AB8456E[12];

	// Token: 0x04000065 RID: 101
	private readonly 1AB8456E[] 74665BD2 = new 1AB8456E[192];

	// Token: 0x04000066 RID: 102
	private readonly 4AF73F26[] 72B627FE = new 4AF73F26[4];

	// Token: 0x04000067 RID: 103
	private readonly 1AB8456E[] 35FC6F6F = new 1AB8456E[114];

	// Token: 0x04000068 RID: 104
	private 4AF73F26 120111FB = new 4AF73F26(4);

	// Token: 0x04000069 RID: 105
	private readonly 0C55212B.2D4E26DA 1DAC4FB1 = new 0C55212B.2D4E26DA();

	// Token: 0x0400006A RID: 106
	private readonly 0C55212B.2D4E26DA 128876BE = new 0C55212B.2D4E26DA();

	// Token: 0x0400006B RID: 107
	private readonly 0C55212B.351C4A64 5D9B6176 = new 0C55212B.351C4A64();

	// Token: 0x0400006C RID: 108
	private uint 13C54DA8;

	// Token: 0x0400006D RID: 109
	private uint 4E3E1FAE;

	// Token: 0x0400006E RID: 110
	private uint 57F476D4;

	// Token: 0x02000040 RID: 64
	private class 2D4E26DA
	{
		// Token: 0x06000299 RID: 665 RVA: 0x003AE224 File Offset: 0x003AA224
		public void 28825997(uint 4FBE3037)
		{
			for (uint num = this.51D87531; num < 4FBE3037; num += 1U)
			{
				this.182E370B[(int)num] = new 4AF73F26(3);
				this.38964DFE[(int)num] = new 4AF73F26(3);
			}
			this.51D87531 = 4FBE3037;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x003AE274 File Offset: 0x003AA274
		public void 615F0160()
		{
			this.57C15253.55D17E04();
			for (uint num = 0U; num < this.51D87531; num += 1U)
			{
				this.182E370B[(int)num].36432CE0();
				this.38964DFE[(int)num].36432CE0();
			}
			this.757D14CC.55D17E04();
			this.625D7F6F.36432CE0();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x003AE2DC File Offset: 0x003AA2DC
		public uint 21FF0A2A(1ACD6604 38E12795, uint 6C9428B0)
		{
			if (this.57C15253.18827237(38E12795) == 0U)
			{
				return this.182E370B[(int)6C9428B0].705B3E67(38E12795);
			}
			uint num = 8U;
			if (this.757D14CC.18827237(38E12795) == 0U)
			{
				num += this.38964DFE[(int)6C9428B0].705B3E67(38E12795);
			}
			else
			{
				num += 8U;
				num += this.625D7F6F.705B3E67(38E12795);
			}
			return num;
		}

		// Token: 0x040000B9 RID: 185
		private 1AB8456E 57C15253;

		// Token: 0x040000BA RID: 186
		private 1AB8456E 757D14CC;

		// Token: 0x040000BB RID: 187
		private readonly 4AF73F26[] 182E370B = new 4AF73F26[16];

		// Token: 0x040000BC RID: 188
		private readonly 4AF73F26[] 38964DFE = new 4AF73F26[16];

		// Token: 0x040000BD RID: 189
		private 4AF73F26 625D7F6F = new 4AF73F26(8);

		// Token: 0x040000BE RID: 190
		private uint 51D87531;
	}

	// Token: 0x02000041 RID: 65
	private class 351C4A64
	{
		// Token: 0x0600029D RID: 669 RVA: 0x003AE380 File Offset: 0x003AA380
		public void 52A44C0D(int 05D94368, int 3FA62F9D)
		{
			if (this.6CFB7884 != null && this.004C6F3A == 3FA62F9D && this.3F482989 == 05D94368)
			{
				return;
			}
			this.3F482989 = 05D94368;
			this.08BA49BD = (1U << 05D94368) - 1U;
			this.004C6F3A = 3FA62F9D;
			uint num = 1U << this.004C6F3A + this.3F482989;
			this.6CFB7884 = new 0C55212B.351C4A64.14C12747[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.6CFB7884[(int)num2].66C33496();
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x003AE410 File Offset: 0x003AA410
		public void 2A086F63()
		{
			uint num = 1U << this.004C6F3A + this.3F482989;
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.6CFB7884[(int)num2].11F82231();
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x003AE454 File Offset: 0x003AA454
		private uint 079E3376(uint 6753484F, byte 702F2E86)
		{
			return ((6753484F & this.08BA49BD) << this.004C6F3A) + (uint)(702F2E86 >> 8 - this.004C6F3A);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x003AE478 File Offset: 0x003AA478
		public byte 0A00111F(1ACD6604 4E4C288B, uint 4F47541B, byte 4E342B1B)
		{
			return this.6CFB7884[(int)this.079E3376(4F47541B, 4E342B1B)].419657AD(4E4C288B);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x003AE494 File Offset: 0x003AA494
		public byte 50BF7356(1ACD6604 43FF76FB, uint 7FC1702D, byte 6EDF725B, byte 5AE4333F)
		{
			return this.6CFB7884[(int)this.079E3376(7FC1702D, 6EDF725B)].4B4856C2(43FF76FB, 5AE4333F);
		}

		// Token: 0x040000BF RID: 191
		private uint 737C194B = 1U;

		// Token: 0x040000C0 RID: 192
		private 0C55212B.351C4A64.14C12747[] 6CFB7884;

		// Token: 0x040000C1 RID: 193
		private int 004C6F3A;

		// Token: 0x040000C2 RID: 194
		private int 3F482989;

		// Token: 0x040000C3 RID: 195
		private uint 08BA49BD;

		// Token: 0x02000042 RID: 66
		private struct 14C12747
		{
			// Token: 0x060002A3 RID: 675 RVA: 0x003AE4C4 File Offset: 0x003AA4C4
			public void 66C33496()
			{
				this.0A8B5A0D = new 1AB8456E[768];
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x003AE4D8 File Offset: 0x003AA4D8
			public void 11F82231()
			{
				for (int i = 0; i < 768; i++)
				{
					this.0A8B5A0D[i].55D17E04();
				}
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x003AE50C File Offset: 0x003AA50C
			public byte 419657AD(1ACD6604 29A11892)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this.0A8B5A0D[(int)num].18827237(29A11892));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x003AE540 File Offset: 0x003AA540
			public byte 4B4856C2(1ACD6604 7EC43611, byte 09AD3CBF)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(09AD3CBF >> 7 & 1);
					09AD3CBF = (byte)(09AD3CBF << 1);
					uint num3 = this.0A8B5A0D[(int)((1U + num2 << 8) + num)].18827237(7EC43611);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_6B;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this.0A8B5A0D[(int)num].18827237(7EC43611));
				}
				IL_6B:
				return (byte)num;
			}

			// Token: 0x040000C4 RID: 196
			private 1AB8456E[] 0A8B5A0D;
		}
	}
}
