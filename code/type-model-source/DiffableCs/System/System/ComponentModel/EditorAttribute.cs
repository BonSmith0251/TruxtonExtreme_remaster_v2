namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Token(Token = "0x2000172")]
public sealed class EditorAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400061E")]
	private string _typeId; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400061F")]
	private readonly string <EditorBaseTypeName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000620")]
	private readonly string <EditorTypeName>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170001A8")]
	public string EditorBaseTypeName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008E6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001A9")]
	public string EditorTypeName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008E7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001AA")]
	public virtual object TypeId
	{
		[Address(RVA = "0x265FC90", Offset = "0x265F090", Length = "0x9D")]
		[Token(Token = "0x60008E8")]
		 get { } //Length: 157
	}

	[Address(RVA = "0x265FBE0", Offset = "0x265EFE0", Length = "0xA1")]
	[Token(Token = "0x60008E5")]
	public EditorAttribute(string typeName, string baseTypeName) { }

	[Address(RVA = "0x265FB30", Offset = "0x265EF30", Length = "0xA2")]
	[Token(Token = "0x60008E9")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008E6")]
	public string get_EditorBaseTypeName() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008E7")]
	public string get_EditorTypeName() { }

	[Address(RVA = "0x265FC90", Offset = "0x265F090", Length = "0x9D")]
	[Token(Token = "0x60008E8")]
	public virtual object get_TypeId() { }

	[Address(RVA = "0x2647A90", Offset = "0x2646E90", Length = "0x7")]
	[Token(Token = "0x60008EA")]
	public virtual int GetHashCode() { }

}

