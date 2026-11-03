namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x2000346")]
public class ActivatedServiceTypeEntry : TypeEntry
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DCD")]
	private Type obj_type; //Field offset: 0x20

	[Token(Token = "0x170002BC")]
	public Type ObjectType
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001A75")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1ED6E40", Offset = "0x1ED6240", Length = "0x130")]
	[Token(Token = "0x6001A74")]
	public ActivatedServiceTypeEntry(string typeName, string assemblyName) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001A75")]
	public Type get_ObjectType() { }

	[Address(RVA = "0x1ED6E30", Offset = "0x1ED6230", Length = "0x10")]
	[Token(Token = "0x6001A76")]
	public virtual string ToString() { }

}

