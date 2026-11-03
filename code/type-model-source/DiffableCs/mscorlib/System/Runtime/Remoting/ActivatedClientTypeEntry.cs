namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x2000345")]
public class ActivatedClientTypeEntry : TypeEntry
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DCB")]
	private string applicationUrl; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DCC")]
	private Type obj_type; //Field offset: 0x28

	[Token(Token = "0x170002B9")]
	public string ApplicationUrl
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001A70")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002BA")]
	public IContextAttribute[] ContextAttributes
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001A71")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170002BB")]
	public Type ObjectType
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001A72")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1ED6CE0", Offset = "0x1ED60E0", Length = "0x14D")]
	[Token(Token = "0x6001A6F")]
	public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001A70")]
	public string get_ApplicationUrl() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001A71")]
	public IContextAttribute[] get_ContextAttributes() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001A72")]
	public Type get_ObjectType() { }

	[Address(RVA = "0x1ED6CC0", Offset = "0x1ED60C0", Length = "0x14")]
	[Token(Token = "0x6001A73")]
	public virtual string ToString() { }

}

