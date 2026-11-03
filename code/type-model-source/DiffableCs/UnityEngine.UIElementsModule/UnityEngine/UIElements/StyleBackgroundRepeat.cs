namespace UnityEngine.UIElements;

[Token(Token = "0x2000418")]
public struct StyleBackgroundRepeat : IStyleValue<BackgroundRepeat>, IEquatable<StyleBackgroundRepeat>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DAF")]
	private BackgroundRepeat m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000DB0")]
	private StyleKeyword m_Keyword; //Field offset: 0x8

	[Token(Token = "0x170008B3")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6001F04")]
		 get { } //Length: 6
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x6001F05")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008B2")]
	public override BackgroundRepeat value
	{
		[Address(RVA = "0x3278D20", Offset = "0x3278120", Length = "0xD")]
		[Token(Token = "0x6001F02")]
		 get { } //Length: 13
		[Address(RVA = "0x3278D80", Offset = "0x3278180", Length = "0xB")]
		[Token(Token = "0x6001F03")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x3278CF0", Offset = "0x32780F0", Length = "0xB")]
	[Token(Token = "0x6001F06")]
	public StyleBackgroundRepeat(BackgroundRepeat v) { }

	[Address(RVA = "0x3278D10", Offset = "0x3278110", Length = "0xB")]
	[Token(Token = "0x6001F07")]
	public StyleBackgroundRepeat(StyleKeyword keyword) { }

	[Address(RVA = "0x3278D00", Offset = "0x3278100", Length = "0x8")]
	[Token(Token = "0x6001F08")]
	internal StyleBackgroundRepeat(BackgroundRepeat v, StyleKeyword keyword) { }

	[Address(RVA = "0x3278B40", Offset = "0x3277F40", Length = "0x52")]
	[Token(Token = "0x6001F0B")]
	public override bool Equals(StyleBackgroundRepeat other) { }

	[Address(RVA = "0x3278BA0", Offset = "0x3277FA0", Length = "0xBA")]
	[Token(Token = "0x6001F0C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x6001F04")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x3278D20", Offset = "0x3278120", Length = "0xD")]
	[Token(Token = "0x6001F02")]
	public override BackgroundRepeat get_value() { }

	[Address(RVA = "0x3278C60", Offset = "0x3278060", Length = "0x1F")]
	[Token(Token = "0x6001F0D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3278D30", Offset = "0x3278130", Length = "0x26")]
	[Token(Token = "0x6001F09")]
	public static bool op_Equality(StyleBackgroundRepeat lhs, StyleBackgroundRepeat rhs) { }

	[Address(RVA = "0x3278D60", Offset = "0x3278160", Length = "0x20")]
	[Token(Token = "0x6001F0A")]
	public static StyleBackgroundRepeat op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x6001F05")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x3278D80", Offset = "0x3278180", Length = "0xB")]
	[Token(Token = "0x6001F03")]
	public override void set_value(BackgroundRepeat value) { }

	[Address(RVA = "0x3278C80", Offset = "0x3278080", Length = "0x68")]
	[Token(Token = "0x6001F0E")]
	public virtual string ToString() { }

}

