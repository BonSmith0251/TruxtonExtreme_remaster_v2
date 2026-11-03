namespace UnityEngine.UIElements;

[Token(Token = "0x2000423")]
public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DC6")]
	private Length m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000DC7")]
	private StyleKeyword m_Keyword; //Field offset: 0x8

	[Token(Token = "0x170008C6")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6001F90")]
		 get { } //Length: 6
		[Address(RVA = "0x327AC70", Offset = "0x327A070", Length = "0x49")]
		[Token(Token = "0x6001F91")]
		 set { } //Length: 73
	}

	[Token(Token = "0x170008C5")]
	public override Length value
	{
		[Address(RVA = "0x327AB40", Offset = "0x3279F40", Length = "0x19")]
		[Token(Token = "0x6001F8E")]
		 get { } //Length: 25
		[Address(RVA = "0x327ACC0", Offset = "0x327A0C0", Length = "0x33")]
		[Token(Token = "0x6001F8F")]
		 set { } //Length: 51
	}

	[Address(RVA = "0x327AA80", Offset = "0x3279E80", Length = "0x58")]
	[Token(Token = "0x6001F92")]
	public StyleLength(float v) { }

	[Address(RVA = "0x327AB10", Offset = "0x3279F10", Length = "0x2B")]
	[Token(Token = "0x6001F93")]
	public StyleLength(Length v) { }

	[Address(RVA = "0x3278D10", Offset = "0x3278110", Length = "0xB")]
	[Token(Token = "0x6001F94")]
	public StyleLength(StyleKeyword keyword) { }

	[Address(RVA = "0x327AAE0", Offset = "0x3279EE0", Length = "0x28")]
	[Token(Token = "0x6001F95")]
	internal StyleLength(Length v, StyleKeyword keyword) { }

	[Address(RVA = "0x327A880", Offset = "0x3279C80", Length = "0x70")]
	[Token(Token = "0x6001F9A")]
	public override bool Equals(StyleLength other) { }

	[Address(RVA = "0x327A8F0", Offset = "0x3279CF0", Length = "0xE1")]
	[Token(Token = "0x6001F9B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x6001F90")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x327AB40", Offset = "0x3279F40", Length = "0x19")]
	[Token(Token = "0x6001F8E")]
	public override Length get_value() { }

	[Address(RVA = "0x327A9E0", Offset = "0x3279DE0", Length = "0x28")]
	[Token(Token = "0x6001F9C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327AB60", Offset = "0x3279F60", Length = "0x3E")]
	[Token(Token = "0x6001F96")]
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	[Address(RVA = "0x3278D60", Offset = "0x3278160", Length = "0x20")]
	[Token(Token = "0x6001F97")]
	public static StyleLength op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x327ABE0", Offset = "0x3279FE0", Length = "0x84")]
	[Token(Token = "0x6001F98")]
	public static StyleLength op_Implicit(float v) { }

	[Address(RVA = "0x327ABA0", Offset = "0x3279FA0", Length = "0x40")]
	[Token(Token = "0x6001F99")]
	public static StyleLength op_Implicit(Length v) { }

	[Address(RVA = "0x327AC70", Offset = "0x327A070", Length = "0x49")]
	[Token(Token = "0x6001F91")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x327ACC0", Offset = "0x327A0C0", Length = "0x33")]
	[Token(Token = "0x6001F8F")]
	public override void set_value(Length value) { }

	[Address(RVA = "0x327AA10", Offset = "0x3279E10", Length = "0x68")]
	[Token(Token = "0x6001F9D")]
	public virtual string ToString() { }

}

