namespace UnityEngine.UIElements;

[Token(Token = "0x2000427")]
public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DCE")]
	private Rotate m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000DCF")]
	private StyleKeyword m_Keyword; //Field offset: 0x18

	[Token(Token = "0x170008CE")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x6001FCB")]
		 get { } //Length: 6
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6001FCC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008CD")]
	public override Rotate value
	{
		[Address(RVA = "0x327B820", Offset = "0x327AC20", Length = "0xE6")]
		[Token(Token = "0x6001FC9")]
		 get { } //Length: 230
		[Address(RVA = "0x327B7E0", Offset = "0x327ABE0", Length = "0x18")]
		[Token(Token = "0x6001FCA")]
		 set { } //Length: 24
	}

	[Address(RVA = "0x327B7E0", Offset = "0x327ABE0", Length = "0x18")]
	[Token(Token = "0x6001FCD")]
	public StyleRotate(Rotate v) { }

	[Address(RVA = "0x327B7B0", Offset = "0x327ABB0", Length = "0x24")]
	[Token(Token = "0x6001FCE")]
	public StyleRotate(StyleKeyword keyword) { }

	[Address(RVA = "0x327B800", Offset = "0x327AC00", Length = "0x15")]
	[Token(Token = "0x6001FCF")]
	internal StyleRotate(Rotate v, StyleKeyword keyword) { }

	[Address(RVA = "0x327B680", Offset = "0x327AA80", Length = "0x81")]
	[Token(Token = "0x6001FD3")]
	public override bool Equals(StyleRotate other) { }

	[Address(RVA = "0x327B580", Offset = "0x327A980", Length = "0xF5")]
	[Token(Token = "0x6001FD4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x6001FCB")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x327B820", Offset = "0x327AC20", Length = "0xE6")]
	[Token(Token = "0x6001FC9")]
	public override Rotate get_value() { }

	[Address(RVA = "0x327B710", Offset = "0x327AB10", Length = "0x1F")]
	[Token(Token = "0x6001FD5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327B910", Offset = "0x327AD10", Length = "0x81")]
	[Token(Token = "0x6001FD0")]
	public static bool op_Equality(StyleRotate lhs, StyleRotate rhs) { }

	[Address(RVA = "0x327B9D0", Offset = "0x327ADD0", Length = "0x27")]
	[Token(Token = "0x6001FD1")]
	public static StyleRotate op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x327B9A0", Offset = "0x327ADA0", Length = "0x21")]
	[Token(Token = "0x6001FD2")]
	public static StyleRotate op_Implicit(Rotate v) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6001FCC")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x327B7E0", Offset = "0x327ABE0", Length = "0x18")]
	[Token(Token = "0x6001FCA")]
	public override void set_value(Rotate value) { }

	[Address(RVA = "0x327B730", Offset = "0x327AB30", Length = "0x71")]
	[Token(Token = "0x6001FD6")]
	public virtual string ToString() { }

}

