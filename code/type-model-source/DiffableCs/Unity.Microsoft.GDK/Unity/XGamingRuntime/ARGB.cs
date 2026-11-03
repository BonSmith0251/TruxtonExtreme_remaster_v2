namespace Unity.XGamingRuntime;

[Token(Token = "0x20000EF")]
public class ARGB
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B2")]
	internal ARGB interop; //Field offset: 0x10

	[Token(Token = "0x1700000B")]
	public byte A
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000576")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x6000577")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000E")]
	public byte B
	{
		[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
		[Token(Token = "0x600057C")]
		 get { } //Length: 5
		[Address(RVA = "0x21C1120", Offset = "0x21C0520", Length = "0x4")]
		[Token(Token = "0x600057D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000D")]
	public byte G
	{
		[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
		[Token(Token = "0x600057A")]
		 get { } //Length: 5
		[Address(RVA = "0x216CFD0", Offset = "0x216C3D0", Length = "0x4")]
		[Token(Token = "0x600057B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000C")]
	public byte R
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[Token(Token = "0x6000578")]
		 get { } //Length: 5
		[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
		[Token(Token = "0x6000579")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x28A9B20", Offset = "0x28A8F20", Length = "0x24")]
	[Token(Token = "0x6000574")]
	internal ARGB(ARGB interopARGB) { }

	[Address(RVA = "0x2B6DFE0", Offset = "0x2B6D3E0", Length = "0x1B")]
	[Token(Token = "0x6000575")]
	public ARGB() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000576")]
	public byte get_A() { }

	[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
	[Token(Token = "0x600057C")]
	public byte get_B() { }

	[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
	[Token(Token = "0x600057A")]
	public byte get_G() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[Token(Token = "0x6000578")]
	public byte get_R() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x6000577")]
	public void set_A(byte value) { }

	[Address(RVA = "0x21C1120", Offset = "0x21C0520", Length = "0x4")]
	[Token(Token = "0x600057D")]
	public void set_B(byte value) { }

	[Address(RVA = "0x216CFD0", Offset = "0x216C3D0", Length = "0x4")]
	[Token(Token = "0x600057B")]
	public void set_G(byte value) { }

	[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
	[Token(Token = "0x6000579")]
	public void set_R(byte value) { }

}

