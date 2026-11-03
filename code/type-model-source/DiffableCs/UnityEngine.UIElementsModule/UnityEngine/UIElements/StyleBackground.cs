namespace UnityEngine.UIElements;

[Token(Token = "0x2000416")]
public struct StyleBackground : IStyleValue<Background>, IEquatable<StyleBackground>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DAB")]
	private Background m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000DAC")]
	private StyleKeyword m_Keyword; //Field offset: 0x20

	[Token(Token = "0x170008AF")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
		[Token(Token = "0x6001EE4")]
		 get { } //Length: 6
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6001EE5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008AE")]
	public override Background value
	{
		[Address(RVA = "0x32795C0", Offset = "0x32789C0", Length = "0x29")]
		[Token(Token = "0x6001EE2")]
		 get { } //Length: 41
		[Address(RVA = "0x3279700", Offset = "0x3278B00", Length = "0x2B")]
		[Token(Token = "0x6001EE3")]
		 set { } //Length: 43
	}

	[Address(RVA = "0x32793B0", Offset = "0x32787B0", Length = "0x42")]
	[Token(Token = "0x6001EEB")]
	internal StyleBackground(Texture2D v, StyleKeyword keyword) { }

	[Address(RVA = "0x3279440", Offset = "0x3278840", Length = "0x1C")]
	[Token(Token = "0x6001EE6")]
	public StyleBackground(Background v) { }

	[Address(RVA = "0x3279460", Offset = "0x3278860", Length = "0x3A")]
	[Token(Token = "0x6001EE7")]
	public StyleBackground(Texture2D v) { }

	[Address(RVA = "0x3279580", Offset = "0x3278980", Length = "0x3A")]
	[Token(Token = "0x6001EE8")]
	public StyleBackground(Sprite v) { }

	[Address(RVA = "0x3279400", Offset = "0x3278800", Length = "0x3A")]
	[Token(Token = "0x6001EE9")]
	public StyleBackground(VectorImage v) { }

	[Address(RVA = "0x32794F0", Offset = "0x32788F0", Length = "0x14")]
	[Token(Token = "0x6001EEA")]
	public StyleBackground(StyleKeyword keyword) { }

	[Address(RVA = "0x3279560", Offset = "0x3278960", Length = "0x19")]
	[Token(Token = "0x6001EEE")]
	internal StyleBackground(Background v, StyleKeyword keyword) { }

	[Address(RVA = "0x32794A0", Offset = "0x32788A0", Length = "0x42")]
	[Token(Token = "0x6001EEC")]
	internal StyleBackground(Sprite v, StyleKeyword keyword) { }

	[Address(RVA = "0x3279510", Offset = "0x3278910", Length = "0x42")]
	[Token(Token = "0x6001EED")]
	internal StyleBackground(VectorImage v, StyleKeyword keyword) { }

	[Address(RVA = "0x32791E0", Offset = "0x32785E0", Length = "0x122")]
	[Token(Token = "0x6001EF2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3279130", Offset = "0x3278530", Length = "0xA1")]
	[Token(Token = "0x6001EF1")]
	public override bool Equals(StyleBackground other) { }

	[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
	[Token(Token = "0x6001EE4")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x32795C0", Offset = "0x32789C0", Length = "0x29")]
	[Token(Token = "0x6001EE2")]
	public override Background get_value() { }

	[Address(RVA = "0x3279310", Offset = "0x3278710", Length = "0x1F")]
	[Token(Token = "0x6001EF3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32795F0", Offset = "0x32789F0", Length = "0xA1")]
	[Token(Token = "0x6001EEF")]
	public static bool op_Equality(StyleBackground lhs, StyleBackground rhs) { }

	[Address(RVA = "0x32796A0", Offset = "0x3278AA0", Length = "0x5C")]
	[Token(Token = "0x6001EF0")]
	public static StyleBackground op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6001EE5")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x3279700", Offset = "0x3278B00", Length = "0x2B")]
	[Token(Token = "0x6001EE3")]
	public override void set_value(Background value) { }

	[Address(RVA = "0x3279330", Offset = "0x3278730", Length = "0x73")]
	[Token(Token = "0x6001EF4")]
	public virtual string ToString() { }

}

