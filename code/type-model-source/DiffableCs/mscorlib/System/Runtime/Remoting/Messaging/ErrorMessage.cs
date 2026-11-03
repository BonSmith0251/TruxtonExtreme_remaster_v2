namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003B4")]
internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ED1")]
	private string _uri; //Field offset: 0x10

	[Token(Token = "0x17000343")]
	public override int ArgCount
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001CBD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000344")]
	public override Object[] Args
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001CBE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700034B")]
	public override LogicalCallContext LogicalCallContext
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001CC6")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000345")]
	public override MethodBase MethodBase
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001CBF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000346")]
	public override string MethodName
	{
		[Address(RVA = "0x1F02010", Offset = "0x1F01410", Length = "0x2C")]
		[Token(Token = "0x6001CC0")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000347")]
	public override object MethodSignature
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001CC1")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000348")]
	public override IDictionary Properties
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001CC2")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000349")]
	public override string TypeName
	{
		[Address(RVA = "0x1F02040", Offset = "0x1F01440", Length = "0x2C")]
		[Token(Token = "0x6001CC3")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700034A")]
	public override string Uri
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001CC4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F01FC0", Offset = "0x1F013C0", Length = "0x4F")]
	[Token(Token = "0x6001CBC")]
	public ErrorMessage() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001CBD")]
	public override int get_ArgCount() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001CBE")]
	public override Object[] get_Args() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001CC6")]
	public override LogicalCallContext get_LogicalCallContext() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001CBF")]
	public override MethodBase get_MethodBase() { }

	[Address(RVA = "0x1F02010", Offset = "0x1F01410", Length = "0x2C")]
	[Token(Token = "0x6001CC0")]
	public override string get_MethodName() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001CC1")]
	public override object get_MethodSignature() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001CC2")]
	public override IDictionary get_Properties() { }

	[Address(RVA = "0x1F02040", Offset = "0x1F01440", Length = "0x2C")]
	[Token(Token = "0x6001CC3")]
	public override string get_TypeName() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001CC4")]
	public override string get_Uri() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001CC5")]
	public override object GetArg(int arg_num) { }

}

