namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x2000361")]
public class WellKnownClientTypeEntry : TypeEntry
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E23")]
	private Type obj_type; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E24")]
	private string obj_url; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E25")]
	private string app_url; //Field offset: 0x30

	[Token(Token = "0x170002DE")]
	public string ApplicationUrl
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001B3D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002DF")]
	public Type ObjectType
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001B3E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002E0")]
	public string ObjectUrl
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001B3F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1EF3240", Offset = "0x1EF2640", Length = "0x14D")]
	[Token(Token = "0x6001B3C")]
	public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001B3D")]
	public string get_ApplicationUrl() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001B3E")]
	public Type get_ObjectType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001B3F")]
	public string get_ObjectUrl() { }

	[Address(RVA = "0x1EF3200", Offset = "0x1EF2600", Length = "0x40")]
	[Token(Token = "0x6001B40")]
	public virtual string ToString() { }

}

