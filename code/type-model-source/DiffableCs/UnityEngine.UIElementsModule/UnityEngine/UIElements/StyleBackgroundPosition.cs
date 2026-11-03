namespace UnityEngine.UIElements;

[Token(Token = "0x2000417")]
public struct StyleBackgroundPosition : IStyleValue<BackgroundPosition>, IEquatable<StyleBackgroundPosition>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DAD")]
	private BackgroundPosition m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x4000DAE")]
	private StyleKeyword m_Keyword; //Field offset: 0xC

	[Token(Token = "0x170008B1")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
		[Token(Token = "0x6001EF7")]
		 get { } //Length: 6
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[Token(Token = "0x6001EF8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008B0")]
	public override BackgroundPosition value
	{
		[Address(RVA = "0x3278A80", Offset = "0x3277E80", Length = "0x3A")]
		[Token(Token = "0x6001EF5")]
		 get { } //Length: 58
		[Address(RVA = "0x3278A60", Offset = "0x3277E60", Length = "0x16")]
		[Token(Token = "0x6001EF6")]
		 set { } //Length: 22
	}

	[Address(RVA = "0x3278A60", Offset = "0x3277E60", Length = "0x16")]
	[Token(Token = "0x6001EF9")]
	public StyleBackgroundPosition(BackgroundPosition v) { }

	[Address(RVA = "0x3278A40", Offset = "0x3277E40", Length = "0x1E")]
	[Token(Token = "0x6001EFA")]
	public StyleBackgroundPosition(StyleKeyword keyword) { }

	[Address(RVA = "0xAEE530", Offset = "0xAED930", Length = "0x13")]
	[Token(Token = "0x6001EFB")]
	internal StyleBackgroundPosition(BackgroundPosition v, StyleKeyword keyword) { }

	[Address(RVA = "0x3278960", Offset = "0x3277D60", Length = "0x5F")]
	[Token(Token = "0x6001EFE")]
	public override bool Equals(StyleBackgroundPosition other) { }

	[Address(RVA = "0x3278890", Offset = "0x3277C90", Length = "0xCA")]
	[Token(Token = "0x6001EFF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
	[Token(Token = "0x6001EF7")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x3278A80", Offset = "0x3277E80", Length = "0x3A")]
	[Token(Token = "0x6001EF5")]
	public override BackgroundPosition get_value() { }

	[Address(RVA = "0x32789C0", Offset = "0x3277DC0", Length = "0x1F")]
	[Token(Token = "0x6001F00")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3278AC0", Offset = "0x3277EC0", Length = "0x4C")]
	[Token(Token = "0x6001EFC")]
	public static bool op_Equality(StyleBackgroundPosition lhs, StyleBackgroundPosition rhs) { }

	[Address(RVA = "0x3278B10", Offset = "0x3277F10", Length = "0x2B")]
	[Token(Token = "0x6001EFD")]
	public static StyleBackgroundPosition op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[Token(Token = "0x6001EF8")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x3278A60", Offset = "0x3277E60", Length = "0x16")]
	[Token(Token = "0x6001EF6")]
	public override void set_value(BackgroundPosition value) { }

	[Address(RVA = "0x32789E0", Offset = "0x3277DE0", Length = "0x5F")]
	[Token(Token = "0x6001F01")]
	public virtual string ToString() { }

}

