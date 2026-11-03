namespace System.ComponentModel;

[AttributeUsage(6140)]
[Token(Token = "0x2000146")]
public sealed class EditorBrowsableAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005D1")]
	private EditorBrowsableState browsableState; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x600081B")]
	public EditorBrowsableAttribute(EditorBrowsableState state) { }

	[Address(RVA = "0x26487C0", Offset = "0x2647BC0", Length = "0x79")]
	[Token(Token = "0x600081C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2647A90", Offset = "0x2646E90", Length = "0x7")]
	[Token(Token = "0x600081D")]
	public virtual int GetHashCode() { }

}

