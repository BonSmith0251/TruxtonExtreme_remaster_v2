namespace UnityEngine.U2D;

[Token(Token = "0x200043C")]
[VisibleToOtherModules]
internal struct SpriteChannelInfo
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("buffer")]
	[Token(Token = "0x4000F20")]
	private IntPtr m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("count")]
	[Token(Token = "0x4000F21")]
	private int m_Count; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("offset")]
	[Token(Token = "0x4000F22")]
	private int m_Offset; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("stride")]
	[Token(Token = "0x4000F23")]
	private int m_Stride; //Field offset: 0x10

	[Token(Token = "0x170004AC")]
	public Void* buffer
	{
		[Address(RVA = "0x2FCA800", Offset = "0x2FC9C00", Length = "0xC")]
		[Token(Token = "0x6001FA0")]
		 get { } //Length: 12
	}

	[Token(Token = "0x170004AD")]
	public int count
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6001FA1")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170004AE")]
	public int offset
	{
		[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
		[Token(Token = "0x6001FA2")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170004AF")]
	public int stride
	{
		[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
		[Token(Token = "0x6001FA3")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2FCA800", Offset = "0x2FC9C00", Length = "0xC")]
	[Token(Token = "0x6001FA0")]
	public Void* get_buffer() { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x6001FA1")]
	public int get_count() { }

	[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
	[Token(Token = "0x6001FA2")]
	public int get_offset() { }

	[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
	[Token(Token = "0x6001FA3")]
	public int get_stride() { }

}

