namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003A9")]
internal class CADObjRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EB4")]
	internal ObjRef objref; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EB5")]
	internal int SourceDomain; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EB6")]
	internal Byte[] TypeInfo; //Field offset: 0x20

	[Address(RVA = "0x1EFBB30", Offset = "0x1EFAF30", Length = "0x66")]
	[Token(Token = "0x6001C7C")]
	public CADObjRef(ObjRef o, int sourceDomain) { }

}

