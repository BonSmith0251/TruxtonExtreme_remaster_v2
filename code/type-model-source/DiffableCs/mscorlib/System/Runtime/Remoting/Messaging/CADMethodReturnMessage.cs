namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003AD")]
internal class CADMethodReturnMessage : CADMessageBase
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000EC2")]
	private object _returnValue; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000EC3")]
	private CADArgHolder _exception; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000EC4")]
	private Type[] _sig; //Field offset: 0x48

	[Token(Token = "0x17000339")]
	internal int PropertiesCount
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6001C98")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x1EFB8A0", Offset = "0x1EFACA0", Length = "0x28A")]
	[Token(Token = "0x6001C93")]
	internal CADMethodReturnMessage(IMethodReturnMessage retMsg) { }

	[Address(RVA = "0x1EFB590", Offset = "0x1EFA990", Length = "0x82")]
	[Token(Token = "0x6001C92")]
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6001C98")]
	internal int get_PropertiesCount() { }

	[Address(RVA = "0x1EFA780", Offset = "0x1EF9B80", Length = "0xF")]
	[Token(Token = "0x6001C95")]
	internal Object[] GetArgs(ArrayList args) { }

	[Address(RVA = "0x1EFB620", Offset = "0x1EFAA20", Length = "0x1B2")]
	[Token(Token = "0x6001C94")]
	internal ArrayList GetArguments() { }

	[Address(RVA = "0x1EFB7E0", Offset = "0x1EFABE0", Length = "0xA6")]
	[Token(Token = "0x6001C97")]
	internal Exception GetException(ArrayList args) { }

	[Address(RVA = "0x1EFB890", Offset = "0x1EFAC90", Length = "0xF")]
	[Token(Token = "0x6001C96")]
	internal object GetReturnValue(ArrayList args) { }

}

