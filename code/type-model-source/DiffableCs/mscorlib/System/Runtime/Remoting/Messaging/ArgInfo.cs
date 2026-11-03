namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003A6")]
internal class ArgInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EA0")]
	private Int32[] _paramMap; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EA1")]
	private int _inoutArgCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EA2")]
	private MethodBase _method; //Field offset: 0x20

	[Address(RVA = "0x1EF8190", Offset = "0x1EF7590", Length = "0x1E4")]
	[Token(Token = "0x6001C65")]
	public ArgInfo(MethodBase method, ArgInfoType type) { }

	[Address(RVA = "0x1EF8060", Offset = "0x1EF7460", Length = "0x122")]
	[Token(Token = "0x6001C66")]
	public Object[] GetInOutArgs(Object[] args) { }

}

