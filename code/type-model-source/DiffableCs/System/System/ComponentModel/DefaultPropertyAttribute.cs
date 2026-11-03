namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x200016D")]
public sealed class DefaultPropertyAttribute : Attribute
{
	[Token(Token = "0x4000615")]
	public static readonly DefaultPropertyAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000614")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001A2")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008C6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x265F2D0", Offset = "0x265E6D0", Length = "0x7A")]
	[Token(Token = "0x60008C9")]
	private static DefaultPropertyAttribute() { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x60008C5")]
	public DefaultPropertyAttribute(string name) { }

	[Address(RVA = "0x265F260", Offset = "0x265E660", Length = "0x6D")]
	[Token(Token = "0x60008C7")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008C6")]
	public string get_Name() { }

	[Address(RVA = "0x2647A90", Offset = "0x2646E90", Length = "0x7")]
	[Token(Token = "0x60008C8")]
	public virtual int GetHashCode() { }

}

