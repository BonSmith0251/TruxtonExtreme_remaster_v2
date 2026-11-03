namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x2000363")]
public class WellKnownServiceTypeEntry : TypeEntry
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E29")]
	private Type obj_type; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E2A")]
	private string obj_uri; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E2B")]
	private WellKnownObjectMode obj_mode; //Field offset: 0x30

	[Token(Token = "0x170002E1")]
	public WellKnownObjectMode Mode
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6001B42")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170002E2")]
	public Type ObjectType
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001B43")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002E3")]
	public string ObjectUri
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001B44")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1EF3490", Offset = "0x1EF2890", Length = "0x154")]
	[Token(Token = "0x6001B41")]
	public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6001B42")]
	public WellKnownObjectMode get_Mode() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001B43")]
	public Type get_ObjectType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001B44")]
	public string get_ObjectUri() { }

	[Address(RVA = "0x1EF3390", Offset = "0x1EF2790", Length = "0xFA")]
	[Token(Token = "0x6001B45")]
	public virtual string ToString() { }

}

