namespace System.Xml;

[Token(Token = "0x200001C")]
internal class CharEntityEncoderFallback : EncoderFallback
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D6")]
	private CharEntityEncoderFallbackBuffer fallbackBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D7")]
	private Int32[] textContentMarks; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D8")]
	private int endMarkPos; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000D9")]
	private int curMarkPos; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000DA")]
	private int startOffset; //Field offset: 0x28

	[Token(Token = "0x17000013")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000014")]
	internal int StartOffset
	{
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x60000E7")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60000E4")]
	internal CharEntityEncoderFallback() { }

	[Address(RVA = "0x23F38E0", Offset = "0x23F2CE0", Length = "0x57")]
	[Token(Token = "0x60000E9")]
	internal bool CanReplaceAt(int index) { }

	[Address(RVA = "0x23F3940", Offset = "0x23F2D40", Length = "0x9E")]
	[Token(Token = "0x60000E5")]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
	[Token(Token = "0x60000E6")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x23F39E0", Offset = "0x23F2DE0", Length = "0x32")]
	[Token(Token = "0x60000E8")]
	internal void Reset(Int32[] textContentMarks, int endMarkPos) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x60000E7")]
	internal void set_StartOffset(int value) { }

}

