namespace System;

[ComVisible(True)]
[Token(Token = "0x20001BA")]
public abstract class MarshalByRefObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000708")]
	private object _identity; //Field offset: 0x10

	[Token(Token = "0x17000163")]
	internal ServerIdentity ObjectIdentity
	{
		[Address(RVA = "0x2081ED0", Offset = "0x20812D0", Length = "0x3E")]
		[Token(Token = "0x6000FD0")]
		internal get { } //Length: 62
		[Address(RVA = "0x2081F10", Offset = "0x2081310", Length = "0x3E")]
		[Token(Token = "0x6000FD1")]
		internal set { } //Length: 62
	}

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000FCF")]
	protected MarshalByRefObject() { }

	[Address(RVA = "0x2081E50", Offset = "0x2081250", Length = "0x3E")]
	[Token(Token = "0x6000FD2")]
	public override ObjRef CreateObjRef(Type requestedType) { }

	[Address(RVA = "0x2081ED0", Offset = "0x20812D0", Length = "0x3E")]
	[Token(Token = "0x6000FD0")]
	internal ServerIdentity get_ObjectIdentity() { }

	[Address(RVA = "0x2081E90", Offset = "0x2081290", Length = "0x3E")]
	[Token(Token = "0x6000FD3")]
	public override object InitializeLifetimeService() { }

	[Address(RVA = "0x2081F10", Offset = "0x2081310", Length = "0x3E")]
	[Token(Token = "0x6000FD1")]
	internal void set_ObjectIdentity(ServerIdentity value) { }

}

