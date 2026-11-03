namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x200016C")]
public sealed class DefaultEventAttribute : Attribute
{
	[Token(Token = "0x4000613")]
	public static readonly DefaultEventAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000612")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001A1")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008C1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x265F1E0", Offset = "0x265E5E0", Length = "0x7A")]
	[Token(Token = "0x60008C4")]
	private static DefaultEventAttribute() { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x60008C0")]
	public DefaultEventAttribute(string name) { }

	[Address(RVA = "0x265F170", Offset = "0x265E570", Length = "0x6D")]
	[Token(Token = "0x60008C2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008C1")]
	public string get_Name() { }

	[Address(RVA = "0x2647A90", Offset = "0x2646E90", Length = "0x7")]
	[Token(Token = "0x60008C3")]
	public virtual int GetHashCode() { }

}

