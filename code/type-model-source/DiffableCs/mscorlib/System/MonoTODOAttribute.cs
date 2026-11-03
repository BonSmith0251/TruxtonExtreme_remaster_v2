namespace System;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True)]
[Token(Token = "0x2000175")]
internal class MonoTODOAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400056A")]
	private string comment; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000D6C")]
	public MonoTODOAttribute() { }

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000D6D")]
	public MonoTODOAttribute(string comment) { }

}

