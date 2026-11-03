namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x20001C3")]
public sealed class RefreshPropertiesAttribute : Attribute
{
	[Token(Token = "0x40006DF")]
	public static readonly RefreshPropertiesAttribute All; //Field offset: 0x0
	[Token(Token = "0x40006E0")]
	public static readonly RefreshPropertiesAttribute Repaint; //Field offset: 0x8
	[Token(Token = "0x40006E1")]
	public static readonly RefreshPropertiesAttribute Default; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006E2")]
	private RefreshProperties refresh; //Field offset: 0x10

	[Token(Token = "0x1700021B")]
	public RefreshProperties RefreshProperties
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B65")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x268DA40", Offset = "0x268CE40", Length = "0x106")]
	[Token(Token = "0x6000B69")]
	private static RefreshPropertiesAttribute() { }

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000B64")]
	public RefreshPropertiesAttribute(RefreshProperties refresh) { }

	[Address(RVA = "0x268D940", Offset = "0x268CD40", Length = "0x8A")]
	[Token(Token = "0x6000B66")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B65")]
	public RefreshProperties get_RefreshProperties() { }

	[Address(RVA = "0x2647A90", Offset = "0x2646E90", Length = "0x7")]
	[Token(Token = "0x6000B67")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x268D9D0", Offset = "0x268CDD0", Length = "0x6B")]
	[Token(Token = "0x6000B68")]
	public virtual bool IsDefaultAttribute() { }

}

