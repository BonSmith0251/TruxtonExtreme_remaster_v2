namespace UnityEngine.UIElements;

[Token(Token = "0x200042B")]
public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DD6")]
	private Translate m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000DD7")]
	private StyleKeyword m_Keyword; //Field offset: 0x18

	[Token(Token = "0x170008D6")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x6002001")]
		 get { } //Length: 6
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6002002")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008D5")]
	public override Translate value
	{
		[Address(RVA = "0x327C8B0", Offset = "0x327BCB0", Length = "0xAB")]
		[Token(Token = "0x6001FFF")]
		 get { } //Length: 171
		[Address(RVA = "0x327B7E0", Offset = "0x327ABE0", Length = "0x18")]
		[Token(Token = "0x6002000")]
		 set { } //Length: 24
	}

	[Address(RVA = "0x327B7E0", Offset = "0x327ABE0", Length = "0x18")]
	[Token(Token = "0x6002003")]
	public StyleTranslate(Translate v) { }

	[Address(RVA = "0x327B7B0", Offset = "0x327ABB0", Length = "0x24")]
	[Token(Token = "0x6002004")]
	public StyleTranslate(StyleKeyword keyword) { }

	[Address(RVA = "0x327B800", Offset = "0x327AC00", Length = "0x15")]
	[Token(Token = "0x6002005")]
	internal StyleTranslate(Translate v, StyleKeyword keyword) { }

	[Address(RVA = "0x327C680", Offset = "0x327BA80", Length = "0x81")]
	[Token(Token = "0x600200A")]
	public override bool Equals(StyleTranslate other) { }

	[Address(RVA = "0x327C710", Offset = "0x327BB10", Length = "0xF5")]
	[Token(Token = "0x600200B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x6002001")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x327C8B0", Offset = "0x327BCB0", Length = "0xAB")]
	[Token(Token = "0x6001FFF")]
	public override Translate get_value() { }

	[Address(RVA = "0x327C810", Offset = "0x327BC10", Length = "0x1F")]
	[Token(Token = "0x600200C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327C960", Offset = "0x327BD60", Length = "0x81")]
	[Token(Token = "0x6002006")]
	public static bool op_Equality(StyleTranslate lhs, StyleTranslate rhs) { }

	[Address(RVA = "0x327B9D0", Offset = "0x327ADD0", Length = "0x27")]
	[Token(Token = "0x6002007")]
	public static StyleTranslate op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x327B9A0", Offset = "0x327ADA0", Length = "0x21")]
	[Token(Token = "0x6002008")]
	public static StyleTranslate op_Implicit(Translate v) { }

	[Address(RVA = "0x327C9F0", Offset = "0x327BDF0", Length = "0x114")]
	[Token(Token = "0x6002009")]
	public static StyleTranslate op_Implicit(Vector3 v) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6002002")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x327B7E0", Offset = "0x327ABE0", Length = "0x18")]
	[Token(Token = "0x6002000")]
	public override void set_value(Translate value) { }

	[Address(RVA = "0x327C830", Offset = "0x327BC30", Length = "0x71")]
	[Token(Token = "0x600200D")]
	public virtual string ToString() { }

}

