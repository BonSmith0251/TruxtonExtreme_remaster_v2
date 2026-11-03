namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003BC")]
public interface IMethodMessage : IMessage
{

	[Token(Token = "0x1700034F")]
	public int ArgCount
	{
		[Token(Token = "0x6001CD0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000350")]
	public Object[] Args
	{
		[Token(Token = "0x6001CD1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000351")]
	public LogicalCallContext LogicalCallContext
	{
		[Token(Token = "0x6001CD2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000352")]
	public MethodBase MethodBase
	{
		[Token(Token = "0x6001CD3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000353")]
	public string MethodName
	{
		[Token(Token = "0x6001CD4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000354")]
	public object MethodSignature
	{
		[Token(Token = "0x6001CD5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000355")]
	public string TypeName
	{
		[Token(Token = "0x6001CD6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000356")]
	public string Uri
	{
		[Token(Token = "0x6001CD7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001CD0")]
	public int get_ArgCount() { }

	[Token(Token = "0x6001CD1")]
	public Object[] get_Args() { }

	[Token(Token = "0x6001CD2")]
	public LogicalCallContext get_LogicalCallContext() { }

	[Token(Token = "0x6001CD3")]
	public MethodBase get_MethodBase() { }

	[Token(Token = "0x6001CD4")]
	public string get_MethodName() { }

	[Token(Token = "0x6001CD5")]
	public object get_MethodSignature() { }

	[Token(Token = "0x6001CD6")]
	public string get_TypeName() { }

	[Token(Token = "0x6001CD7")]
	public string get_Uri() { }

	[Token(Token = "0x6001CD8")]
	public object GetArg(int argNum) { }

}

