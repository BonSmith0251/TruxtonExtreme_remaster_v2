namespace UnityEngine.UIElements;

[Token(Token = "0x200042A")]
public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DD4")]
	private TransformOrigin m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000DD5")]
	private StyleKeyword m_Keyword; //Field offset: 0x14

	[Token(Token = "0x170008D4")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
		[Token(Token = "0x6001FF3")]
		 get { } //Length: 6
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6001FF4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008D3")]
	public override TransformOrigin value
	{
		[Address(RVA = "0x327C440", Offset = "0x327B840", Length = "0x113")]
		[Token(Token = "0x6001FF1")]
		 get { } //Length: 275
		[Address(RVA = "0x3279110", Offset = "0x3278510", Length = "0x14")]
		[Token(Token = "0x6001FF2")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x3279110", Offset = "0x3278510", Length = "0x14")]
	[Token(Token = "0x6001FF5")]
	public StyleTransformOrigin(TransformOrigin v) { }

	[Address(RVA = "0x3279000", Offset = "0x3278400", Length = "0xF")]
	[Token(Token = "0x6001FF6")]
	public StyleTransformOrigin(StyleKeyword keyword) { }

	[Address(RVA = "0x3278FE0", Offset = "0x32783E0", Length = "0x11")]
	[Token(Token = "0x6001FF7")]
	internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword) { }

	[Address(RVA = "0x327C220", Offset = "0x327B620", Length = "0xE6")]
	[Token(Token = "0x6001FFB")]
	public override bool Equals(StyleTransformOrigin other) { }

	[Address(RVA = "0x327C310", Offset = "0x327B710", Length = "0x9B")]
	[Token(Token = "0x6001FFC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
	[Token(Token = "0x6001FF3")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x327C440", Offset = "0x327B840", Length = "0x113")]
	[Token(Token = "0x6001FF1")]
	public override TransformOrigin get_value() { }

	[Address(RVA = "0x327C3B0", Offset = "0x327B7B0", Length = "0x1F")]
	[Token(Token = "0x6001FFD")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327C560", Offset = "0x327B960", Length = "0xE6")]
	[Token(Token = "0x6001FF8")]
	public static bool op_Equality(StyleTransformOrigin lhs, StyleTransformOrigin rhs) { }

	[Address(RVA = "0x32790E0", Offset = "0x32784E0", Length = "0x27")]
	[Token(Token = "0x6001FF9")]
	public static StyleTransformOrigin op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x327C650", Offset = "0x327BA50", Length = "0x2B")]
	[Token(Token = "0x6001FFA")]
	public static StyleTransformOrigin op_Implicit(TransformOrigin v) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6001FF4")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x3279110", Offset = "0x3278510", Length = "0x14")]
	[Token(Token = "0x6001FF2")]
	public override void set_value(TransformOrigin value) { }

	[Address(RVA = "0x327C3D0", Offset = "0x327B7D0", Length = "0x6A")]
	[Token(Token = "0x6001FFE")]
	public virtual string ToString() { }

}

