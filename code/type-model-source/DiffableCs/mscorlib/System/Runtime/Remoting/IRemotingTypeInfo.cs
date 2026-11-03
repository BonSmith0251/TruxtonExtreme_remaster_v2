namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x200034B")]
public interface IRemotingTypeInfo
{

	[Token(Token = "0x170002C0")]
	public string TypeName
	{
		[Token(Token = "0x6001A7B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001A7C")]
	public bool CanCastTo(Type fromType, object o) { }

	[Token(Token = "0x6001A7B")]
	public string get_TypeName() { }

}

