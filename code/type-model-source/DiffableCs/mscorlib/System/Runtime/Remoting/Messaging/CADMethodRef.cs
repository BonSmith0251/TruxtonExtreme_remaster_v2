namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003AA")]
internal class CADMethodRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EB7")]
	private bool ctor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EB8")]
	private string typeName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EB9")]
	private string methodName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EBA")]
	private String[] param_names; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EBB")]
	private String[] generic_arg_names; //Field offset: 0x30

	[Address(RVA = "0x1EFB2B0", Offset = "0x1EFA6B0", Length = "0x2D3")]
	[Token(Token = "0x6001C7F")]
	public CADMethodRef(IMethodMessage msg) { }

	[Address(RVA = "0x1EFAC20", Offset = "0x1EFA020", Length = "0x149")]
	[Token(Token = "0x6001C7D")]
	private Type[] GetTypes(String[] typeArray) { }

	[Address(RVA = "0x1EFAD70", Offset = "0x1EFA170", Length = "0x531")]
	[Token(Token = "0x6001C7E")]
	public MethodBase Resolve() { }

}

