namespace UnityEngine.UIElements;

[Token(Token = "0x2000426")]
public struct StyleRatio : IStyleValue<Ratio>, IEquatable<StyleRatio>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000DCC")]
	private Ratio m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000DCD")]
	private StyleKeyword m_Keyword; //Field offset: 0x4

	[Token(Token = "0x170008CC")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
		[Token(Token = "0x6001FBA")]
		 get { } //Length: 6
		[Address(RVA = "0x327B4B0", Offset = "0x327A8B0", Length = "0x10")]
		[Token(Token = "0x6001FBB")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170008CB")]
	public override Ratio value
	{
		[Address(RVA = "0x327B4C0", Offset = "0x327A8C0", Length = "0x10")]
		[Token(Token = "0x6001FB8")]
		 get { } //Length: 16
		[Address(RVA = "0xFD4710", Offset = "0xFD3B10", Length = "0xA")]
		[Token(Token = "0x6001FB9")]
		 set { } //Length: 10
	}

	[Address(RVA = "0x327B4A0", Offset = "0x327A8A0", Length = "0xA")]
	[Token(Token = "0x6001FBC")]
	public StyleRatio(Ratio value) { }

	[Address(RVA = "0x327B4B0", Offset = "0x327A8B0", Length = "0x10")]
	[Token(Token = "0x6001FBD")]
	public StyleRatio(StyleKeyword keyword) { }

	[Address(RVA = "0xFD3C10", Offset = "0xFD3010", Length = "0x7")]
	[Token(Token = "0x6001FBE")]
	internal StyleRatio(Ratio value, StyleKeyword keyword) { }

	[Address(RVA = "0x327B290", Offset = "0x327A690", Length = "0x18")]
	[Token(Token = "0x6001FBF")]
	public static StyleRatio Auto() { }

	[Address(RVA = "0x327B310", Offset = "0x327A710", Length = "0xCC")]
	[Token(Token = "0x6001FC6")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x327B2B0", Offset = "0x327A6B0", Length = "0x53")]
	[Token(Token = "0x6001FC5")]
	public override bool Equals(StyleRatio other) { }

	[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
	[Token(Token = "0x6001FBA")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x327B4C0", Offset = "0x327A8C0", Length = "0x10")]
	[Token(Token = "0x6001FB8")]
	public override Ratio get_value() { }

	[Address(RVA = "0x327B3E0", Offset = "0x327A7E0", Length = "0x16")]
	[Token(Token = "0x6001FC7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32722A0", Offset = "0x32716A0", Length = "0x8")]
	[Token(Token = "0x6001FC0")]
	internal bool IsAuto() { }

	[Address(RVA = "0x327B4D0", Offset = "0x327A8D0", Length = "0x50")]
	[Token(Token = "0x6001FC4")]
	public static bool op_Equality(StyleRatio lhs, StyleRatio rhs) { }

	[Address(RVA = "0x327B540", Offset = "0x327A940", Length = "0x18")]
	[Token(Token = "0x6001FC2")]
	public static Ratio op_Implicit(StyleRatio value) { }

	[Address(RVA = "0x327B560", Offset = "0x327A960", Length = "0x14")]
	[Token(Token = "0x6001FC3")]
	public static StyleRatio op_Implicit(StyleKeyword value) { }

	[Address(RVA = "0x327B520", Offset = "0x327A920", Length = "0x16")]
	[Token(Token = "0x6001FC1")]
	public static StyleRatio op_Implicit(float value) { }

	[Address(RVA = "0x327B4B0", Offset = "0x327A8B0", Length = "0x10")]
	[Token(Token = "0x6001FBB")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0xFD4710", Offset = "0xFD3B10", Length = "0xA")]
	[Token(Token = "0x6001FB9")]
	public override void set_value(Ratio value) { }

	[Address(RVA = "0x327B400", Offset = "0x327A800", Length = "0x9A")]
	[Token(Token = "0x6001FC8")]
	public virtual string ToString() { }

}

